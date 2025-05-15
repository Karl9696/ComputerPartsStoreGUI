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
    public partial class AddOrders : Form
    {
        public AddOrders()
        {
            InitializeComponent();
            conn = new MySqlConnection(connectionString);
        }
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
        MySqlConnection conn;


        DataTable orderItemsTable = new DataTable();



        private void AddOrders_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadProducts();

            dgvOrders.Columns.Add("ProductID", "Product ID");
            dgvOrders.Columns.Add("ProductName", "Product Name");
            dgvOrders.Columns.Add("Quantity", "Quantity");
        }

        private void LoadCustomers()
        {
            try
            {
                conn.Open();
                var cmd = new MySqlCommand(@"
                    SELECT customer_id, CONCAT(first_name, ' ', last_name) AS customer_name 
                    FROM customers", conn);
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                cmbCustomer.DataSource = dt;
                cmbCustomer.DisplayMember = "customer_name";
                cmbCustomer.ValueMember = "customer_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void LoadProducts()
        {
            try
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT product_id, product_name FROM products", conn);
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                cmbProduct.DataSource = dt;
                cmbProduct.DisplayMember = "product_name";
                cmbProduct.ValueMember = "product_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please select a product and enter quantity.");
                return;
            }

            string productId = cmbProduct.SelectedValue.ToString();
            string productName = cmbProduct.Text;
            string quantity = txtQuantity.Text;

            dgvOrders.Rows.Add(productId, productName, quantity);
            txtQuantity.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1 || dgvOrders.Rows.Count == 0)
            {
                MessageBox.Show("Select a customer and add products before placing an order.");
                return;
            }

            StringBuilder productList = new StringBuilder();

            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.IsNewRow) continue;

                string productId = row.Cells["ProductID"].Value?.ToString();
                string quantity = row.Cells["Quantity"].Value?.ToString();

                if (!string.IsNullOrEmpty(productId) && !string.IsNullOrEmpty(quantity))
                {
                    productList.Append($"{productId},{quantity};");
                }
            }

            try
            {
                conn.Open();
                var cmd = new MySqlCommand("add_order_with_products", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_customer_id", cmbCustomer.SelectedValue);
                cmd.Parameters.AddWithValue("@p_products", productList.ToString().TrimEnd(';'));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Order placed successfully.");
                dgvOrders.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click_1(object sender, EventArgs e)
        {
            Form1 NavigationForm = new Form1();
            NavigationForm.Show();
            this.Hide();
        }
    }
}
