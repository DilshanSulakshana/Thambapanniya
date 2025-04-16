using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Guest_House_Management_System.Screens;
using MySql.Data.MySqlClient;

namespace Guest_House_Management_System.Screens
{
    public partial class MakeReservation : Form
    {
        private DBconnect db = new DBconnect();
        private int? reservationId;
        private bool isChangingRoomType = false;
        private Overview _overviewForm;
        private int existingInvoiceNo;
        private decimal totalAmount;
        public ComboBox CboRoomType => cboRoomType;
        public ComboBox cboRoomNoField;

        public MakeReservation(Overview overviewForm, int? selectedReservationId = null)
        {
            InitializeComponent();
            _overviewForm = overviewForm;
            this.reservationId = selectedReservationId;

            PopulateComboBoxes(); 

            if (reservationId.HasValue)
            {
                LoadReservationData(reservationId.Value);
            }
            else
            {
                lblID.Text = "New Reservation";
                SetDefaultCheckInOutDates();
            }

            if (cboRoomType.SelectedItem != null)
            {
                LoadRoomNumbersByType(cboRoomType.SelectedItem.ToString());
            }
            cboRoomNo.Enabled = false; 
        }

        private void PopulateComboBoxes()
        {
            LoadGuestNames();
            LoadRoomTypes();
            LoadBookingStatuses();
        }

        private void LoadBookingStatuses()
        {
            cboBookingStatus.Items.Clear();
            cboBookingStatus.Items.AddRange(new string[] { "Confirmed", "Pending", "Cancelled" });
        }

        private void LoadGuestNames()
        {
            DataTable dt;

            if (reservationId.HasValue)
            {
                dt = db.GetData(@"
                SELECT GuestID, Name 
                FROM guests 
                WHERE GuestID = (SELECT GuestID FROM reservations WHERE ReservationID = @ReservationID)",
                    new MySqlParameter("@ReservationID", reservationId.Value));
            }
            else
            {
                dt = db.GetData(@"
                SELECT g.GuestID, g.Name 
                FROM guests g 
                LEFT JOIN reservations r ON g.GuestID = r.GuestID 
                WHERE r.GuestID IS NULL");
            }

            cboGuestName.DataSource = dt;
            cboGuestName.DisplayMember = "Name";
            cboGuestName.ValueMember = "GuestID";
        }

        private void LoadReservationData(int reservationId)
        {
            DataTable dt = db.GetData(@"
            SELECT r.ReservationID, r.GuestID, g.Name AS GuestName, r.RoomNo, r.CheckInDate, r.CheckOutDate, r.BookingStatus 
            FROM reservations r 
            JOIN guests g ON r.GuestID = g.GuestID 
            WHERE r.ReservationID = @ReservationID", new MySqlParameter("@ReservationID", reservationId));

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];

                lblID.Text = $"Reservation ID: {row["ReservationID"]}";
                cboGuestName.SelectedValue = row["GuestID"];
                cboRoomNo.SelectedValue = row["RoomNo"]; 

                dtpCheckIn.Value = Convert.ToDateTime(row["CheckInDate"]);
                dtpCheckOut.Value = Convert.ToDateTime(row["CheckOutDate"]);

                cboBookingStatus.SelectedItem = row["BookingStatus"].ToString(); 

                LoadRoomTypeForRoomNo(row["RoomNo"].ToString());

                CalculateTotalAmount(); 

                existingInvoiceNo = GetExistingInvoiceNo(reservationId);
            }
            else
            {
                MessageBox.Show("Reservation not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRoomTypeForRoomNo(string roomNo)
        {
            DataTable dt = db.GetData("SELECT RoomType FROM rooms WHERE RoomNo = @RoomNo", new MySqlParameter("@RoomNo", roomNo));
            if (dt.Rows.Count > 0)
            {
                string roomType = dt.Rows[0]["RoomType"].ToString();
                cboRoomType.SelectedItem = roomType; 
            }
            else
            {
                cboRoomType.SelectedIndex = -1; 
            }
        }

        private int GetExistingInvoiceNo(int reservationId)
        {
            DataTable dt = db.GetData("SELECT `Invoice No` FROM billing WHERE ReservationID = @ReservationID", new MySqlParameter("@ReservationID", reservationId));
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0]["Invoice No"]) : 0;
        }

        private void LoadRoomTypes()
        {
            cboRoomType.Items.Clear();
            cboRoomType.Items.AddRange(new string[] { "Single", "Double" });
        }

        private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            isChangingRoomType = true;

            if (cboRoomType.SelectedItem != null)
            {
                LoadRoomNumbersByType(cboRoomType.SelectedItem.ToString());
                SetDefaultCheckInOutDates();
                CalculateTotalAmount();
            }

            isChangingRoomType = false;
        }

        public void LoadRoomNumbersByType(string roomType)
        {
            DataTable dtAvailableRooms = db.GetData("SELECT RoomNo FROM rooms WHERE RoomType = @RoomType AND AvailabilityStatus = 'available'", new MySqlParameter("@RoomType", roomType));

            List<string> roomNumbers = new List<string>();

            if (dtAvailableRooms.Rows.Count > 0)
            {
                foreach (DataRow row in dtAvailableRooms.Rows)
                {
                    roomNumbers.Add(row["RoomNo"].ToString());
                }
            }

            if (reservationId.HasValue)
            {
                DataTable dtCurrentReservation = db.GetData("SELECT RoomNo FROM reservations WHERE ReservationID = @ReservationID", new MySqlParameter("@ReservationID", reservationId.Value));
                if (dtCurrentReservation.Rows.Count > 0)
                {
                    string currentRoomNo = dtCurrentReservation.Rows[0]["RoomNo"].ToString();
                    if (!roomNumbers.Contains(currentRoomNo))
                    {
                        roomNumbers.Add(currentRoomNo);
                    }
                }
            }

            cboRoomNo.DataSource = roomNumbers;
            cboRoomNo.Enabled = roomNumbers.Count > 0;

            if (roomNumbers.Count == 0)
            {
                MessageBox.Show("No available rooms of this type.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (isChangingRoomType || dtpCheckIn.Value < dtpCheckOut.Value)
            {
                CalculateTotalAmount();
            }
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (isChangingRoomType || dtpCheckIn.Value < dtpCheckOut.Value)
            {
                CalculateTotalAmount();
            }
        }

        private void SetDefaultCheckInOutDates()
        {
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);
        }

        private void CalculateTotalAmount()
        {
            if (cboRoomNo.SelectedValue != null && dtpCheckIn.Value < dtpCheckOut.Value)
            {
                decimal roomRate = GetRoomRate(cboRoomNo.SelectedValue.ToString());
                int numberOfDays = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
                totalAmount = CalculateTotal(roomRate, numberOfDays);
                txtTotalAmount.Text = totalAmount.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
            }
        }

        private decimal CalculateTotal(decimal pricePerNight, int numberOfDays)
        {
            if (numberOfDays <= 0)
            {
                return 0;
            }

            decimal discountedPricePerNight = pricePerNight - 2; 
            if (discountedPricePerNight < 0)
            {
                discountedPricePerNight = 0;
            }

            decimal total = pricePerNight;

            if (numberOfDays > 1)
            {
                total += discountedPricePerNight * (numberOfDays - 1);
            }

            return total;
        }

        private decimal GetRoomRate(string roomNo)
        {
            DataTable dt = db.GetData("SELECT PricePerNight FROM rooms WHERE RoomNo = @RoomNo", new MySqlParameter("@RoomNo", roomNo));
            return dt.Rows.Count > 0 ? Convert.ToDecimal(dt.Rows[0]["PricePerNight"]) : 0;
        }

        private bool ValidateInputs()
        {
            if (cboGuestName.SelectedValue == null || cboRoomNo.SelectedValue == null)
            {
                MessageBox.Show("Please select a guest and a room.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboBookingStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a booking status.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboRoomType.SelectedItem == null)
            {
                MessageBox.Show("Please select a room type.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public event EventHandler ReservationUpdated;

        private void OnReservationUpdated()
        {
            ReservationUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void CreateNewReservation()
        {
            int newReservationId = GetNextReservationId();
            string query = "INSERT INTO reservations (ReservationID, GuestID, RoomNo, CheckInDate, CheckOutDate, BookingStatus, rTotalAmount) VALUES (@ReservationID, @GuestID, @RoomNo, @CheckInDate, @CheckOutDate, @BookingStatus, @TotalAmount)";

            db.ExecuteQuery(query, new MySqlParameter("@ReservationID", newReservationId),
                                            new MySqlParameter("@GuestID", cboGuestName.SelectedValue),
                                            new MySqlParameter("@RoomNo", cboRoomNo.SelectedValue),
                                            new MySqlParameter("@CheckInDate", dtpCheckIn.Value),
                                            new MySqlParameter("@CheckOutDate", dtpCheckOut.Value),
                                            new MySqlParameter("@BookingStatus", cboBookingStatus.SelectedItem.ToString()),
                                            new MySqlParameter("@TotalAmount", totalAmount));

            if (cboBookingStatus.SelectedItem.ToString() == "Confirmed")
            {
                UpdateRoomStatus(cboRoomNo.SelectedValue.ToString(), "occupied");
            }
            LoadRoomNumbersByType(cboRoomType.SelectedItem.ToString());
            OnReservationUpdated();
        }
        private void UpdateRoomStatus(string roomNo, string status)
        {
            string query = "UPDATE rooms SET AvailabilityStatus = @Status WHERE RoomNo = @RoomNo";
            db.ExecuteQuery(query, new MySqlParameter("@Status", status), new MySqlParameter("@RoomNo", roomNo));
        }

        private int GetNextReservationId()
        {
            DataTable dt = db.GetData("SELECT MAX(ReservationID) AS MaxID FROM reservations");
            return dt.Rows.Count > 0 && dt.Rows[0]["MaxID"] != DBNull.Value ? Convert.ToInt32(dt.Rows[0]["MaxID"]) + 1 : 1;
        }

        private bool IsRoomAvailable(string roomNo, DateTime checkInDate, DateTime checkOutDate)
        {
            DataTable dt = db.GetData(@"
            SELECT COUNT(*) 
            FROM reservations 
            WHERE RoomNo = @RoomNo 
            AND BookingStatus = 'confirmed' AND 
            ((CheckInDate < @CheckOutDate AND CheckOutDate > @CheckInDate) OR 
            (CheckInDate >= @CheckInDate AND CheckInDate < @CheckOutDate))",
                new MySqlParameter("@RoomNo", roomNo),
                new MySqlParameter("@CheckInDate", checkInDate),
                new MySqlParameter("@CheckOutDate", checkOutDate));

            return dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) == 0;
        }

        private void UpdateReservation()
        {
            DataTable dt = db.GetData("SELECT RoomNo, CheckInDate, CheckOutDate FROM reservations WHERE ReservationID = @ReservationID", new MySqlParameter("@ReservationID", reservationId.Value));

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Reservation not found. Unable to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newRoomNo = cboRoomNo.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(newRoomNo))
            {
                MessageBox.Show("Please select a room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string oldRoomNo = dt.Rows[0]["RoomNo"]?.ToString();

            if (oldRoomNo != newRoomNo)
            {
                if (!IsRoomAvailable(newRoomNo, dtpCheckIn.Value, dtpCheckOut.Value))
                {
                    MessageBox.Show("The selected room is not available for the chosen dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UpdateRoomStatus(oldRoomNo, "available");
            }

            string query = "UPDATE reservations SET RoomNo = @RoomNo, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, BookingStatus = @BookingStatus, PaymentStatus = 'Pending', rTotalAmount = @TotalAmount WHERE ReservationID = @ReservationID";
            db.ExecuteQuery(query, new MySqlParameter("@RoomNo", newRoomNo),
                            new MySqlParameter("@CheckInDate", dtpCheckIn.Value),
                            new MySqlParameter("@CheckOutDate", dtpCheckOut.Value),
                            new MySqlParameter("@BookingStatus", cboBookingStatus.SelectedItem?.ToString()),
                            new MySqlParameter("@TotalAmount", totalAmount),
                            new MySqlParameter("@ReservationID", reservationId.Value));

            UpdateRoomStatus(newRoomNo, "occupied");

            LoadRoomNumbersByType(cboRoomType.SelectedItem.ToString());
            OnReservationUpdated();

            string removeBillingQuery = "DELETE FROM billing WHERE ReservationID = @ReservationID";
            MySqlParameter[] billingParameters = {
                new MySqlParameter("@ReservationID", reservationId.Value),
            };

            db.ExecuteQuery(removeBillingQuery, billingParameters);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                {
                    return;
                }

                string selectedRoomNo = cboRoomNo.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(selectedRoomNo))
                {
                    MessageBox.Show("Please select a room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string currentRoomNo = null;
                if (reservationId.HasValue)
                {
                    DataTable dtCurrentReservation = db.GetData("SELECT RoomNo FROM reservations WHERE ReservationID = @ReservationID", new MySqlParameter("@ReservationID", reservationId.Value));
                    if (dtCurrentReservation.Rows.Count > 0)
                    {
                        currentRoomNo = dtCurrentReservation.Rows[0]["RoomNo"].ToString();
                    }
                }

                if (currentRoomNo != selectedRoomNo && !IsRoomAvailable(selectedRoomNo, dtpCheckIn.Value, dtpCheckOut.Value))
                {
                    MessageBox.Show("The selected room is not available for the chosen dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (reservationId.HasValue)
                {
                    UpdateReservation();
                }
                else
                {
                    CreateNewReservation();
                }

                MessageBox.Show("Reservation saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _overviewForm.LoadChildForm(new Reservations(_overviewForm));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cboGuestName.SelectedIndex = -1;
            cboRoomNo.SelectedIndex = -1;
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);
            cboBookingStatus.SelectedIndex = -1;
            cboRoomType.SelectedIndex = -1;
            txtTotalAmount.Text = "$0.00"; 
            cboRoomNo.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _overviewForm.LoadChildForm(new Reservations(_overviewForm));
            this.Close();
        }
    }
}