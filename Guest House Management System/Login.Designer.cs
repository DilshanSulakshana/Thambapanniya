namespace Guest_House_Management_System
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelUApw = new System.Windows.Forms.Label();
            this.labelUAname = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.labelUA = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnStaff = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnHide = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnShow = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.RbtnClose = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPw = new Guna.UI2.WinForms.Guna2TextBox();
            this.forgetPW = new Guna.UI.WinForms.GunaLinkLabel();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUApw
            // 
            this.labelUApw.AutoSize = true;
            this.labelUApw.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUApw.Location = new System.Drawing.Point(370, 212);
            this.labelUApw.Name = "labelUApw";
            this.labelUApw.Size = new System.Drawing.Size(97, 19);
            this.labelUApw.TabIndex = 41;
            this.labelUApw.Text = "Password :";
            // 
            // labelUAname
            // 
            this.labelUAname.AutoSize = true;
            this.labelUAname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUAname.Location = new System.Drawing.Point(370, 142);
            this.labelUAname.Name = "labelUAname";
            this.labelUAname.Size = new System.Drawing.Size(109, 19);
            this.labelUAname.TabIndex = 40;
            this.labelUAname.Text = "User Name :";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(397, 413);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(234, 20);
            this.errorLabel.TabIndex = 35;
            this.errorLabel.Text = "Wrong username or password";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorLabel.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.btnLogin.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(392, 358);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(217, 51);
            this.btnLogin.TabIndex = 33;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelUA
            // 
            this.labelUA.AutoSize = true;
            this.labelUA.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.labelUA.Location = new System.Drawing.Point(428, 78);
            this.labelUA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUA.Name = "labelUA";
            this.labelUA.Size = new System.Drawing.Size(179, 35);
            this.labelUA.TabIndex = 31;
            this.labelUA.Text = "User Login";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.Panel2;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel2.BackgroundImage")));
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel2.Controls.Add(this.Panel1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(315, 543);
            this.Panel2.TabIndex = 45;
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel1.BackgroundImage")));
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(315, 543);
            this.Panel1.TabIndex = 46;
            // 
            // btnStaff
            // 
            this.btnStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStaff.BackgroundImage")));
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStaff.BorderThickness = 2;
            this.btnStaff.CheckedState.Parent = this.btnStaff;
            this.btnStaff.CustomImages.Parent = this.btnStaff;
            this.btnStaff.FillColor = System.Drawing.Color.Transparent;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.HoverState.Image")));
            this.btnStaff.HoverState.Parent = this.btnStaff;
            this.btnStaff.Location = new System.Drawing.Point(630, 473);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStaff.ShadowDecoration.Parent = this.btnStaff;
            this.btnStaff.Size = new System.Drawing.Size(60, 57);
            this.btnStaff.TabIndex = 43;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.BorderRadius = 20;
            this.btnHide.CheckedState.Parent = this.btnHide;
            this.btnHide.CustomImages.Parent = this.btnHide;
            this.btnHide.FillColor = System.Drawing.Color.Transparent;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHide.ForeColor = System.Drawing.Color.Transparent;
            this.btnHide.HoverState.Parent = this.btnHide;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.ImageSize = new System.Drawing.Size(33, 25);
            this.btnHide.Location = new System.Drawing.Point(579, 242);
            this.btnHide.Name = "btnHide";
            this.btnHide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHide.ShadowDecoration.Parent = this.btnHide;
            this.btnHide.Size = new System.Drawing.Size(47, 30);
            this.btnHide.TabIndex = 38;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BorderRadius = 20;
            this.btnShow.CheckedState.Parent = this.btnShow;
            this.btnShow.CustomImages.Parent = this.btnShow;
            this.btnShow.FillColor = System.Drawing.Color.Transparent;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnShow.HoverState.Parent = this.btnShow;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageSize = new System.Drawing.Size(33, 23);
            this.btnShow.Location = new System.Drawing.Point(579, 242);
            this.btnShow.Name = "btnShow";
            this.btnShow.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnShow.ShadowDecoration.Parent = this.btnShow;
            this.btnShow.Size = new System.Drawing.Size(47, 30);
            this.btnShow.TabIndex = 39;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdmin.BorderThickness = 2;
            this.btnAdmin.CheckedState.Parent = this.btnAdmin;
            this.btnAdmin.CustomImages.Parent = this.btnAdmin;
            this.btnAdmin.FillColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.HoverState.Parent = this.btnAdmin;
            this.btnAdmin.Location = new System.Drawing.Point(630, 473);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdmin.ShadowDecoration.Parent = this.btnAdmin;
            this.btnAdmin.Size = new System.Drawing.Size(60, 57);
            this.btnAdmin.TabIndex = 37;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // RbtnClose
            // 
            this.RbtnClose.BackColor = System.Drawing.Color.Transparent;
            this.RbtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RbtnClose.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("RbtnClose.CheckedState.Image")));
            this.RbtnClose.CheckedState.Parent = this.RbtnClose;
            this.RbtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RbtnClose.HoverState.Parent = this.RbtnClose;
            this.RbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("RbtnClose.Image")));
            this.RbtnClose.Location = new System.Drawing.Point(664, 4);
            this.RbtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.RbtnClose.Name = "RbtnClose";
            this.RbtnClose.PressedState.Parent = this.RbtnClose;
            this.RbtnClose.Size = new System.Drawing.Size(34, 33);
            this.RbtnClose.TabIndex = 34;
            this.RbtnClose.CheckedChanged += new System.EventHandler(this.RbtnClose_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txtUserName.BorderRadius = 15;
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.HoverState.Parent = this.txtUserName;
            this.txtUserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUserName.IconLeft")));
            this.txtUserName.Location = new System.Drawing.Point(356, 165);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(279, 41);
            this.txtUserName.TabIndex = 32;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtPw
            // 
            this.txtPw.BackColor = System.Drawing.Color.Transparent;
            this.txtPw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txtPw.BorderRadius = 15;
            this.txtPw.BorderThickness = 2;
            this.txtPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPw.DefaultText = "";
            this.txtPw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPw.DisabledState.Parent = this.txtPw;
            this.txtPw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPw.FocusedState.Parent = this.txtPw;
            this.txtPw.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPw.ForeColor = System.Drawing.Color.Black;
            this.txtPw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPw.HoverState.Parent = this.txtPw;
            this.txtPw.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPw.IconLeft")));
            this.txtPw.Location = new System.Drawing.Point(356, 236);
            this.txtPw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '●';
            this.txtPw.PlaceholderText = "";
            this.txtPw.SelectedText = "";
            this.txtPw.ShadowDecoration.Parent = this.txtPw;
            this.txtPw.Size = new System.Drawing.Size(279, 41);
            this.txtPw.TabIndex = 42;
            this.txtPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPw_KeyDown);
            // 
            // forgetPW
            // 
            this.forgetPW.AutoSize = true;
            this.forgetPW.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.forgetPW.Location = new System.Drawing.Point(450, 282);
            this.forgetPW.Name = "forgetPW";
            this.forgetPW.Size = new System.Drawing.Size(125, 20);
            this.forgetPW.TabIndex = 46;
            this.forgetPW.TabStop = true;
            this.forgetPW.Text = "Forgot Password?";
            this.forgetPW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetPW_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 543);
            this.Controls.Add(this.forgetPW);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.labelUApw);
            this.Controls.Add(this.labelUAname);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.RbtnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelUA);
            this.Controls.Add(this.txtPw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btnHide;
        private System.Windows.Forms.Label labelUApw;
        private System.Windows.Forms.Label labelUAname;
        private Guna.UI2.WinForms.Guna2CircleButton btnShow;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdmin;
        private System.Windows.Forms.Label errorLabel;
        private Guna.UI2.WinForms.Guna2ImageRadioButton RbtnClose;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Label labelUA;
        private Guna.UI2.WinForms.Guna2TextBox txtPw;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CircleButton btnStaff;
        private System.Windows.Forms.Panel Panel2;
        private Guna.UI.WinForms.GunaPanel Panel1;
        private Guna.UI.WinForms.GunaLinkLabel forgetPW;
    }
}

