using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Guest_House_Management_System.Screens
{
    public partial class Reservations : Form
    {
        private Overview _parentForm;
        private DBconnect db = new DBconnect();
        private int selectedReservationId = -1;
        private int previousSelectedRowIndex = -1;

        public Reservations(Overview parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            LoadData();
            dgvReservation.CellFormatting += DgvReservation_CellFormatting;
        }

        private void LoadChildForm(Form childForm)
        {
            _parentForm.LoadChildForm(childForm);
        }

        private void LoadData()
        {
            DataTable dt = db.GetData("SELECT r.ReservationID, g.Name AS GuestName, r.RoomNo, r.CheckInDate, r.CheckOutDate, r.BookingStatus, r.PaymentStatus FROM reservations r JOIN guests g ON r.GuestID = g.GuestID");
            dgvReservation.DataSource = dt;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            LoadChildForm(new MakeReservation(_parentForm));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dgvReservation.CurrentRow != null)
            {
                selectedReservationId = Convert.ToInt32(dgvReservation.CurrentRow.Cells["ReservationID"].Value);
                LoadChildForm(new MakeReservation(_parentForm, selectedReservationId));
            }
            else
            {
                MessageBox.Show("No reservation selected for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvReservation.CurrentRow != null)
            {
                string guestName = dgvReservation.CurrentRow.Cells["GuestName"].Value?.ToString() ?? "unknown";
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the reservation for guest: {guestName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        selectedReservationId = Convert.ToInt32(dgvReservation.CurrentRow.Cells["ReservationID"].Value);
                        int roomNo = Convert.ToInt32(dgvReservation.CurrentRow.Cells["RoomNo"].Value);

                        db.ExecuteQuery("DELETE FROM billing WHERE ReservationID = @ReservationID", new MySqlParameter("@ReservationID", selectedReservationId));

                        db.ExecuteQuery("DELETE FROM reservations WHERE ReservationID = @ReservationID", new MySqlParameter("@ReservationID", selectedReservationId));

                        db.ExecuteQuery("UPDATE rooms SET AvailabilityStatus = 'available' WHERE RoomNo = @RoomNo", new MySqlParameter("@RoomNo", roomNo));

                        LoadData();
                        MessageBox.Show("Reservation and associated billing record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No reservation selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (previousSelectedRowIndex >= 0 && previousSelectedRowIndex < dgvReservation.Rows.Count)
                {
                    dgvReservation.Rows[previousSelectedRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
                    dgvReservation.Rows[previousSelectedRowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                previousSelectedRowIndex = e.RowIndex;
                dgvReservation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(32, 40, 56);
                dgvReservation.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void dgvReservation_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvReservation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(30, 45, 56);
                dgvReservation.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }
        private void dgvReservation_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvReservation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
            }
        }
        private void DgvReservation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReservation.Columns[e.ColumnIndex].Name == "BookingStatus")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    switch (status)
                    {
                        case "cancelled":
                            e.CellStyle.BackColor = Color.Red;
                            break;
                        case "pending":
                            e.CellStyle.BackColor = Color.Gray;
                            break;
                        case "confirmed":
                            e.CellStyle.BackColor = Color.LightGreen;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }

            if (dgvReservation.Columns[e.ColumnIndex].Name == "PaymentStatus")
            {
                if (e.Value != null)
                {
                    string paymentStatus = e.Value.ToString();
                    switch (paymentStatus)
                    {
                        case "Pending":
                            e.CellStyle.BackColor = Color.DarkGoldenrod;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                        case "Paid":
                            e.CellStyle.BackColor = Color.Green;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                        case "Failed":
                            e.CellStyle.BackColor = Color.White;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
            if (dgvReservation.Columns[e.ColumnIndex].Name == "CheckInDate")
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime checkInDate))
                {
                    if (checkInDate.Date == DateTime.Today)
                    {
                        e.CellStyle.BackColor = Color.LightBlue;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }

            if (dgvReservation.Columns[e.ColumnIndex].Name == "CheckOutDate")
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime checkOutDate))
                {
                    if (checkOutDate.Date == DateTime.Today)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Black; 
                    }
                }
            }
        }

    }
}