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
    public partial class OrdersForm : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
        public OrdersForm()
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
                            // Add columns to DataGridView
                            OrderTable.Columns.Add("order_id", "Order ID");
                            OrderTable.Columns.Add("customer_id", "Customer ID");
                            OrderTable.Columns.Add("order_date", "Order Date");
                            OrderTable.Columns.Add("total_amount", "Total Amount");
                            OrderTable.Columns.Add("status", "Status");

                            // Fill DataGridView with data from database
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

                // Adjust the column widths
                OrderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order data: " + ex.Message);
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Form1 NavigationForm = new Form1();
            NavigationForm.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO orders (customer_id, order_date, total_amount, status) " +
                   "VALUES (@customer_id, @order_date, @total_amount, @status)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", txtcustomerid.Text);
                        cmd.Parameters.AddWithValue("@order_date", dtporderdate.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@total_amount", txttotalamount.Text);
                        cmd.Parameters.AddWithValue("@status", txttotalamount.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("order added successfully.");
                    }
                }

                LoadData_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error adding order: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OrderTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select an order to update.");
                return;
            }

            string orderid = OrderTable.SelectedRows[0].Cells["order_id"].Value.ToString();

            string query = "UPDATE orders SET customer_id = @customer_id, order_date = @order_date, " +
                           "total_amount = @total_amount, status = @status WHERE order_id = @order_id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", txtcustomerid.Text);
                        cmd.Parameters.AddWithValue("@order_date", dtporderdate.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@total_amount", txttotalamount.Text);
                        cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                        cmd.Parameters.AddWithValue("@order_id", orderid);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("order updated successfully.");
                    }
                }

                LoadData_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error updating order: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OrderTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select an order to delete.");
                return;
            }

            string orderid = OrderTable.SelectedRows[0].Cells["order_id"].Value.ToString();

            DialogResult result = MessageBox.Show("are you sure you want to delete this order?", "confirm delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM orders WHERE order_id = @order_id";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@order_id", orderid);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("order deleted successfully.");
                        }
                    }

                    LoadData_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error deleting order: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.");
                return;
            }

            // Clear any existing data in the DataGridView
            OrderTable.Rows.Clear();
            OrderTable.Columns.Clear();

            string query = "SELECT order_id, customer_id, order_date, total_amount, status FROM orders " +
                           "WHERE order_id LIKE @keyword OR customer_id LIKE @keyword OR status LIKE @keyword";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Add columns to DataGridView
                            OrderTable.Columns.Add("order_id", "Order ID");
                            OrderTable.Columns.Add("customer_id", "Customer ID");
                            OrderTable.Columns.Add("order_date", "Order Date");
                            OrderTable.Columns.Add("total_amount", "Total Amount");
                            OrderTable.Columns.Add("status", "Status");

                            // Populate DataGridView with the filtered data
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

                // Adjust the column widths
                OrderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for orders: " + ex.Message);
            }
        }
    }
}
