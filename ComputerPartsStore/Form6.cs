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
    public partial class Form6 : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            OrderTable.Rows.Clear();
            OrderTable.Columns.Clear();

            string query = "SELECT order_id, customer_id, order_date, total_amount, status FROM orders";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            OrderTable.Columns.Add("order_id", "Order ID");
                            OrderTable.Columns.Add("customer_id", "Customer ID");
                            OrderTable.Columns.Add("order_date", "Order Date");
                            OrderTable.Columns.Add("total_amount", "Total Amount");
                            OrderTable.Columns.Add("status", "Status");

                            while (reader.Read())
                            {
                                OrderTable.Rows.Add(
                                    reader["order_id"].ToString(),
                                    reader["customer_id"].ToString(),
                                    Convert.ToDateTime(reader["order_date"]).ToString("yyyy-MM-dd"),
                                    reader["total_amount"].ToString(),
                                    reader["status"].ToString()
                                );
                            }
                        }
                    }
                }

                OrderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order data: " + ex.Message);
            }
        }
    }
}
