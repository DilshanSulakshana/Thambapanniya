using System;
using System.Data;
using System.Windows.Forms;
using OfficeOpenXml; 
using MySql.Data.MySqlClient;


namespace Guest_House_Management_System.Screens
{
    public partial class Report : Form
    {
        private DBconnect dbConnect;

        public Report()
        {
            InitializeComponent();
            dbConnect = new DBconnect(); 
            InitializeReportTypeComboBox();
        }

        private void InitializeReportTypeComboBox()
        {
            cboReportType.Items.Add("Guest History Report");
            cboReportType.Items.Add("Reservation Report");
            cboReportType.Items.Add("Payment Report");
            cboReportType.SelectedIndexChanged += CboReportType_SelectedIndexChanged;
        }

        private void CboReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportLabel.Text = cboReportType.SelectedItem.ToString();
            ConfigureDataGridViewColumns();
        }

        private void ConfigureDataGridViewColumns()
        {
            dgvReport.Columns.Clear();

            switch (cboReportType.SelectedItem.ToString())
            {
                case "Guest History Report":
                    dgvReport.Columns.Add("GuestName", "Guest Name");
                    dgvReport.Columns.Add("NIC", "NIC");
                    dgvReport.Columns.Add("Country", "Country");
                    dgvReport.Columns.Add("RoomNo", "Room No");
                    dgvReport.Columns.Add("CheckInDate", "Check-In Date");
                    dgvReport.Columns.Add("CheckOutDate", "Check-Out Date");
                    dgvReport.Columns.Add("Status", "Status");
                    break;

                case "Reservation Report":
                    dgvReport.Columns.Add("ReservationID", "Reservation ID");
                    dgvReport.Columns.Add("GuestName", "Guest Name");
                    dgvReport.Columns.Add("RoomType", "Room Type");
                    dgvReport.Columns.Add("CheckInDate", "Check-In Date");
                    dgvReport.Columns.Add("CheckOutDate", "Check-Out Date");
                    dgvReport.Columns.Add("BookingStatus", "Reservation Status");
                    break;

                case "Payment Report":
                    dgvReport.Columns.Add("PaymentID", "Payment ID");
                    dgvReport.Columns.Add("ReservationID", "Reservation ID");
                    dgvReport.Columns.Add("GuestName", "Guest Name");
                    dgvReport.Columns.Add("TotalAmount", "Total Amount");
                    dgvReport.Columns.Add("PaymentStatus", "Payment Status");
                    dgvReport.Columns.Add("PaymentDate", "Payment Date");
                    break;
            }
        }

        private void btnRepGenerater_Click(object sender, EventArgs e)
        {
            dgvReport.Columns.Clear();
            string query = string.Empty;

            switch (cboReportType.SelectedItem.ToString())
            {
                case "Guest History Report":
                    query = "SELECT g.Name AS GuestName, g.NIC, g.Country, r.RoomNo, r.CheckInDate, r.CheckOutDate, r.BookingStatus AS Status " +
                            "FROM reservations r " +
                            "INNER JOIN guests g ON r.GuestID = g.GuestID " +
                            "WHERE r.CheckInDate BETWEEN @StartDate AND @EndDate;";
                    break;

                case "Reservation Report":
                    query = "SELECT r.ReservationID, g.Name AS GuestName, rm.RoomType, r.CheckInDate, r.CheckOutDate, r.BookingStatus " +
                            "FROM reservations r " +
                            "INNER JOIN guests g ON r.GuestID = g.GuestID " +
                            "LEFT JOIN rooms rm ON r.RoomNo = rm.RoomNo " +
                            "WHERE r.CheckInDate BETWEEN @StartDate AND @EndDate;";
                    break;

                case "Payment Report":
                    query = "SELECT p.`Invoice No` AS InvoiceNo, r.ReservationID, g.Name AS GuestName, p.TotalAmount, r.PaymentStatus, p.InvoiceDate AS PaymentDate " +
                            "FROM billing p " +
                            "INNER JOIN reservations r ON p.ReservationID = r.ReservationID " +
                            "INNER JOIN guests g ON r.GuestID = g.GuestID " +
                            "WHERE p.InvoiceDate BETWEEN @StartDate AND @EndDate;";
                    break;
            }

            LoadDataIntoDataGridView(query);
        }

        private void LoadDataIntoDataGridView(string query)
        {
            MySqlParameter[] parameters = {
                new MySqlParameter("@StartDate", dtpStart.Value.ToString("yyyy-MM-dd")),
                new MySqlParameter("@EndDate", dtpEnd.Value.ToString("yyyy-MM-dd")) 
            };

            DataTable dataTable = dbConnect.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                dgvReport.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No data found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvReport.DataSource = null; 
            }
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        var worksheet = excelPackage.Workbook.Worksheets.Add("Report");

                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dgvReport.Columns[i].HeaderText;
                        }

                        for (int i = 0; i < dgvReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvReport.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dgvReport.Rows[i].Cells[j].Value;
                            }
                        }

                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, excelPackage.GetAsByteArray());
                        MessageBox.Show("Report exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}