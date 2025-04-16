namespace Guest_House_Management_System.Screens
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpPaymentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboReservationId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClr = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTotalAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.PayPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cboPaymentStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.deleteButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.editButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnBill = new Guna.UI2.WinForms.Guna2GradientButton();
            this.addButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvBills = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.AutoRoundedCorners = true;
            this.dtpPaymentDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpPaymentDate.BorderRadius = 20;
            this.dtpPaymentDate.CheckedState.Parent = this.dtpPaymentDate;
            this.dtpPaymentDate.FillColor = System.Drawing.Color.Teal;
            this.dtpPaymentDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpPaymentDate.HoverState.Parent = this.dtpPaymentDate;
            this.dtpPaymentDate.Location = new System.Drawing.Point(22, 293);
            this.dtpPaymentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPaymentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.ShadowDecoration.Parent = this.dtpPaymentDate;
            this.dtpPaymentDate.Size = new System.Drawing.Size(206, 43);
            this.dtpPaymentDate.TabIndex = 87;
            this.dtpPaymentDate.Value = new System.DateTime(2024, 10, 12, 12, 6, 27, 900);
            // 
            // cboReservationId
            // 
            this.cboReservationId.AutoRoundedCorners = true;
            this.cboReservationId.BackColor = System.Drawing.Color.Transparent;
            this.cboReservationId.BorderRadius = 17;
            this.cboReservationId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboReservationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReservationId.FocusedColor = System.Drawing.Color.Empty;
            this.cboReservationId.FocusedState.Parent = this.cboReservationId;
            this.cboReservationId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboReservationId.FormattingEnabled = true;
            this.cboReservationId.HoverState.Parent = this.cboReservationId;
            this.cboReservationId.ItemHeight = 30;
            this.cboReservationId.ItemsAppearance.Parent = this.cboReservationId;
            this.cboReservationId.Location = new System.Drawing.Point(21, 155);
            this.cboReservationId.Name = "cboReservationId";
            this.cboReservationId.ShadowDecoration.Parent = this.cboReservationId;
            this.cboReservationId.Size = new System.Drawing.Size(206, 36);
            this.cboReservationId.TabIndex = 86;
            this.cboReservationId.SelectedIndexChanged += new System.EventHandler(this.cboReservationId_SelectedIndexChanged);
            // 
            // btnClr
            // 
            this.btnClr.AutoRoundedCorners = true;
            this.btnClr.BackColor = System.Drawing.Color.Transparent;
            this.btnClr.BorderRadius = 17;
            this.btnClr.CheckedState.Parent = this.btnClr;
            this.btnClr.CustomImages.Parent = this.btnClr;
            this.btnClr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClr.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.Color.White;
            this.btnClr.HoverState.Parent = this.btnClr;
            this.btnClr.Location = new System.Drawing.Point(22, 584);
            this.btnClr.Name = "btnClr";
            this.btnClr.ShadowDecoration.Parent = this.btnClr;
            this.btnClr.Size = new System.Drawing.Size(76, 37);
            this.btnClr.TabIndex = 85;
            this.btnClr.Text = "Clear";
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderRadius = 19;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.Green;
            this.btnSubmit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(82, 431);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(146, 41);
            this.btnSubmit.TabIndex = 83;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTotalAmount
            // 
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
            this.txtTotalAmount.Location = new System.Drawing.Point(21, 225);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PlaceholderText = "";
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.ShadowDecoration.Parent = this.txtTotalAmount;
            this.txtTotalAmount.Size = new System.Drawing.Size(206, 36);
            this.txtTotalAmount.TabIndex = 84;
            // 
            // PayPanel
            // 
            this.PayPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PayPanel.Controls.Add(this.gunaLabel2);
            this.PayPanel.Controls.Add(this.cboPaymentStatus);
            this.PayPanel.Controls.Add(this.gunaLabel5);
            this.PayPanel.Controls.Add(this.gunaLabel3);
            this.PayPanel.Controls.Add(this.lblID);
            this.PayPanel.Controls.Add(this.gunaLabel1);
            this.PayPanel.Controls.Add(this.gunaLabel6);
            this.PayPanel.Controls.Add(this.cboReservationId);
            this.PayPanel.Controls.Add(this.dtpPaymentDate);
            this.PayPanel.Controls.Add(this.txtTotalAmount);
            this.PayPanel.Controls.Add(this.btnSubmit);
            this.PayPanel.Controls.Add(this.btnClr);
            this.PayPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PayPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(3)))), ((int)(((byte)(54)))));
            this.PayPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(2)))), ((int)(((byte)(44)))));
            this.PayPanel.Location = new System.Drawing.Point(0, 0);
            this.PayPanel.Name = "PayPanel";
            this.PayPanel.ShadowDecoration.Parent = this.PayPanel;
            this.PayPanel.Size = new System.Drawing.Size(255, 646);
            this.PayPanel.TabIndex = 89;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(18, 344);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(142, 19);
            this.gunaLabel2.TabIndex = 95;
            this.gunaLabel2.Text = "Payment Status :";
            // 
            // cboPaymentStatus
            // 
            this.cboPaymentStatus.AutoRoundedCorners = true;
            this.cboPaymentStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboPaymentStatus.BorderRadius = 17;
            this.cboPaymentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cboPaymentStatus.FocusedState.Parent = this.cboPaymentStatus;
            this.cboPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPaymentStatus.FormattingEnabled = true;
            this.cboPaymentStatus.HoverState.Parent = this.cboPaymentStatus;
            this.cboPaymentStatus.ItemHeight = 30;
            this.cboPaymentStatus.ItemsAppearance.Parent = this.cboPaymentStatus;
            this.cboPaymentStatus.Location = new System.Drawing.Point(22, 366);
            this.cboPaymentStatus.Name = "cboPaymentStatus";
            this.cboPaymentStatus.ShadowDecoration.Parent = this.cboPaymentStatus;
            this.cboPaymentStatus.Size = new System.Drawing.Size(206, 36);
            this.cboPaymentStatus.TabIndex = 94;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(18, 271);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(134, 19);
            this.gunaLabel5.TabIndex = 93;
            this.gunaLabel5.Text = "Payment Date :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(18, 202);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(125, 19);
            this.gunaLabel3.TabIndex = 91;
            this.gunaLabel3.Text = "Total Amount :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(18, 99);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 22);
            this.lblID.TabIndex = 90;
            this.lblID.Text = "Invoice No :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(17, 133);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 19);
            this.gunaLabel1.TabIndex = 89;
            this.gunaLabel1.Text = "Reservation ID :";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(30, 21);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(192, 27);
            this.gunaLabel6.TabIndex = 25;
            this.gunaLabel6.Text = "Payment Details";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.BorderRadius = 15;
            this.deleteButton.CheckedState.Parent = this.deleteButton;
            this.deleteButton.CustomImages.Parent = this.deleteButton;
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.FillColor2 = System.Drawing.Color.Maroon;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.LightGray;
            this.deleteButton.HoverState.Parent = this.deleteButton;
            this.deleteButton.Location = new System.Drawing.Point(807, 565);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ShadowDecoration.Parent = this.deleteButton;
            this.deleteButton.Size = new System.Drawing.Size(136, 32);
            this.deleteButton.TabIndex = 91;
            this.deleteButton.Text = "Delete Detail";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editButton.BorderRadius = 15;
            this.editButton.CheckedState.Parent = this.editButton;
            this.editButton.CustomImages.Parent = this.editButton;
            this.editButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.editButton.FillColor2 = System.Drawing.Color.Olive;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editButton.HoverState.Parent = this.editButton;
            this.editButton.Location = new System.Drawing.Point(648, 565);
            this.editButton.Name = "editButton";
            this.editButton.ShadowDecoration.Parent = this.editButton;
            this.editButton.Size = new System.Drawing.Size(142, 32);
            this.editButton.TabIndex = 93;
            this.editButton.Text = "Edit Details";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(277, 34);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(100, 22);
            this.gunaLabel4.TabIndex = 94;
            this.gunaLabel4.Text = "Detail List :";
            // 
            // btnBill
            // 
            this.btnBill.BorderRadius = 15;
            this.btnBill.CheckedState.Parent = this.btnBill;
            this.btnBill.CustomImages.Parent = this.btnBill;
            this.btnBill.FillColor = System.Drawing.Color.Purple;
            this.btnBill.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.LightGray;
            this.btnBill.HoverState.Parent = this.btnBill;
            this.btnBill.Location = new System.Drawing.Point(281, 565);
            this.btnBill.Name = "btnBill";
            this.btnBill.ShadowDecoration.Parent = this.btnBill;
            this.btnBill.Size = new System.Drawing.Size(129, 32);
            this.btnBill.TabIndex = 95;
            this.btnBill.Text = "Get Bill";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.BorderRadius = 15;
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.FillColor = System.Drawing.Color.DodgerBlue;
            this.addButton.FillColor2 = System.Drawing.Color.Navy;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.LightGray;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(494, 565);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(136, 32);
            this.addButton.TabIndex = 96;
            this.addButton.Text = "Add to Pay";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dgvBills
            // 
            this.dgvBills.AllowUserToAddRows = false;
            this.dgvBills.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBills.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.dgvBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBills.ColumnHeadersHeight = 54;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBills.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBills.EnableHeadersVisualStyles = false;
            this.dgvBills.GridColor = System.Drawing.Color.Silver;
            this.dgvBills.Location = new System.Drawing.Point(274, 70);
            this.dgvBills.MultiSelect = false;
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBills.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBills.RowHeadersVisible = false;
            this.dgvBills.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBills.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBills.RowTemplate.Height = 30;
            this.dgvBills.RowTemplate.ReadOnly = true;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.Size = new System.Drawing.Size(695, 482);
            this.dgvBills.TabIndex = 97;
            this.dgvBills.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBills.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.dgvBills.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvBills.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvBills.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBills.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBills.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBills.ThemeStyle.HeaderStyle.Height = 54;
            this.dgvBills.ThemeStyle.ReadOnly = true;
            this.dgvBills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvBills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBills.ThemeStyle.RowsStyle.Height = 30;
            this.dgvBills.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvBills.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellClick);
            this.dgvBills.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellMouseEnter);
            this.dgvBills.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuest_CellMouseLeave);
            // 
            // Payment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(990, 646);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.PayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.Text = "Payment";
            this.PayPanel.ResumeLayout(false);
            this.PayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPaymentDate;
        private Guna.UI2.WinForms.Guna2ComboBox cboReservationId;
        private Guna.UI2.WinForms.Guna2GradientButton btnClr;
        private Guna.UI2.WinForms.Guna2GradientButton btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAmount;
        private Guna.UI2.WinForms.Guna2GradientPanel PayPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI2.WinForms.Guna2GradientButton deleteButton;
        private Guna.UI2.WinForms.Guna2GradientButton editButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cboPaymentStatus;
        private Guna.UI2.WinForms.Guna2GradientButton btnBill;
        private Guna.UI2.WinForms.Guna2GradientButton addButton;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBills;
    }
}