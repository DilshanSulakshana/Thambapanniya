using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Guest_House_Management_System.Screens
{
    public partial class Rooms : Form
    {
        private DBconnect db = new DBconnect();
        private int selectedRoomId = -1;
        private int previousSelectedRowIndex = -1;

        public Rooms(Overview parentForm)
        {
            InitializeComponent();
            LoadData();
            dgvRooms.Refresh();
            CheckAndUpdateRoomAvailability(); 
            RoomPanel.Visible = false;
            cboRoomType.Items.AddRange(new string[] { "Single", "Double" });
            cboAvailability.Items.AddRange(new string[] { "available", "occupied", "maintenance" });
            lblID.Text = GetNextRoomId().ToString();
            dgvRooms.ClearSelection();

            AvailabilityCheckTimer = new Timer();
            AvailabilityCheckTimer.Interval = 60000; 
            AvailabilityCheckTimer.Tick += AvailabilityCheckTimer_Tick;
            AvailabilityCheckTimer.Start();
        }

        private void UpdateRoomAvailabilityAfterCheckout(int roomNumber)
        {
            try
            {
                db.ExecuteQuery(@"
                UPDATE rooms
                SET AvailabilityStatus = 'available'
                WHERE RoomNo = @RoomNo", new MySqlParameter("@RoomNo", roomNumber));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating room availability: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckAndUpdateRoomAvailability()
        {
            try
            {
                var roomsToUpdate = db.GetData(@"
                SELECT RoomNo FROM reservations 
                WHERE CheckOutDate < CURDATE() AND BookingStatus = 'confirmed'");

                foreach (DataRow row in roomsToUpdate.Rows)
                {
                    int roomNumber = Convert.ToInt32(row["RoomNo"]);
                    UpdateRoomAvailabilityAfterCheckout(roomNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking room availability: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetGuestIDByRoomNumber(int roomNumber)
        {
            DataTable dt = db.GetData("SELECT GuestID FROM reservations WHERE RoomNo = @RoomNo AND BookingStatus = 'confirmed'",
                new MySqlParameter("@RoomNo", roomNumber));

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["GuestID"]);
            }

            return -1; 
        }
        private void CheckoutGuest(int roomNumber)
        {
            int guestId = GetGuestIDByRoomNumber(roomNumber);

            if (guestId != -1)
            {
                try
                {
                    db.ExecuteQuery("UPDATE reservations SET BookingStatus = 'cancelled' WHERE GuestID = @GuestID AND RoomNo = @RoomNo",
                        new MySqlParameter("@GuestID", guestId),
                        new MySqlParameter("@RoomNo", roomNumber));

                    UpdateRoomAvailabilityAfterCheckout(roomNumber);

                    MessageBox.Show("Guest checked out successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unable to check out guest. No valid reservation found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetNextRoomId()
        {
            DataTable dt = db.GetData("SELECT MAX(RoomID) AS MaxID FROM rooms");
            return (dt.Rows.Count > 0 && dt.Rows[0]["MaxID"] != DBNull.Value) ? Convert.ToInt32(dt.Rows[0]["MaxID"]) + 1 : 1;
        }

        private int GetNextAvailableRoomId()
        {
            DataTable dt = db.GetData("SELECT MIN(t1.RoomId + 1) AS NextID " +
                                      "FROM rooms t1 " +
                                      "LEFT JOIN rooms t2 ON t1.RoomId + 1 = t2.RoomId " +
                                      "WHERE t2.RoomId IS NULL");
            return (dt.Rows.Count > 0 && dt.Rows[0]["NextID"] != DBNull.Value) ? Convert.ToInt32(dt.Rows[0]["NextID"]) : 1;
        }

        private void LoadData()
        {
            UpdateRoomAvailabilityStatus();
            CheckAndUpdateRoomAvailability();

            DataTable dt = db.GetData("SELECT RoomId, RoomNo, RoomType, PricePerNight, AvailabilityStatus FROM rooms");
            dgvRooms.DataSource = dt;
        }

        private void UpdateRoomAvailabilityStatus()
        {
            var roomsToUpdate = db.GetData(@"
            SELECT r.RoomNo 
            FROM reservations r 
            WHERE r.BookingStatus = 'confirmed' AND 
            r.CheckInDate <= CURDATE() AND r.CheckOutDate > CURDATE()");

            foreach (DataRow row in roomsToUpdate.Rows)
            {
                int roomNumber = Convert.ToInt32(row["RoomNo"]);
                db.ExecuteQuery("UPDATE rooms SET AvailabilityStatus = 'occupied' WHERE RoomNo = @RoomNo",
                    new MySqlParameter("@RoomNo", roomNumber));
            }
        }

        private void ClearInputs()
        {
            txtRoomNo.Clear();
            cboAvailability.SelectedItem = null;
            cboRoomType.SelectedItem = null;
            txtRoomPrice.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RoomPanel.Visible = true;
            ClearInputs();
            selectedRoomId = -1;
            lblID.Text = "Room ID :" + GetNextRoomId().ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow != null)
            {
                try
                {
                    selectedRoomId = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomID"].Value);
                    RoomPanel.Visible = true;

                    txtRoomNo.Text = dgvRooms.CurrentRow.Cells["RoomNo"].Value?.ToString() ?? string.Empty;
                    cboRoomType.SelectedItem = dgvRooms.CurrentRow.Cells["RoomType"].Value?.ToString() ?? string.Empty;
                    txtRoomPrice.Text = dgvRooms.CurrentRow.Cells["PricePerNight"].Value?.ToString() ?? string.Empty;
                    cboAvailability.SelectedItem = dgvRooms.CurrentRow.Cells["AvailabilityStatus"].Value?.ToString() ?? string.Empty;
                    lblID.Text = selectedRoomId.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                try
                {
                    int nxtID = GetNextAvailableRoomId();
                    decimal pricePerNight;

                    if (!decimal.TryParse(txtRoomPrice.Text, out pricePerNight))
                    {
                        MessageBox.Show("Please enter a valid price for the room.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    db.ExecuteQuery("INSERT INTO rooms (RoomID, RoomNo, RoomType, PricePerNight, AvailabilityStatus) VALUES (@RoomID, @RoomNo, @RoomType, @PricePerNight, @AvailabilityStatus )",
                        new MySqlParameter("@RoomID", nxtID),
                        new MySqlParameter("@RoomNo", txtRoomNo.Text),
                        new MySqlParameter("@RoomType", cboRoomType.SelectedItem?.ToString() ?? string.Empty),
                        new MySqlParameter("@PricePerNight", pricePerNight),
                        new MySqlParameter("@AvailabilityStatus", cboAvailability.SelectedItem?.ToString() ?? string.Empty));
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Successfully added the room's information.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoomPanel.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    decimal pricePerNight;

                    if (!decimal.TryParse(txtRoomPrice.Text, out pricePerNight))
                    {
                        MessageBox.Show("Please enter a valid price for the room.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    db.ExecuteQuery("UPDATE rooms SET RoomNo = @RoomNo, RoomType = @RoomType, PricePerNight = @PricePerNight, AvailabilityStatus = @AvailabilityStatus WHERE RoomID = @RoomID",
                        new MySqlParameter("@RoomNo", txtRoomNo.Text),
                        new MySqlParameter("@RoomType", cboRoomType.SelectedItem?.ToString() ?? string.Empty),
                        new MySqlParameter("@PricePerNight", pricePerNight),
                        new MySqlParameter("@AvailabilityStatus", cboAvailability.SelectedItem?.ToString() ?? string.Empty),
                        new MySqlParameter("@RoomID", selectedRoomId));
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Successfully updated the room's information.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoomPanel.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating the room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow != null)
            {
                string roomNo = dgvRooms.CurrentRow.Cells["RoomNo"].Value?.ToString() ?? "unknown";
                DialogResult result = MessageBox.Show($"Are you sure you want to delete Room {roomNo}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        selectedRoomId = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomID"].Value);

                        db.ExecuteQuery("DELETE FROM rooms WHERE RoomID = @RoomID", new MySqlParameter("@RoomID", selectedRoomId));
                        ReorderRoomIds(selectedRoomId);
                        LoadData();
                        MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting the Room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No row selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReorderRoomIds(int deletedId)
        {
            db.ExecuteQuery("UPDATE rooms SET RoomID = RoomID - 1 WHERE RoomID > @DeletedID", new MySqlParameter("@DeletedID", deletedId));
        }

        private void dgvRooms_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvRooms.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(30, 45, 56);
                dgvRooms.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void dgvRooms_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvRooms.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (previousSelectedRowIndex >= 0 && previousSelectedRowIndex < dgvRooms.Rows.Count)
                {
                    dgvRooms.Rows[previousSelectedRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
                    dgvRooms.Rows[previousSelectedRowIndex].DefaultCellStyle.ForeColor = Color.White;
                }

                previousSelectedRowIndex = e.RowIndex;
                dgvRooms.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(32, 40, 56);
                dgvRooms.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

                selectedRoomId = Convert.ToInt32(dgvRooms.Rows[e.RowIndex].Cells["RoomID"].Value);
                txtRoomNo.Text = dgvRooms.Rows[e.RowIndex].Cells["RoomNo"].Value?.ToString() ?? string.Empty;
                cboRoomType.SelectedItem = dgvRooms.Rows[e.RowIndex].Cells["RoomType"].Value?.ToString() ?? string.Empty;
                cboAvailability.SelectedItem = dgvRooms.Rows[e.RowIndex].Cells["AvailabilityStatus"].Value?.ToString() ?? string.Empty;
                lblID.Text = selectedRoomId.ToString();
            }
        }

        private void dgvRooms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRooms.Columns[e.ColumnIndex].Name == "AvailabilityStatus")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    switch (status)
                    {
                        case "occupied":
                            e.CellStyle.BackColor = Color.Red;
                            break;
                        case "maintenance":
                            e.CellStyle.BackColor = Color.Gray;
                            break;
                        case "available":
                            e.CellStyle.BackColor = Color.LightGreen;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
        }

        private void btnhidepnl_Click(object sender, EventArgs e)
        {
            RoomPanel.Visible = false;
        }

        private void AvailabilityCheckTimer_Tick(object sender, EventArgs e)
        {
            CheckAndUpdateRoomAvailability();
        }
    }
}