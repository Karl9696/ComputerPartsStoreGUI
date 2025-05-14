using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerPartsStore
{
    public partial class CustomerOrdersForm : Form
    {
        public CustomerOrdersForm()
        {
            InitializeComponent();
        }
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";

        private void CustomerOrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerOrdersTable.Rows.Clear();
            CustomerOrdersTable.Columns.Clear();

            // Modify the query to select from the customer_orders view
            string query = "SELECT customer_id, first_name, last_name, order_id, order_date, product_name, total_amount, status FROM customer_orders";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Define the columns based on the view's data
                            CustomerOrdersTable.Columns.Add("customer_id", "Customer ID");
                            CustomerOrdersTable.Columns.Add("first_name", "First Name");
                            CustomerOrdersTable.Columns.Add("last_name", "Last Name");
                            CustomerOrdersTable.Columns.Add("order_id", "Order ID");
                            CustomerOrdersTable.Columns.Add("order_date", "Order Date");
                            CustomerOrdersTable.Columns.Add("product_name", "Product Name");
                            CustomerOrdersTable.Columns.Add("total_amount", "Total Amount");
                            CustomerOrdersTable.Columns.Add("status", "Status");

                            // Populate the DataGridView with data from the view
                            while (reader.Read())
                            {
                                CustomerOrdersTable.Rows.Add(
                                    reader["customer_id"].ToString(),
                                    reader["first_name"].ToString(),
                                    reader["last_name"].ToString(),
                                    reader["order_id"].ToString(),
                                    Convert.ToDateTime(reader["order_date"]).ToString("yyyy-MM-dd"),
                                    reader["product_name"].ToString(),
                                    reader["total_amount"].ToString(),
                                    reader["status"].ToString()
                                );
                            }
                        }
                    }
                }

                CustomerOrdersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer orders: " + ex.Message);
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Form1 NavigationForm = new Form1();
            NavigationForm.Show();
            this.Hide();
        }
    }
}
