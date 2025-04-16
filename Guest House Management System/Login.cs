using Guest_House_Management_System.Screens;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Guest_House_Management_System
{
    public partial class Login : Form
    {
        private readonly DBconnect db;

        public Login()
        {
            InitializeComponent();
            db = new DBconnect();
            errorLabel.Visible = false;
            btnShow.Visible = true;
            btnHide.Visible = false;
            txtUserName.KeyDown += txtUserName_KeyDown;
            txtPw.KeyDown += txtPw_KeyDown;

            if (!db.TestConnection())
            {
                MessageBox.Show("Unable to connect to the database. Please check your connection settings.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
            this.KeyPreview = true;

            InitializeLoginUI();
        }

        private void InitializeLoginUI()
        {
            labelUA.Text = "Staff Login";
            Panel1.Visible = false;
            Panel2.Visible = true;
            btnStaff.Visible = false;
            btnAdmin.Visible = true; 
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPw.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                errorLabel.Text = "All fields are required.";
                errorLabel.Visible = true;
                return;
            }

            string query;
            if (btnStaff.Visible) 
            {
                query = "SELECT * FROM staff WHERE Username=@Username AND Password=@Password AND UserRole='admin'";
            }
            else 
            {
                query = "SELECT * FROM staff WHERE Username=@Username AND Password=@Password AND UserRole='staff'";
            }

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password)
            };

            DataTable userData = db.GetData(query, parameters);

            if (userData.Rows.Count > 0)
            {
                string userRole = btnStaff.Visible ? "admin" : "staff";
                string userName = userData.Rows[0]["Username"].ToString();

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Overview overviewForm = new Overview(userRole, userName);
                overviewForm.Show();
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Invalid Username or Password.";
            }
        }
        private void RbtnClose_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPw.PasswordChar = '\0';
            btnShow.Visible = false;
            btnHide.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtPw.PasswordChar = '●';
            btnHide.Visible = false;
            btnShow.Visible = true;
        }

        private void AdminPanel()
        {
            Panel2.Controls.Clear();
            Panel2.Controls.Add(Panel1);
            Panel1.Visible = true;
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPanel();
            btnStaff.Visible = true;
            labelUA.Text = "Admin Login"; 
            txtUserName.Clear(); 
            txtPw.Clear();
            txtUserName.Focus();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            btnAdmin.Visible = true; 
            btnStaff.Visible = false; 
            labelUA.Text = "Staff Login"; 
            txtUserName.Clear(); 
            txtPw.Clear(); 
            txtUserName.Focus();
        }

        private void forgetPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPW resetPWForm = new ResetPW();
            resetPWForm.Show();
            this.Hide();
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                btnLogin.Focus();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                txtPw.Focus();
            }
        }
    }
}