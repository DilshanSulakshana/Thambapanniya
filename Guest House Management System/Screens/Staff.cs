using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Guest_House_Management_System.Screens
{
    public partial class Staff : Form
    {
        private DBconnect db = new DBconnect();
        private int selectedStaffId = -1;
        private int previousSelectedRowIndex = -1;

        public Staff()
        {
            InitializeComponent(); 
            LoadData();
            cmbUser.Items.AddRange(new string[] { "admin", "staff" });
            InputPnl.Visible = false;
            lblID.Text = GetNextStaffId().ToString();

        }

        private int GetNextStaffId()
        {
            DataTable dt = db.GetData("SELECT MAX(StaffID) AS MaxID FROM staff");
            return (dt.Rows.Count > 0 && dt.Rows[0]["MaxID"] != DBNull.Value) ? Convert.ToInt32(dt.Rows[0]["MaxID"]) + 1 : 1;
        }

        private void LoadData()
        {
            DataTable dt = db.GetData("SELECT StaffID, Username AS UserName, Password, UserRole FROM staff");
            dgvStaff.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            InputPnl.Visible = true;
            ClearInputs();
            selectedStaffId = -1;
            lblID.Text = "ID: " + GetNextStaffId().ToString();
        }

        private int GetAdminCount()
        {
            DataTable dt = db.GetData("SELECT COUNT(*) FROM staff WHERE UserRole = 'admin'");
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        private int GetStaffCount()
        {
            DataTable dt = db.GetData("SELECT COUNT(*) FROM staff WHERE UserRole = 'staff'");
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null)
            {
                try
                {
                    selectedStaffId = Convert.ToInt32(dgvStaff.CurrentRow.Cells["StaffID"].Value);
                    InputPnl.Visible = true;

                    txtUname.Text = dgvStaff.CurrentRow.Cells["UserName"].Value?.ToString() ?? string.Empty;
                    txtPw.Text = dgvStaff.CurrentRow.Cells["Password"].Value?.ToString() ?? string.Empty;
                    cmbUser.SelectedItem = dgvStaff.CurrentRow.Cells["UserRole"].Value?.ToString() ?? string.Empty;
                    lblID.Text = selectedStaffId.ToString();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null)
            {
                string userName = dgvStaff.CurrentRow.Cells["UserName"].Value?.ToString() ?? "unknown"; // Change here

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the staff member: {userName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        selectedStaffId = Convert.ToInt32(dgvStaff.CurrentRow.Cells["StaffID"].Value);

                        db.ExecuteQuery("DELETE FROM staff WHERE StaffID = @StaffID", new MySqlParameter("@StaffID", selectedStaffId));
                        ReorderStaffIds(selectedStaffId);
                        LoadData();
                        MessageBox.Show("Staff member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No row selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReorderStaffIds(int deletedId)
        {
            db.ExecuteQuery("UPDATE staff SET StaffID = StaffID - 1 WHERE StaffID > @DeletedID", new MySqlParameter("@DeletedID", deletedId));
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtUname.Clear();
            txtPw.Clear();
            cmbUser.SelectedItem = null;
        }

        private int GetNextAvailableStaffId()
        {
            DataTable dt = db.GetData("SELECT MIN(t1.StaffID + 1) AS NextID " +
                                      "FROM staff t1 " +
                                      "LEFT JOIN staff t2 ON t1.StaffID + 1 = t2.StaffID " +
                                      "WHERE t2.StaffID IS NULL");
            return (dt.Rows.Count > 0 && dt.Rows[0]["NextID"] != DBNull.Value) ? Convert.ToInt32(dt.Rows[0]["NextID"]) : 1;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                try
                {
                    if (GetAdminCount() >= 2 && cmbUser.SelectedItem?.ToString() == "admin")
                    {
                        MessageBox.Show("Maximum number of admins (2) reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (GetStaffCount() >= 5 && cmbUser.SelectedItem?.ToString() == "staff")
                    {
                        MessageBox.Show("Maximum number of staff members (5) reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int nxtID = GetNextAvailableStaffId();
                    db.ExecuteQuery("INSERT INTO staff (StaffID, Username, Password, UserRole) VALUES (@StaffID, @Username, @Password, @UserRole)",
                        new MySqlParameter("@StaffID", nxtID),
                        new MySqlParameter("@Username", txtUname.Text),
                        new MySqlParameter("@Password", txtPw.Text),
                        new MySqlParameter("@UserRole", cmbUser.SelectedItem?.ToString() ?? string.Empty));

                    MessageBox.Show("Staff member Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                    InputPnl.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    db.ExecuteQuery("UPDATE staff SET Username = @Username, Password = @Password, UserRole = @UserRole WHERE StaffID = @StaffID",
                        new MySqlParameter("@Username", txtUname.Text),
                        new MySqlParameter("@Password", txtPw.Text),
                        new MySqlParameter("@UserRole", cmbUser.SelectedItem?.ToString() ?? string.Empty),
                        new MySqlParameter("@StaffID", selectedStaffId));

                    MessageBox.Show("Staff member Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                    InputPnl.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (previousSelectedRowIndex >= 0 && previousSelectedRowIndex < dgvStaff.Rows.Count)
                {
                    dgvStaff.Rows[previousSelectedRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
                    dgvStaff.Rows[previousSelectedRowIndex].DefaultCellStyle.ForeColor = Color.White;
                }

                previousSelectedRowIndex = e.RowIndex;
                dgvStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(32, 40, 56);
                dgvStaff.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

                selectedStaffId = Convert.ToInt32(dgvStaff.Rows[e.RowIndex].Cells["StaffID"].Value);
                txtUname.Text = dgvStaff.Rows[e.RowIndex].Cells["UserName"].Value?.ToString() ?? string.Empty;
                txtPw.Text = dgvStaff.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? string.Empty;
                cmbUser.SelectedItem = dgvStaff.Rows[e.RowIndex].Cells["UserRole"].Value?.ToString() ?? string.Empty;
                lblID.Text = selectedStaffId.ToString();
            }
        }
        private void dgvStaff_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(30, 45, 56);
            }
        }

        private void dgvStaff_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
            }
        }
    }
}
