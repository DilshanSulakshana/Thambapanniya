using Guest_House_Management_System.Screens;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Guest_House_Management_System
{
    public partial class Overview : Form
    {
        private string userRole;
        private string userName;
        public Overview(string role, string name)
        {
            InitializeComponent();
            btnHome.Visible = false;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();

            userRole = role;
            userName = name;
            CustomizeUI();
            SetGreeting();
        }

        private void CustomizeUI()
        {
            if (userRole.Equals("staff", StringComparison.OrdinalIgnoreCase))
            {
                btnDashboard.Visible = false;
                btnRooms.Visible = false;
                btnReport.Visible = false;
                btnStaff.Visible = false;
            }
        }

        private void SetGreeting()
        {
            string greeting = GetGreetingBasedOnTime();
            greetingLbl.Text = $"Welcome back {userName}\n {greeting}!";
        }

        private string GetGreetingBasedOnTime()
        {
            var currentHour = DateTime.Now.Hour;

            if (currentHour < 12)
                return "Good Morning";
            else if (currentHour < 17)
                return "Good Afternoon";
            else if (currentHour < 21)
                return "Good Evening";
            else
                return "Good Night";
        }
        public void LoadChildForm(Form childForm)
        {
            if (guna2PanelContainer.Controls.Count > 0)
            {
                guna2PanelContainer.Controls.Clear();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            guna2PanelContainer.Controls.Add(childForm);
            guna2PanelContainer.Tag = childForm;

            childForm.Show();
        }

        private void btnsetting(object sender, EventArgs e)
        {
            foreach (Control c in SidePanel.Controls)
            {
                c.BackColor = Color.FromArgb(16, 20, 28);
            }
            Control click = (Control)sender;
            click.BackColor = Color.FromArgb(32, 50, 53);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            label1.Text = "DashBoard";
            PicBox.Image = Properties.Resources.Dashboard;
            btnsetting(btnDashboard, null);
            LoadChildForm(new Dashboard(this));
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            label1.Text = "Guests";
            PicBox.Image = Properties.Resources.guest;
            btnsetting(btnGuests, null);
            LoadChildForm(new GusetForm());
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            label1.Text = "Rooms";
            PicBox.Image = Properties.Resources.room;
            btnsetting(btnRooms, null);
            LoadChildForm(new Rooms(this));
        }

        private void btnReserv_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            label1.Text = "Reservations";
            PicBox.Image = Properties.Resources.Reservations;
            btnsetting(btnReserv, null);
            LoadChildForm(new Reservations(this));
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            label1.Text = "Payments";
            PicBox.Image = Properties.Resources.payment;
            btnsetting(btnPayment, null);
            LoadChildForm(new Payment());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Loginfm = new Login();
            Loginfm.Show();
            this.Hide();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            btnHome.Visible = false;
            DateTimeLabel.Text = DateTime.Now.ToShortDateString();
        }

        bool sidebarExpand = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SidePanel.Width -= 5;
                if (SidePanel.Width <= 54)
                {
                    sidebarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                SidePanel.Width += 5;
                if (SidePanel.Width >= 210)
                {
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            label1.Text = "Reports";
            PicBox.Image = Properties.Resources.Reports;
            btnsetting(btnReport, null);
            LoadChildForm(new Report());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            label1.Text = "Staff";
            PicBox.Image = Properties.Resources.staff;
            btnsetting(btnStaff, null);
            LoadChildForm(new Staff());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        { 
                Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            label1.Text = "Home";
            PicBox.Image = Properties.Resources.home;
            guna2PanelContainer.Controls.Clear();
            btnHome.Visible = false;
            guna2PanelContainer.Controls.Add(greetingLbl);
            SetGreeting();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
