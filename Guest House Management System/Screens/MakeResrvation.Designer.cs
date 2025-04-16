namespace Guest_House_Management_System.Screens
{
    partial class MakeReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeReservation));
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.clearButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.cboGuestName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboRoomNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.cboBookingStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDone = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cboRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtTotalAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblID.Location = new System.Drawing.Point(226, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(161, 23);
            this.lblID.TabIndex = 62;
            this.lblID.Text = "Reservation ID :";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BorderRadius = 15;
            this.clearButton.CheckedState.Parent = this.clearButton;
            this.clearButton.CustomImages.Parent = this.clearButton;
            this.clearButton.FillColor = System.Drawing.Color.Brown;
            this.clearButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.HoverState.Parent = this.clearButton;
            this.clearButton.Location = new System.Drawing.Point(123, 571);
            this.clearButton.Name = "clearButton";
            this.clearButton.ShadowDecoration.Parent = this.clearButton;
            this.clearButton.Size = new System.Drawing.Size(90, 31);
            this.clearButton.TabIndex = 45;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel7.Location = new System.Drawing.Point(226, 279);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(155, 22);
            this.gunaLabel7.TabIndex = 36;
            this.gunaLabel7.Text = "Check-In Date : ";
            // 
            // cboGuestName
            // 
            this.cboGuestName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGuestName.AutoRoundedCorners = true;
            this.cboGuestName.BackColor = System.Drawing.Color.Transparent;
            this.cboGuestName.BorderRadius = 17;
            this.cboGuestName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGuestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGuestName.FocusedColor = System.Drawing.Color.Empty;
            this.cboGuestName.FocusedState.Parent = this.cboGuestName;
            this.cboGuestName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGuestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGuestName.FormattingEnabled = true;
            this.cboGuestName.HoverState.Parent = this.cboGuestName;
            this.cboGuestName.ItemHeight = 30;
            this.cboGuestName.ItemsAppearance.Parent = this.cboGuestName;
            this.cboGuestName.Location = new System.Drawing.Point(230, 142);
            this.cboGuestName.Name = "cboGuestName";
            this.cboGuestName.ShadowDecoration.Parent = this.cboGuestName;
            this.cboGuestName.Size = new System.Drawing.Size(267, 36);
            this.cboGuestName.TabIndex = 64;
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRoomNo.AutoRoundedCorners = true;
            this.cboRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.cboRoomNo.BorderRadius = 17;
            this.cboRoomNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomNo.FocusedColor = System.Drawing.Color.Empty;
            this.cboRoomNo.FocusedState.Parent = this.cboRoomNo;
            this.cboRoomNo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboRoomNo.FormattingEnabled = true;
            this.cboRoomNo.HoverState.Parent = this.cboRoomNo;
            this.cboRoomNo.ItemHeight = 30;
            this.cboRoomNo.ItemsAppearance.Parent = this.cboRoomNo;
            this.cboRoomNo.Location = new System.Drawing.Point(230, 223);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.ShadowDecoration.Parent = this.cboRoomNo;
            this.cboRoomNo.Size = new System.Drawing.Size(225, 36);
            this.cboRoomNo.TabIndex = 66;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel8.Location = new System.Drawing.Point(226, 198);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(101, 22);
            this.gunaLabel8.TabIndex = 82;
            this.gunaLabel8.Text = "Room No :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel2.Location = new System.Drawing.Point(226, 117);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(130, 22);
            this.gunaLabel2.TabIndex = 83;
            this.gunaLabel2.Text = "Guset Name :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel3.Location = new System.Drawing.Point(521, 279);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(170, 22);
            this.gunaLabel3.TabIndex = 84;
            this.gunaLabel3.Text = "Check-Out Date : ";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel10.Location = new System.Drawing.Point(521, 198);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(151, 22);
            this.gunaLabel10.TabIndex = 87;
            this.gunaLabel10.Text = "Booking Status : ";
            // 
            // cboBookingStatus
            // 
            this.cboBookingStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboBookingStatus.AutoRoundedCorners = true;
            this.cboBookingStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboBookingStatus.BorderRadius = 17;
            this.cboBookingStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBookingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookingStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cboBookingStatus.FocusedState.Parent = this.cboBookingStatus;
            this.cboBookingStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBookingStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboBookingStatus.FormattingEnabled = true;
            this.cboBookingStatus.HoverState.Parent = this.cboBookingStatus;
            this.cboBookingStatus.ItemHeight = 30;
            this.cboBookingStatus.ItemsAppearance.Parent = this.cboBookingStatus;
            this.cboBookingStatus.Location = new System.Drawing.Point(525, 223);
            this.cboBookingStatus.Name = "cboBookingStatus";
            this.cboBookingStatus.ShadowDecoration.Parent = this.cboBookingStatus;
            this.cboBookingStatus.Size = new System.Drawing.Size(225, 36);
            this.cboBookingStatus.TabIndex = 86;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDone.AutoRoundedCorners = true;
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.BorderRadius = 21;
            this.btnDone.CheckedState.Parent = this.btnDone;
            this.btnDone.CustomImages.Parent = this.btnDone;
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.btnDone.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnDone.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.LightGray;
            this.btnDone.HoverState.Parent = this.btnDone;
            this.btnDone.Location = new System.Drawing.Point(611, 465);
            this.btnDone.Name = "btnDone";
            this.btnDone.ShadowDecoration.Parent = this.btnDone;
            this.btnDone.Size = new System.Drawing.Size(119, 44);
            this.btnDone.TabIndex = 88;
            this.btnDone.Text = "DONE";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel1.Location = new System.Drawing.Point(521, 117);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(118, 22);
            this.gunaLabel1.TabIndex = 90;
            this.gunaLabel1.Text = "Room Type :";
            // 
            // cboRoomType
            // 
            this.cboRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRoomType.AutoRoundedCorners = true;
            this.cboRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cboRoomType.BorderRadius = 17;
            this.cboRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FocusedColor = System.Drawing.Color.Empty;
            this.cboRoomType.FocusedState.Parent = this.cboRoomType;
            this.cboRoomType.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.HoverState.Parent = this.cboRoomType;
            this.cboRoomType.ItemHeight = 30;
            this.cboRoomType.ItemsAppearance.Parent = this.cboRoomType;
            this.cboRoomType.Location = new System.Drawing.Point(525, 142);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.ShadowDecoration.Parent = this.cboRoomType;
            this.cboRoomType.Size = new System.Drawing.Size(225, 36);
            this.cboRoomType.TabIndex = 89;
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.cboRoomType_SelectedIndexChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(227, 394);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(125, 19);
            this.gunaLabel4.TabIndex = 93;
            this.gunaLabel4.Text = "Total Amount :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalAmount.AutoRoundedCorners = true;
            this.txtTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalAmount.BorderRadius = 17;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.DefaultText = "";
            this.txtTotalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.DisabledState.Parent = this.txtTotalAmount;
            this.txtTotalAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.FillColor = System.Drawing.Color.Silver;
            this.txtTotalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.FocusedState.Parent = this.txtTotalAmount;
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.HoverState.Parent = this.txtTotalAmount;
            this.txtTotalAmount.Location = new System.Drawing.Point(230, 417);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PlaceholderText = "";
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.ShadowDecoration.Parent = this.txtTotalAmount;
            this.txtTotalAmount.Size = new System.Drawing.Size(206, 36);
            this.txtTotalAmount.TabIndex = 92;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCheckIn.CheckedState.Parent = this.dtpCheckIn;
            this.dtpCheckIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckIn.HoverState.Parent = this.dtpCheckIn;
            this.dtpCheckIn.Location = new System.Drawing.Point(230, 305);
            this.dtpCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.ShadowDecoration.Parent = this.dtpCheckIn;
            this.dtpCheckIn.Size = new System.Drawing.Size(225, 40);
            this.dtpCheckIn.TabIndex = 94;
            this.dtpCheckIn.Value = new System.DateTime(2024, 11, 5, 16, 43, 30, 115);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCheckOut.CheckedState.Parent = this.dtpCheckOut;
            this.dtpCheckOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckOut.HoverState.Parent = this.dtpCheckOut;
            this.dtpCheckOut.Location = new System.Drawing.Point(525, 305);
            this.dtpCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.ShadowDecoration.Parent = this.dtpCheckOut;
            this.dtpCheckOut.Size = new System.Drawing.Size(225, 40);
            this.dtpCheckOut.TabIndex = 95;
            this.dtpCheckOut.Value = new System.DateTime(2024, 11, 5, 16, 43, 30, 115);
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.Teal;
            this.btnBack.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.HoverState.Image")));
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(37, 37);
            this.btnBack.Location = new System.Drawing.Point(44, 35);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(47, 47);
            this.btnBack.TabIndex = 96;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MakeReservation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(990, 646);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.cboRoomType);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.cboBookingStatus);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.cboRoomNo);
            this.Controls.Add(this.cboGuestName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gunaLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeReservation";
            this.Text = "MakeResrvation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI2.WinForms.Guna2GradientButton clearButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox cboGuestName;
        private Guna.UI2.WinForms.Guna2ComboBox cboRoomNo;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI2.WinForms.Guna2ComboBox cboBookingStatus;
        private Guna.UI2.WinForms.Guna2GradientButton btnDone;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cboRoomType;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAmount;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckIn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckOut;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
    }
}