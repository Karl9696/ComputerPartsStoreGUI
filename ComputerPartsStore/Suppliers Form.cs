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
    public partial class Form5 : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            SupplierTable.Rows.Clear();
            SupplierTable.Columns.Clear();

            string query = "SELECT supplier_id, supplier_name, contact_name, contact_phone, contact_email, address FROM suppliers";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            SupplierTable.Columns.Add("supplier_id", "Supplier ID");
                            SupplierTable.Columns.Add("supplier_name", "Supplier Name");
                            SupplierTable.Columns.Add("contact_name", "Contact Name");
                            SupplierTable.Columns.Add("contact_phone", "Phone");
                            SupplierTable.Columns.Add("contact_email", "Email");
                            SupplierTable.Columns.Add("address", "Address");

                            while (reader.Read())
                            {
                                SupplierTable.Rows.Add(
                                    reader["supplier_id"].ToString(),
                                    reader["supplier_name"].ToString(),
                                    reader["contact_name"].ToString(),
                                    reader["contact_phone"].ToString(),
                                    reader["contact_email"].ToString(),
                                    reader["address"].ToString()
                                );
                            }
                        }
                    }
                }

                SupplierTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier data: " + ex.Message);

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
