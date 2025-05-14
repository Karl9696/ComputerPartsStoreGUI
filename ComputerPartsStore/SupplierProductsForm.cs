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
    public partial class SupplierProductsForm : Form
    {
        public SupplierProductsForm()
        {
            InitializeComponent();
        }
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierProductTable.Rows.Clear();
            SupplierProductTable.Columns.Clear();

            // Modify the query to select from the supplier_product_list view
            string query = "SELECT supplier_id, supplier_name, product_id, product_name, price FROM supplier_product_list";

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
                            SupplierProductTable.Columns.Add("supplier_id", "Supplier ID");
                            SupplierProductTable.Columns.Add("supplier_name", "Supplier Name");
                            SupplierProductTable.Columns.Add("product_id", "Product ID");
                            SupplierProductTable.Columns.Add("product_name", "Product Name");
                            SupplierProductTable.Columns.Add("price", "Price");

                            // Populate the DataGridView with data from the view
                            while (reader.Read())
                            {
                                SupplierProductTable.Rows.Add(
                                    reader["supplier_id"].ToString(),
                                    reader["supplier_name"].ToString(),
                                    reader["product_id"].ToString(),
                                    reader["product_name"].ToString(),
                                    reader["price"].ToString()
                                );
                            }
                        }
                    }
                }

                SupplierProductTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier product data: " + ex.Message);
            }
        }
        private void SupplierProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Form1 NavigationForm = new Form1();
            NavigationForm.Show();
            this.Hide();
        }
    }
}

