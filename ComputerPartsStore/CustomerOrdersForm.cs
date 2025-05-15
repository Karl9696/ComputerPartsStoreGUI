using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace ComputerPartsStore
{
    public partial class CustomerOrdersForm : Form
    {
        public CustomerOrdersForm()
        {
            InitializeComponent();
        }
        DataTable dtOrders = new DataTable();
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";

        private void CustomerOrdersForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new object[] { "All", "Pending", "Completed", "Cancelled", "Shipped", "Returned" });
            cmbStatus.SelectedIndex = 0;

            dtpOrderDateFrom.Value = DateTime.Today.AddMonths(-1);
            dtpOrderDateTo.Value = DateTime.Today;

            LoadCustomerNames();
        }

        private void LoadCustomerNames()
        {
            cmbCustomerName.Items.Clear();
            cmbCustomerName.Items.Add("All"); 

            string query = "SELECT DISTINCT CONCAT(first_name, ' ', last_name) AS full_name FROM customer_orders ORDER BY full_name";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbCustomerName.Items.Add(reader["full_name"].ToString());
                            }
                        }
                    }
                }

                cmbCustomerName.SelectedIndex = 0; // Default to "All"
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer names: " + ex.Message);
            }
        }
        private void LoadCustomerOrders()
        {
            dtOrders.Clear();

            string query = "SELECT customer_id, first_name, last_name, order_id, order_date, product_name, total_amount, status FROM customer_orders";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dtOrders);
                    }
                }

                // Show all data initially
                CustomerOrdersTable.DataSource = dtOrders;
                CustomerOrdersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer orders: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadCustomerOrders();  
            ApplyFilter();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Form1 NavigationForm = new Form1();
            NavigationForm.Show();
            this.Hide();
        }
        private void ApplyFilter()
        {
            if (dtOrders.Rows.Count == 0) return;

            string filter = "";

            // Filter by customer name (skip "All")
            if (cmbCustomerName.SelectedIndex > 0)
            {
                string[] parts = cmbCustomerName.Text.Split(' ');
                if (parts.Length >= 2)
                {
                    string firstName = parts[0].Replace("'", "''");
                    string lastName = parts[1].Replace("'", "''");

                    filter += $"first_name = '{firstName}' AND last_name = '{lastName}'";
                }
            }

            // Filter by status
            if (cmbStatus.SelectedIndex > 0)
            {
                if (filter.Length > 0) filter += " AND ";
                string selectedStatus = cmbStatus.Text.Replace("'", "''");
                filter += $"status = '{selectedStatus}'";
            }

            // Filter by order date range
            DateTime from = dtpOrderDateFrom.Value.Date;
            DateTime to = dtpOrderDateTo.Value.Date;

            if (filter.Length > 0) filter += " AND ";
            filter += $"order_date >= #{from:yyyy-MM-dd}# AND order_date <= #{to:yyyy-MM-dd}#";

            // Apply filter to the DataView
            DataView dv = dtOrders.DefaultView;
            dv.RowFilter = filter;

            CustomerOrdersTable.DataSource = dv.ToTable();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (CustomerOrdersTable.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "CustomerOrdersReport.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var dtToExport = ((DataTable)CustomerOrdersTable.DataSource);

                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(dtToExport, "Customer Orders");
                            wb.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Report generated successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting report: " + ex.Message);
                    }
                }
            }
        }
    }
}
