using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;
using System.Drawing;
using Font = iTextSharp.text.Font;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Guest_House_Management_System.Screens
{
    public partial class Payment : Form
    {
        private DBconnect db = new DBconnect();
        private int selectedInvoiceNo = -1;
        private int previousSelectedRowIndex = -1;
        private int? reservationId = null;
        private decimal? totalAmount = 0;

        public Payment()
        {
            InitializeComponent();
            LoadReservationIds();
            SetupDataGridView();
            lblID.Text = GetNextInvoiceNo().ToString();
            LoadData();
            dgvBills.ClearSelection();
            LoadPaymentStatus();
            PayPanel.Visible = false;
        }

        private void LoadReservationIds()
        {
            try
            {
                string query = "SELECT ReservationID FROM reservations WHERE PaymentStatus = 'Pending' OR PaymentStatus = 'Failed'"; 
                DataTable dt = db.GetData(query);

                var items = new List<string> { "Select a Reservation" };

                foreach (DataRow row in dt.Rows)
                {
                    items.Add(row["ReservationID"].ToString());
                }

                cboReservationId.DataSource = items;
                cboReservationId.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservation IDs: {ex.Message}", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LoadPaymentStatus()
 
        { 
            cboPaymentStatus.Items.Clear();  
            cboPaymentStatus.Items.Add("Pending"); 
            cboPaymentStatus.Items.Add("Paid"); 
            cboPaymentStatus.SelectedIndex = 0;  
        } 
 
        private void cboReservationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReservationId.SelectedItem != null && cboReservationId.SelectedIndex > 0)
            {
                int selectedReservationId;
                if (int.TryParse(cboReservationId.SelectedItem.ToString(), out selectedReservationId))
                {
                    reservationId = selectedReservationId;

                    string query = "SELECT r.rTotalAmount FROM reservations r WHERE r.ReservationID = @ReservationID"; 
                    MySqlParameter parameter = new MySqlParameter("@ReservationID", selectedReservationId);
                    DataTable dt = db.GetData(query, parameter);

                    if (dt.Rows.Count > 0)
                    {
                        totalAmount = Convert.ToDecimal(dt.Rows[0]["rTotalAmount"]);
                        txtTotalAmount.Text = string.Format(CultureInfo.GetCultureInfo("en-US"), "{0:C2}", totalAmount);
                        dtpPaymentDate.Value = DateTime.Now;
                    }
                }
            }
        }

        private void SetupDataGridView()
        {
            dgvBills.CurrentCell = null;
            dgvBills.ReadOnly = true;
            dgvBills.AutoGenerateColumns = false;
            dgvBills.Columns.Clear();

            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InvoiceNo",
                HeaderText = "Invoice No",
                DataPropertyName = "Invoice No",
                ReadOnly = true
            });

            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ReservationID",
                HeaderText = "Reservation ID",
                DataPropertyName = "ReservationID"
            });


            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InvoiceDate",
                HeaderText = "Invoice Date",
                DataPropertyName = "InvoiceDate"
            });

            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                HeaderText = "Total Amount",
                DataPropertyName = "TotalAmount"
            });

            dgvBills.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBills.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBills.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12,System.Drawing.FontStyle.Bold);
        }

        private int GetNextInvoiceNo()
        {
            DataTable dt = db.GetData("SELECT MAX(`Invoice No`) AS MaxID FROM billing");
            return (dt.Rows.Count > 0 && dt.Rows[0]["MaxID"] != DBNull.Value) ?Convert.ToInt32(dt.Rows[0]["MaxID"]) + 1 : 1;
        }

        private void LoadData()
        {
            string query = "SELECT `Invoice No`, ReservationID, InvoiceDate, TotalAmount FROM billing";

            DataTable dt = db.GetData(query);
            dgvBills.DataSource = dt;
            dgvBills.CellFormatting += DgvBills_CellFormatting;
        }

        private void DgvBills_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBills.Columns[e.ColumnIndex].Name == "TotalAmount" && e.Value != null)
            {
                e.Value = string.Format(CultureInfo.GetCultureInfo("en-US"), "{0:C2}", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtTotalAmount.Clear();
            cboReservationId.SelectedIndex = 0;
            dtpPaymentDate.Value = DateTime.Now;
            cboPaymentStatus.SelectedIndex = 0;
            lblID.Text = "Invoice No: " + GetNextInvoiceNo().ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (reservationId == null || reservationId <= 0)
                {
                    MessageBox.Show("Please select a reservation ID.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                string totalAmountText = txtTotalAmount.Text.Replace("$", "").Replace(",", "").Trim();
                decimal selectedTotalAmount;
                if (!decimal.TryParse(totalAmountText, NumberStyles.Currency, CultureInfo.CurrentCulture,out selectedTotalAmount))
                {
                    MessageBox.Show("Invalid total amount format. Please enter a valid amount.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string paymentStatus = cboPaymentStatus.SelectedItem?.ToString() ?? string.Empty;

                if (selectedInvoiceNo == -1)
                {
                    int nextInvNo = GetNextInvoiceNo();
                    string insertQuery = "INSERT INTO billing (`Invoice No`, ReservationID, InvoiceDate, TotalAmount) VALUES (@InvoiceNo, @ReservationID, @InvoiceDate, @TotalAmount)"; MySqlParameter[] insertParameters = {
                    new MySqlParameter("@InvoiceNo", nextInvNo),
                    new MySqlParameter("@ReservationID", reservationId.Value),
                    new MySqlParameter("@InvoiceDate", dtpPaymentDate.Value),
                    new MySqlParameter("@TotalAmount", selectedTotalAmount)
                };

                    db.ExecuteQuery(insertQuery, insertParameters);
                    MessageBox.Show("Payment recorded successfully!", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    string updateQuery = "UPDATE billing SET ReservationID = @ReservationID, InvoiceDate = @InvoiceDate, TotalAmount = @TotalAmount WHERE `Invoice No` = @InvoiceNo"; 
                    MySqlParameter[] updateParameters = {
                    new MySqlParameter("@ReservationID", reservationId.Value),
                    new MySqlParameter("@InvoiceDate", dtpPaymentDate.Value),
                    new MySqlParameter("@TotalAmount", selectedTotalAmount),
                    new MySqlParameter("@InvoiceNo", selectedInvoiceNo)
                };

                    db.ExecuteQuery(updateQuery, updateParameters);
                    MessageBox.Show("Payment updated successfully!", "Success ", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                string updateStatusQuery = "UPDATE reservations SET PaymentStatus = @PaymentStatus WHERE ReservationID = @ReservationID"; 
                MySqlParameter statusParameter = new MySqlParameter("@PaymentStatus", paymentStatus);
                MySqlParameter reservationParameter = new MySqlParameter("@ReservationID", reservationId.Value);
                db.ExecuteQuery(updateStatusQuery, statusParameter, reservationParameter);

                ClearInputs();
                PayPanel.Visible = false;
                LoadData();
                LoadReservationIds();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void dgvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (previousSelectedRowIndex >= 0 && previousSelectedRowIndex < dgvBills.Rows.Count)
                {
                    dgvBills.Rows[previousSelectedRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
                    dgvBills.Rows[previousSelectedRowIndex].DefaultCellStyle.ForeColor = Color.White;
                }

                previousSelectedRowIndex = e.RowIndex;
                dgvBills.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(32, 40, 56);
                dgvBills.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

                selectedInvoiceNo = Convert.ToInt32(dgvBills.Rows[e.RowIndex].Cells["InvoiceNo"].Value);
                cboReservationId.SelectedItem = dgvBills.Rows[e.RowIndex].Cells["ReservationID"].Value?.ToString() ??string.Empty;
                txtTotalAmount.Text = dgvBills.Rows[e.RowIndex].Cells["TotalAmount"].Value?.ToString() ??string.Empty;
                lblID.Text = "Invoice No: " + selectedInvoiceNo.ToString();
            }
        }
        private void dgvBills_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvBills.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(30, 45, 56);
                dgvBills.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                dgvBills.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Bold);
            }
        }

        private void dgvGuest_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousSelectedRowIndex)
            {
                dgvBills.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(16, 20, 28);
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (dgvBills.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBills.SelectedRows[0];

                reservationId = row.Cells["ReservationID"].Value as int?;
                totalAmount = row.Cells["TotalAmount"].Value as decimal?;

                if (selectedInvoiceNo != -1)
                {
                    if (reservationId.HasValue && totalAmount.HasValue)
                    {
                        GeneratePDFBill(reservationId.Value, totalAmount.Value);
                    }
                    else
                    {
                        MessageBox.Show("Reservation ID or Total Amount is not set. Please select a valid invoice.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an invoice to generate the bill.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the table before generating a bill.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneratePDFBill(int reservationId, decimal totalAmount)
        {
            try


            {
                string query = @" 
                SELECT g.Name, g.ContactNumber, g.Email,  
                       r.CheckInDate, r.CheckOutDate,  
                       rm.RoomNo, rm.RoomType, rm.PricePerNight  
                FROM reservations r  
                JOIN guests g ON r.GuestID = g.GuestID  
                JOIN rooms rm ON r.RoomNo = rm.RoomNo  
                WHERE r.ReservationID = @ReservationID";

                MySqlParameter parameter = new MySqlParameter("@ReservationID", reservationId);
                DataTable dt = db.GetData(query, parameter);

                if (dt.Rows.Count > 0)
                {
                    DataRow data = dt.Rows[0];
                    Document document = new Document();
                    string fileName = $"Invoice_{reservationId}.pdf";
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                    document.Open();

                    BaseFont titleBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252,BaseFont.NOT_EMBEDDED);
                    BaseFont headingBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252,BaseFont.NOT_EMBEDDED);
                    BaseFont regularBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252,BaseFont.NOT_EMBEDDED);

                    Font titleFont = new Font(titleBaseFont, 18);
                    Font headingFont = new Font(headingBaseFont, 12);
                    Font regularFont = new Font(regularBaseFont, 10);

                    document.Add(new Paragraph("Thambapanniya", titleFont));
                    document.Add(new Paragraph("INVOICE", headingFont));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph($"Invoice No: {selectedInvoiceNo}", regularFont));
                    document.Add(new Paragraph($"Date: {DateTime.Now:dd/MM/yyyy}", regularFont));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph("Guest Details:", headingFont));
                    document.Add(new Paragraph($"Name: {data["Name"]}", regularFont));
                    document.Add(new Paragraph($"Contact: {data["ContactNumber"]}", regularFont));
                    document.Add(new Paragraph($"Email: {data["Email"]}", regularFont));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph("Reservation Details:", headingFont));
                    document.Add(new Paragraph($"Room No: {data["RoomNo"]}", regularFont));
                    document.Add(new Paragraph($"Room Type: {data["RoomType"]}", regularFont));
                    document.Add(new Paragraph($"Check-in Date: {Convert.ToDateTime(data["CheckInDate"]):dd/MM/yyyy}", regularFont));
                    document.Add(new Paragraph($"Check-out Date: {Convert.ToDateTime(data["CheckOutDate"]):dd/MM/yyyy}", regularFont));
                    document.Add(new Paragraph($"Price Per Night: ${data["PricePerNight"]}", regularFont));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph("Payment Details:", headingFont));
                    document.Add(new Paragraph($"Total Amount: ${totalAmount:F2}", regularFont));

                    document.Close();
                    MessageBox.Show($"PDF bill generated successfully: {fileName}", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(fileName);
                }
                else
                {
                    MessageBox.Show("No reservation details found for the given ID.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF bill: {ex.Message}", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            PayPanel.Visible = true;
            if (dgvBills.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvBills.CurrentRow;

                selectedInvoiceNo = Convert.ToInt32(selectedRow.Cells["InvoiceNo"].Value);
                string reservationIdString = selectedRow.Cells["ReservationID"].Value?.ToString();

                cboReservationId.SelectedItem = reservationIdString;
                txtTotalAmount.Text = selectedRow.Cells["TotalAmount"].Value?.ToString() ?? string.Empty;
                dtpPaymentDate.Value = Convert.ToDateTime(selectedRow.Cells["InvoiceDate"].Value);

                reservationId = Convert.ToInt32(reservationIdString);

                string paymentStatusQuery = "SELECT PaymentStatus FROM reservations WHERE ReservationID = @ReservationID"; 
                MySqlParameter parameter = new MySqlParameter("@ReservationID", reservationId);
                DataTable statusTable = db.GetData(paymentStatusQuery, parameter);
                if (statusTable.Rows.Count > 0)
                {
                    cboPaymentStatus.SelectedItem = statusTable.Rows[0]["PaymentStatus"].ToString();
                }
            }
            else
            {
                MessageBox.Show("No row selected for editing.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvBills.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this invoice?", "Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        selectedInvoiceNo = Convert.ToInt32(dgvBills.CurrentRow.Cells["InvoiceNo"].Value);

                        int reservationID = Convert.ToInt32(dgvBills.CurrentRow.Cells["ReservationID"].Value);

                        db.ExecuteQuery("UPDATE reservations SET PaymentStatus = 'Failed' WHERE ReservationID = @ReservationID", 
                                        new MySqlParameter("@ReservationID", reservationID));

                        db.ExecuteQuery("DELETE FROM billing WHERE `Invoice No` = @InvoiceNo",
                                        new MySqlParameter("@InvoiceNo", selectedInvoiceNo));

                        LoadData();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting invoice: {ex.Message}", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No row selected for deletion.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PayPanel.Visible = true;
            ClearInputs();
            selectedInvoiceNo = -1;
            lblID.Text = "Invoice No: " + GetNextInvoiceNo().ToString();
        }
    }
}