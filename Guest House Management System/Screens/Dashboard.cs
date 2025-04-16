using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Guest_House_Management_System.Screens
{
    public partial class Dashboard : Form
    {
        private Overview _parentFm;
        private DBconnect dbConnect;

        public Dashboard(Overview parentForm)
        {
            InitializeComponent();
            _parentFm = parentForm;
            dbConnect = new DBconnect();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            UpdateCheckedInsAndOuts();
            UpdateUpcomingCheckedInsAndOuts();
            UpdateReservations();
            UpdatePendingBookings();
            UpdatePayments();
            UpdateRoomAvailability();
            UpdateTotalRevenue();
        }

        private void UpdateCheckedInsAndOuts()
        {
            var today = DateTime.Today;

            string queryCheckedIn = "SELECT COUNT(*) FROM reservations WHERE CheckInDate = @today AND BookingStatus = 'confirmed'";
            int checkedInCount = Convert.ToInt32(dbConnect.GetData(queryCheckedIn, new MySqlParameter("@today", today)).Rows[0][0]);
            ChkInLbl.Text = checkedInCount.ToString();
            ChkInProgBar.Value = checkedInCount; 

            string queryCheckedOut = "SELECT COUNT(*) FROM reservations WHERE CheckOutDate = @today AND BookingStatus = 'confirmed'";
            int checkedOutCount = Convert.ToInt32(dbConnect.GetData(queryCheckedOut, new MySqlParameter("@today", today)).Rows[0][0]);
            ChkOutLbl.Text = checkedOutCount.ToString();
            ChkOutProgBar.Value = checkedOutCount; 
        }

        private void UpdateUpcomingCheckedInsAndOuts()
        {
            var tomorrow = DateTime.Today.AddDays(1);
            var dayAfterTomorrow = DateTime.Today.AddDays(2);

            string queryUpcomingCheckedIn = "SELECT COUNT(*) FROM reservations WHERE CheckInDate IN (@tomorrow, @dayAfterTomorrow) AND BookingStatus = 'confirmed'";
            int upcomingCheckedInCount = Convert.ToInt32(dbConnect.GetData(queryUpcomingCheckedIn,
                new MySqlParameter("@tomorrow", tomorrow),
                new MySqlParameter("@dayAfterTomorrow", dayAfterTomorrow)).Rows[0][0]);
            UpChkInLbl.Text = upcomingCheckedInCount.ToString();

            string queryUpcomingCheckedOut = "SELECT COUNT(*) FROM reservations WHERE CheckOutDate IN (@tomorrow, @dayAfterTomorrow) AND BookingStatus = 'confirmed'";
            int upcomingCheckedOutCount = Convert.ToInt32(dbConnect.GetData(queryUpcomingCheckedOut,
                new MySqlParameter("@tomorrow", tomorrow),
                new MySqlParameter("@dayAfterTomorrow", dayAfterTomorrow)).Rows[0][0]);
            UpChkOutLbl.Text = upcomingCheckedOutCount.ToString();
        }

        private void UpdateReservations()
        {
            string queryTotalReservations = "SELECT COUNT(*) FROM reservations WHERE CheckInDate = @today AND BookingStatus = 'confirmed'";
            int totalReservations = Convert.ToInt32(dbConnect.GetData(queryTotalReservations, new MySqlParameter("@today", DateTime.Today)).Rows[0][0]);
            ReserLbl.Text = totalReservations.ToString();
        }

        private void UpdatePendingBookings()
        {
            string queryPendingBookings = "SELECT COUNT(*) FROM reservations WHERE BookingStatus = 'pending'";
            int pendingBookings = Convert.ToInt32(dbConnect.GetData(queryPendingBookings).Rows[0][0]);
            pendingBookLabl.Text = pendingBookings.ToString();
        }

        private void UpdatePayments()
        {
            string queryPendingPayments = "SELECT COUNT(*) FROM billing b INNER JOIN reservations r ON b.ReservationID = r.ReservationID WHERE r.PaymentStatus = 'Pending'";
            int pendingPaymentsCount = Convert.ToInt32(dbConnect.GetData(queryPendingPayments).Rows[0][0]);

            int totalReservations = GetTotalReservations();
            if (totalReservations > 0)
            {
                double pendingPercentage = (pendingPaymentsCount * 100.0) / totalReservations;
                pendingPayPercentLbl.Text = $"{pendingPercentage:F2}%"; 
            }
            else
            {
                pendingPayPercentLbl.Text = "0.00%"; 
            }

            PendingProgBar.Value = pendingPaymentsCount; 
        }

        private void UpdateRoomAvailability()
        {
            string queryAvailableRooms = "SELECT COUNT(*) FROM rooms WHERE AvailabilityStatus = 'available'";
            int availableRoomsCount = Convert.ToInt32(dbConnect.GetData(queryAvailableRooms).Rows[0][0]);
            AvailableLbl.Text = availableRoomsCount.ToString();
            AvailableCrclProgBar.Value = availableRoomsCount; 

            string queryOccupiedRooms = "SELECT COUNT(*) FROM rooms WHERE AvailabilityStatus = 'occupied'";
            int occupiedRoomsCount = Convert.ToInt32(dbConnect.GetData(queryOccupiedRooms).Rows[0][0]);
            OccupiedLbl.Text = occupiedRoomsCount.ToString();
            OccupiedCrclProgBar.Value = occupiedRoomsCount; 

            string queryMaintenanceRooms = "SELECT COUNT(*) FROM rooms WHERE AvailabilityStatus = 'maintenance'";
            int maintenanceRoomsCount = Convert.ToInt32(dbConnect.GetData(queryMaintenanceRooms).Rows[0][0]);
            MaintenanceLbl.Text = maintenanceRoomsCount.ToString();
            maintenanceCrclProgBar.Value = maintenanceRoomsCount; 

            int totalRooms = availableRoomsCount + occupiedRoomsCount + maintenanceRoomsCount;
            availabilityLabel.Text = $"{availableRoomsCount}/{totalRooms}";
        }

        private void UpdateTotalRevenue()
        {
            var today = DateTime.Today;

            string queryTotalRevenue = "SELECT SUM(TotalAmount) FROM billing b INNER JOIN reservations r ON b.ReservationID = r.ReservationID WHERE r.PaymentStatus = 'Paid' AND b.InvoiceDate = @today";

            decimal totalRevenue = 0;
            var result = dbConnect.GetData(queryTotalRevenue, new MySqlParameter("@today", today));

            if (result.Rows.Count > 0 && result.Rows[0][0] != DBNull.Value)
            {
                totalRevenue = Convert.ToDecimal(result.Rows[0][0]);
            }

            TotalLbl.Text = $"$ {totalRevenue:F2}"; 
        }
        private int GetTotalReservations()
        {
            string queryTotalReservations = "SELECT COUNT(*) FROM reservations";
            return Convert.ToInt32(dbConnect.GetData(queryTotalReservations).Rows[0][0]);
        }

        private void LoadChildForm(Form childForm)
        {
            _parentFm.LoadChildForm(childForm);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            LoadChildForm(new MakeReservation(_parentFm));
        }

        private void btnRoomView_Click(object sender, EventArgs e)
        {
            LoadChildForm(new Rooms(_parentFm));
        }

        private void btnResrView_Click(object sender, EventArgs e)
        {
            LoadChildForm(new Reservations(_parentFm));
        }

        private void btnPaymentView_Click(object sender, EventArgs e)
        {
            LoadChildForm(new Reservations(_parentFm));
        }

        private void btnPendingBook_Click(object sender, EventArgs e)
        {
            LoadChildForm(new Reservations(_parentFm));
        }
    }
}