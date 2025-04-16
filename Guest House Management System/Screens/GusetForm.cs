using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Guest_House_Management_System.Screens
{
    public partial class GusetForm : Form
    {
        private DBconnect db = new DBconnect();
        private int selectedGuestId = -1;
        private int previousSelectedRowIndex = -1;

        public GusetForm()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadData();
            GuestPanel.Visible = false;
            lblID.Text = GetNextGuestId().ToString();
            dgvGuest.ClearSelection();
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtContactNo.TextChanged += txtContactNo_TextChanged;
            txtContactNo.KeyPress += txtContactNo_KeyPress;
        }

        private void SetupDataGridView()
        {
            dgvGuest.AutoGenerateColumns = false;
            dgvGuest.Columns.Clear();
            dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuest.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "GuestID", HeaderText = "Guest ID", DataPropertyName = "GuestID", ReadOnly = true },
                new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Full Name", DataPropertyName = "Name" },
                new DataGridViewTextBoxColumn { Name = "NIC", HeaderText = "NIC", DataPropertyName = "NIC" },
                new DataGridViewTextBoxColumn { Name = "Country", HeaderText = "Country", DataPropertyName = "Country" },
                new DataGridViewTextBoxColumn { Name = "ContactNo", HeaderText = "Contact No", DataPropertyName = "ContactNumber" },
                new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", DataPropertyName = "Email" }
            });

            dgvGuest.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
            dgvGuest.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGuest.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            dgvGuest.Columns["GuestID"].Width = 80;
            dgvGuest.Columns["NIC"].Width = 130;
            dgvGuest.Columns["Country"].Width = 130;
            dgvGuest.Columns["ContactNo"].Width = 130;
            dgvGuest.Columns["Name"].Width = 200;
        }

        private int GetNextGuestId()
        {
            DataTable dt = db.GetData("SELECT MAX(GuestID) AS MaxID FROM guests");
            return (dt.Rows.Count > 0 && dt.Rows[0]["MaxID"] != DBNull.Value) ? Convert.ToInt32(dt.Rows[0]["MaxID"]) + 1 : 1;
        }

        private void LoadData()
        {
            DataTable dt = db.GetData("SELECT GuestID, Name, NIC, Country, ContactNumber, Email FROM guests");
            dgvGuest.DataSource = dt;
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtNIC.Clear();
            txtCountry.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GuestPanel.Visible = true;
            ClearInputs();
            selectedGuestId = -1;
            lblID.Text = "Guest ID: " + GetNextGuestId().ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dgvGuest.CurrentRow != null)
            {
                try
                {
                    selectedGuestId = Convert.ToInt32(dgvGuest.CurrentRow.Cells["GuestID"].Value);
                    GuestPanel.Visible = true;
                    txtName.Text = dgvGuest.CurrentRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                    txtNIC.Text = dgvGuest.CurrentRow.Cells["NIC"].Value?.ToString() ?? string.Empty;
                    txtCountry.Text = dgvGuest.CurrentRow.Cells["Country"].Value?.ToString() ?? string.Empty;
                    txtContactNo.Text = dgvGuest.CurrentRow.Cells["ContactNo"].Value?.ToString() ?? string.Empty;
                    txtEmail.Text = dgvGuest.CurrentRow.Cells["Email"].Value?.ToString() ?? string.Empty;
                    lblID.Text = "Guest ID: " + selectedGuestId.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving data: {ex.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNIC.Text) || txtNIC.Text.Length < 5)
            {
                MessageBox.Show("NIC cannot be empty and must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIC.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Country cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCountry.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContactNo.Text) || !IsValidPhoneNumber(txtContactNo.Text))
            {
                MessageBox.Show("Contact Number is invalid. Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email is invalid. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string cleanedNumber = new string(phoneNumber.Where(c => char.IsDigit(c) || c == '+').ToArray());

            if (cleanedNumber.StartsWith("+") && cleanedNumber.Length >= 11)
            {
                return cleanedNumber.Count(char.IsDigit) >= 10 && cleanedNumber.Count(char.IsDigit) <= 15;
            }

            if (cleanedNumber.StartsWith("0") && cleanedNumber.Length == 10)
            {
                return true;
            }

            return false; 
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            if (selectedGuestId == -1)
            {
                AddNewGuest();
            }
            else
            {
                UpdateExistingGuest();
            }
        }

        private void AddNewGuest()
        {
            try
            {
                int nextId = GetNextGuestId();
                string query = "INSERT INTO guests (GuestID, Name, NIC, Country, ContactNumber, Email) VALUES (@GuestID, @Name, @NIC, @Country, @ContactNo, @Email)";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@GuestID", nextId),
                    new MySqlParameter("@Name", txtName.Text),
                    new MySqlParameter("@NIC", txtNIC.Text),
                    new MySqlParameter("@Country", txtCountry.Text),
                    new MySqlParameter("@ContactNo", txtContactNo.Text),
                    new MySqlParameter("@Email", txtEmail.Text),
                };

                db.ExecuteQuery(query, parameters);
                LoadData();
                ClearInputs();
                MessageBox.Show("Guest added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuestPanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding guest: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateExistingGuest()
        {
            try
            {
                string query = "UPDATE guests SET Name = @Name, NIC = @NIC, Country = @Country, ContactNumber = @ContactNo, Email = @Email WHERE GuestID = @GuestID";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@Name", txtName.Text),
                    new MySqlParameter("@NIC", txtNIC.Text),
                    new MySqlParameter("@Country", txtCountry.Text),
                    new MySqlParameter("@ContactNo", txtContactNo.Text),
                    new MySqlParameter("@Email", txtEmail.Text),
                    new MySqlParameter("@GuestID", selectedGuestId)
                };

                db.ExecuteQuery(query, parameters);
                LoadData();
                ClearInputs();
                MessageBox.Show("Guest updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuestPanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating guest: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvGuest.CurrentRow != null)
            {
                string guestName = dgvGuest.CurrentRow.Cells["Name"].Value?.ToString() ?? "unknown";

                DialogResult result = MessageBox.Show($"Are you sure you want to delete this guest: {guestName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int guestId = Convert.ToInt32(dgvGuest.CurrentRow.Cells["GuestID"].Value);
                        string query = "DELETE FROM guests WHERE GuestID = @GuestID";
                        db.ExecuteQuery(query, new MySqlParameter("@GuestID", guestId));
                        LoadData();
                        MessageBox.Show("Guest deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting guest: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No row selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (previousSelectedRowIndex >= 0 && previousSelectedRowIndex < dgvGuest.Rows.Count)
                {
                    dgvGuest.Rows[previousSelectedRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
                    dgvGuest.Rows[previousSelectedRowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                previousSelectedRowIndex = e.RowIndex;
                dgvGuest.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(32, 40, 56);
                dgvGuest.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

                selectedGuestId = Convert.ToInt32(dgvGuest.Rows[e.RowIndex].Cells["GuestID"].Value);
                txtName.Text = dgvGuest.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? string.Empty;
                txtNIC.Text = dgvGuest.Rows[e.RowIndex].Cells["NIC"].Value?.ToString() ?? string.Empty;
                txtCountry.Text = dgvGuest.Rows[e.RowIndex].Cells["Country"].Value?.ToString() ?? string.Empty;
                txtContactNo.Text = dgvGuest.Rows[e.RowIndex].Cells["ContactNo"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = dgvGuest.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? string.Empty;
                lblID.Text = "Guest ID: " + selectedGuestId.ToString();
            }
        }

        private void dgvGuest_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvGuest.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(30, 45, 56);
                dgvGuest.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                dgvGuest.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
            }
        }

        private void dgvGuest_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvGuest.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
            }
        }

        private void btnhidepnl_Click(object sender, EventArgs e)
        {
            GuestPanel.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadData();
                return;
            }

            string query = "SELECT GuestID, Name, NIC, Country, ContactNumber, Email FROM guests " +
                           "WHERE Name LIKE @SearchText OR NIC LIKE @SearchText OR Country LIKE @SearchText " +
                           "OR ContactNumber LIKE @SearchText OR Email LIKE @SearchText";

            MySqlParameter[] parameters = {
                new MySqlParameter("@SearchText", "%" + searchText + "%")
            };

            DataTable dt = db.GetData(query, parameters);
            dgvGuest.DataSource = dt;
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            txtContactNo.TextChanged -= txtContactNo_TextChanged;

            string input = txtContactNo.Text;
            string cleanedInput = new string(input.Where(c => char.IsDigit(c) || c == '+').ToArray());

            if (!string.IsNullOrEmpty(cleanedInput))
            {
                if (cleanedInput.StartsWith("+"))
                {
                    txtContactNo.MaxLength = 16;

                    if (cleanedInput.Length > 16)
                    {
                        cleanedInput = cleanedInput.Substring(0, 16);
                    }
                    txtContactNo.Text = FormatInternationalNumber(cleanedInput);
                }
                else if (cleanedInput.StartsWith("0"))
                {
                    txtContactNo.MaxLength = 10;

                    if (cleanedInput.Length > 10)
                    {
                        cleanedInput = cleanedInput.Substring(0, 10);
                    }
                    txtContactNo.Text = FormatLocalNumber(cleanedInput);
                }
                else
                {
                    txtContactNo.Text = cleanedInput;
                }
            }

            txtContactNo.SelectionStart = txtContactNo.Text.Length;

            txtContactNo.TextChanged += txtContactNo_TextChanged;
        }

        private string FormatLocalNumber(string localNumber)
        {
            if (localNumber.Length == 10)
            {
                string areaCode = localNumber.Substring(0, 3);
                string nationalNumber = localNumber.Substring(3);
                return $"({areaCode}) {nationalNumber}";
            }
            return localNumber;
        }

        private string FormatInternationalNumber(string internationalNumber)
        {
            if (internationalNumber.Length >= 4)
            {
                string countryCode = internationalNumber.Substring(0, 4);
                string nationalNumber = internationalNumber.Length > 4 ? internationalNumber.Substring(4) : "";
                return $"{countryCode} {nationalNumber}";
            }
            return internationalNumber;
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}