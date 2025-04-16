using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Guest_House_Management_System
{
    public partial class ResetPW : Form
    {
        private readonly DBconnect db;
        public ResetPW()
        {
            InitializeComponent();
            db = new DBconnect();
            errorLabel.Visible = false;
            txtNewPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            btnChangePassword.Enabled = false;

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                errorLabel.Text = "Please enter a username.";
                errorLabel.Visible = true;
                return;
            }

            DataTable dt = db.GetData("SELECT * FROM staff WHERE Username = @Username", new MySqlParameter("@Username", username));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username confirmed. You can now reset the password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                btnChangePassword.Enabled = true;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.ExecuteQuery("UPDATE staff SET Password = @Password WHERE Username = @Username",
                new MySqlParameter("@Password", newPassword),
                new MySqlParameter("@Username", username));

            MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFormFields();
        }

        private void ClearFormFields()
        {
            txtUsername.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            txtNewPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            btnChangePassword.Enabled = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '●';
            btnShow.Visible = false;
            btnHide.Visible = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
            btnShow.Visible = false;
            btnHide.Visible = true;
        }

        private void btnHide2_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '●';
            btnShow2.Visible = true;
            btnHide2.Visible = false;
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '\0';
            btnShow2.Visible = false;
            btnHide2.Visible = true;
        }
    }
}
