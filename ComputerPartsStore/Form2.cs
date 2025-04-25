using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerPartsStore
{
    public partial class Form2 : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";

        public Form2()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void LoadData_Click(object sender, EventArgs e)
        {


            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            string query = "SELECT category_id, category_name, description FROM product_categories";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataGridView1.Columns.Add("category_id", "Category ID");
                            dataGridView1.Columns.Add("category_name", "Category Name");
                            dataGridView1.Columns.Add("description", "Description");

                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(
                                    reader["category_id"].ToString(),
                                    reader["category_name"].ToString(),
                                    reader["description"].ToString()
                                );
                            }
                        }
                    }
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
