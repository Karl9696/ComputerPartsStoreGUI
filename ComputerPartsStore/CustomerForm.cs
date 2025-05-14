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
    public partial class Form4 : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            CustomerTable.Rows.Clear();
            CustomerTable.Columns.Clear();

            string query = "SELECT customer_id, first_name, last_name, email, phone, address FROM customers";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            CustomerTable.Columns.Add("customer_id", "Customer ID");
                            CustomerTable.Columns.Add("first_name", "First Name");
                            CustomerTable.Columns.Add("last_name", "Last Name");
                            CustomerTable.Columns.Add("email", "Email");
                            CustomerTable.Columns.Add("phone", "Phone");
                            CustomerTable.Columns.Add("address", "Address");

                            while (reader.Read())
                            {
                                CustomerTable.Rows.Add(
                                    reader["customer_id"].ToString(),
                                    reader["first_name"].ToString(),
                                    reader["last_name"].ToString(),
                                    reader["email"].ToString(),
                                    reader["phone"].ToString(),
                                    reader["address"].ToString()
                                );
                            }
                        }
                    }
                }

                CustomerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerTable.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustomerTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            string customerId = CustomerTable.SelectedRows[0].Cells["customer_id"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM customers WHERE customer_id=@id";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", customerId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Customer deleted successfully.");
                            LoadData_Click(null, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CustomerTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            string customerId = CustomerTable.SelectedRows[0].Cells["customer_id"].Value.ToString();

            string query = "UPDATE customers SET first_name=@first, last_name=@last, email=@email, phone=@phone, address=@address WHERE customer_id=@id";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@id", customerId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer updated successfully.");
                        LoadData_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO customers (first_name, last_name, email, phone, address) " +
                   "VALUES (@first, @last, @email, @phone, @address)";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully.");
                        LoadData_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Form1 NavigationForm = new Form1();
            NavigationForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("please enter a keyword to search.");
                return;
            }

            CustomerTable.Rows.Clear();
            CustomerTable.Columns.Clear();

            string query = "SELECT customer_id, first_name, last_name, email, phone, address " +
                           "FROM customers " +
                           "WHERE first_name LIKE @keyword OR last_name LIKE @keyword OR email LIKE @keyword";

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
                            CustomerTable.Columns.Add("customer_id", "customer id");
                            CustomerTable.Columns.Add("first_name", "first name");
                            CustomerTable.Columns.Add("last_name", "last name");
                            CustomerTable.Columns.Add("email", "email");
                            CustomerTable.Columns.Add("phone", "phone");
                            CustomerTable.Columns.Add("address", "address");

                            while (reader.Read())
                            {
                                CustomerTable.Rows.Add(
                                    reader["customer_id"].ToString(),
                                    reader["first_name"].ToString(),
                                    reader["last_name"].ToString(),
                                    reader["email"].ToString(),
                                    reader["phone"].ToString(),
                                    reader["address"].ToString()
                                );
                            }
                        }
                    }
                }

                CustomerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error searching for customers: " + ex.Message);
            }
        }
    }
}
