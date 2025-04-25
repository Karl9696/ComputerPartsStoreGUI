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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
