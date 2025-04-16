namespace Guest_House_Management_System.Screens
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.updateButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDone = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cboRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnhidepnl = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cboAvailability = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRoomPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.clearButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.dgvRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AvailabilityCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.RoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BorderRadius = 15;
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.FillColor2 = System.Drawing.Color.Navy;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.LightGray;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(459, 578);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(111, 32);
            this.addButton.TabIndex = 37;
            this.addButton.Text = "Add Room";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BorderRadius = 15;
            this.updateButton.CheckedState.Parent = this.updateButton;
            this.updateButton.CustomImages.Parent = this.updateButton;
            this.updateButton.FillColor = System.Drawing.Color.Teal;
            this.updateButton.FillColor2 = System.Drawing.Color.Navy;
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.LightGray;
            this.updateButton.HoverState.Parent = this.updateButton;
            this.updateButton.Location = new System.Drawing.Point(580, 578);
            this.updateButton.Name = "updateButton";
            this.updateButton.ShadowDecoration.Parent = this.updateButton;
            this.updateButton.Size = new System.Drawing.Size(125, 32);
            this.updateButton.TabIndex = 38;
            this.updateButton.Text = "Update Room";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // btnDone
            // 
            this.btnDone.AutoRoundedCorners = true;
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.BorderRadius = 19;
            this.btnDone.CheckedState.Parent = this.btnDone;
            this.btnDone.CustomImages.Parent = this.btnDone;
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(35)))), ((int)(((byte)(109)))));
            this.btnDone.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(16)))), ((int)(((byte)(85)))));
            this.btnDone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.LightGray;
            this.btnDone.HoverState.Parent = this.btnDone;
            this.btnDone.Location = new System.Drawing.Point(148, 456);
            this.btnDone.Name = "btnDone";
            this.btnDone.ShadowDecoration.Parent = this.btnDone;
            this.btnDone.Size = new System.Drawing.Size(90, 41);
            this.btnDone.TabIndex = 36;
            this.btnDone.Text = "DONE";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblID.Location = new System.Drawing.Point(18, 135);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 23);
            this.lblID.TabIndex = 62;
            this.lblID.Text = "Room ID :";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.AutoRoundedCorners = true;
            this.txtRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomNo.BorderRadius = 18;
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.DefaultText = "";
            this.txtRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.DisabledState.Parent = this.txtRoomNo;
            this.txtRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.FillColor = System.Drawing.Color.Silver;
            this.txtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.FocusedState.Parent = this.txtRoomNo;
            this.txtRoomNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.HoverState.Parent = this.txtRoomNo;
            this.txtRoomNo.Location = new System.Drawing.Point(22, 195);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.PasswordChar = '\0';
            this.txtRoomNo.PlaceholderText = "";
            this.txtRoomNo.SelectedText = "";
            this.txtRoomNo.ShadowDecoration.Parent = this.txtRoomNo;
            this.txtRoomNo.Size = new System.Drawing.Size(216, 39);
            this.txtRoomNo.TabIndex = 61;
            // 
            // deleteButton
            // 
            this.deleteButton.BorderRadius = 15;
            this.deleteButton.CheckedState.Parent = this.deleteButton;
            this.deleteButton.CustomImages.Parent = this.deleteButton;
            this.deleteButton.FillColor = System.Drawing.Color.Red;
            this.deleteButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.LightGray;
            this.deleteButton.HoverState.Parent = this.deleteButton;
            this.deleteButton.Location = new System.Drawing.Point(715, 578);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ShadowDecoration.Parent = this.deleteButton;
            this.deleteButton.Size = new System.Drawing.Size(128, 32);
            this.deleteButton.TabIndex = 39;
            this.deleteButton.Text = "Delete Room";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel1.Location = new System.Drawing.Point(18, 167);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(95, 23);
            this.gunaLabel1.TabIndex = 60;
            this.gunaLabel1.Text = "Room No :";
            // 
            // cboRoomType
            // 
            this.cboRoomType.AutoRoundedCorners = true;
            this.cboRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cboRoomType.BorderRadius = 17;
            this.cboRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FocusedColor = System.Drawing.Color.Empty;
            this.cboRoomType.FocusedState.Parent = this.cboRoomType;
            this.cboRoomType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.HoverState.Parent = this.cboRoomType;
            this.cboRoomType.ItemHeight = 30;
            this.cboRoomType.ItemsAppearance.Parent = this.cboRoomType;
            this.cboRoomType.Location = new System.Drawing.Point(22, 263);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.ShadowDecoration.Parent = this.cboRoomType;
            this.cboRoomType.Size = new System.Drawing.Size(216, 36);
            this.cboRoomType.TabIndex = 46;
            // 
            // RoomPanel
            // 
            this.RoomPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RoomPanel.Controls.Add(this.btnhidepnl);
            this.RoomPanel.Controls.Add(this.btnDone);
            this.RoomPanel.Controls.Add(this.lblID);
            this.RoomPanel.Controls.Add(this.txtRoomNo);
            this.RoomPanel.Controls.Add(this.gunaLabel1);
            this.RoomPanel.Controls.Add(this.cboAvailability);
            this.RoomPanel.Controls.Add(this.txtRoomPrice);
            this.RoomPanel.Controls.Add(this.gunaLabel5);
            this.RoomPanel.Controls.Add(this.cboRoomType);
            this.RoomPanel.Controls.Add(this.clearButton);
            this.RoomPanel.Controls.Add(this.gunaLabel9);
            this.RoomPanel.Controls.Add(this.gunaLabel7);
            this.RoomPanel.Controls.Add(this.gunaLabel3);
            this.RoomPanel.Controls.Add(this.gunaLabel6);
            this.RoomPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RoomPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.RoomPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.RoomPanel.Location = new System.Drawing.Point(715, 0);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.ShadowDecoration.Parent = this.RoomPanel;
            this.RoomPanel.Size = new System.Drawing.Size(275, 646);
            this.RoomPanel.TabIndex = 41;
            // 
            // btnhidepnl
            // 
            this.btnhidepnl.BackColor = System.Drawing.Color.Transparent;
            this.btnhidepnl.CheckedState.Parent = this.btnhidepnl;
            this.btnhidepnl.CustomImages.Parent = this.btnhidepnl;
            this.btnhidepnl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhidepnl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhidepnl.ForeColor = System.Drawing.Color.White;
            this.btnhidepnl.HoverState.Parent = this.btnhidepnl;
            this.btnhidepnl.Image = ((System.Drawing.Image)(resources.GetObject("btnhidepnl.Image")));
            this.btnhidepnl.Location = new System.Drawing.Point(2, 606);
            this.btnhidepnl.Name = "btnhidepnl";
            this.btnhidepnl.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnhidepnl.ShadowDecoration.Parent = this.btnhidepnl;
            this.btnhidepnl.Size = new System.Drawing.Size(41, 40);
            this.btnhidepnl.TabIndex = 68;
            this.btnhidepnl.Click += new System.EventHandler(this.btnhidepnl_Click);
            // 
            // cboAvailability
            // 
            this.cboAvailability.AutoRoundedCorners = true;
            this.cboAvailability.BackColor = System.Drawing.Color.Transparent;
            this.cboAvailability.BorderRadius = 17;
            this.cboAvailability.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAvailability.FocusedColor = System.Drawing.Color.Empty;
            this.cboAvailability.FocusedState.Parent = this.cboAvailability;
            this.cboAvailability.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAvailability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboAvailability.FormattingEnabled = true;
            this.cboAvailability.HoverState.Parent = this.cboAvailability;
            this.cboAvailability.ItemHeight = 30;
            this.cboAvailability.ItemsAppearance.Parent = this.cboAvailability;
            this.cboAvailability.Location = new System.Drawing.Point(22, 401);
            this.cboAvailability.Name = "cboAvailability";
            this.cboAvailability.ShadowDecoration.Parent = this.cboAvailability;
            this.cboAvailability.Size = new System.Drawing.Size(216, 36);
            this.cboAvailability.TabIndex = 47;
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.AutoRoundedCorners = true;
            this.txtRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomPrice.BorderRadius = 18;
            this.txtRoomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomPrice.DefaultText = "";
            this.txtRoomPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomPrice.DisabledState.Parent = this.txtRoomPrice;
            this.txtRoomPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomPrice.FillColor = System.Drawing.Color.Silver;
            this.txtRoomPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomPrice.FocusedState.Parent = this.txtRoomPrice;
            this.txtRoomPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRoomPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomPrice.HoverState.Parent = this.txtRoomPrice;
            this.txtRoomPrice.Location = new System.Drawing.Point(21, 331);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.PasswordChar = '\0';
            this.txtRoomPrice.PlaceholderText = "";
            this.txtRoomPrice.SelectedText = "";
            this.txtRoomPrice.ShadowDecoration.Parent = this.txtRoomPrice;
            this.txtRoomPrice.Size = new System.Drawing.Size(216, 39);
            this.txtRoomPrice.TabIndex = 41;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel5.Location = new System.Drawing.Point(18, 303);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(204, 23);
            this.gunaLabel5.TabIndex = 35;
            this.gunaLabel5.Text = "Room Price (Per Night) :";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BorderRadius = 15;
            this.clearButton.CheckedState.Parent = this.clearButton;
            this.clearButton.CustomImages.Parent = this.clearButton;
            this.clearButton.FillColor = System.Drawing.Color.Brown;
            this.clearButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.HoverState.Parent = this.clearButton;
            this.clearButton.Location = new System.Drawing.Point(21, 542);
            this.clearButton.Name = "clearButton";
            this.clearButton.ShadowDecoration.Parent = this.clearButton;
            this.clearButton.Size = new System.Drawing.Size(78, 30);
            this.clearButton.TabIndex = 45;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(26, 283);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel9.TabIndex = 38;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel7.Location = new System.Drawing.Point(18, 375);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(166, 23);
            this.gunaLabel7.TabIndex = 36;
            this.gunaLabel7.Text = "Availability Status :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel3.Location = new System.Drawing.Point(18, 237);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(110, 23);
            this.gunaLabel3.TabIndex = 33;
            this.gunaLabel3.Text = "Room Type :";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(17, 38);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(230, 27);
            this.gunaLabel6.TabIndex = 25;
            this.gunaLabel6.Text = "Rooms Informations";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(295, 31);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(202, 23);
            this.gunaLabel2.TabIndex = 64;
            this.gunaLabel2.Text = "Rooms Informations";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRooms.ColumnHeadersHeight = 54;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRooms.EnableHeadersVisualStyles = false;
            this.dgvRooms.GridColor = System.Drawing.Color.Silver;
            this.dgvRooms.Location = new System.Drawing.Point(24, 68);
            this.dgvRooms.Name = "dgvRooms";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRooms.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(966, 506);
            this.dgvRooms.TabIndex = 66;
            this.dgvRooms.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRooms.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.dgvRooms.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvRooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvRooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRooms.ThemeStyle.HeaderStyle.Height = 54;
            this.dgvRooms.ThemeStyle.ReadOnly = false;
            this.dgvRooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvRooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRooms.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvRooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            this.dgvRooms.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRooms_CellFormatting);
            this.dgvRooms.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellMouseEnter);
            this.dgvRooms.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellMouseLeave);
            // 
            // AvailabilityCheckTimer
            // 
            this.AvailabilityCheckTimer.Tick += new System.EventHandler(this.AvailabilityCheckTimer_Tick);
            // 
            // Rooms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(990, 646);
            this.Controls.Add(this.RoomPanel);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton addButton;
        private Guna.UI2.WinForms.Guna2GradientButton updateButton;
        private Guna.UI2.WinForms.Guna2GradientButton btnDone;
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
        private Guna.UI2.WinForms.Guna2GradientButton deleteButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cboRoomType;
        private Guna.UI2.WinForms.Guna2GradientPanel RoomPanel;
        private Guna.UI2.WinForms.Guna2ComboBox cboAvailability;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2GradientButton clearButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnhidepnl;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRooms;
        private System.Windows.Forms.Timer AvailabilityCheckTimer;
    }
}