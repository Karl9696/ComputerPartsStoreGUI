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
    public partial class ModifyPricesForm2 : Form
    {
        public ModifyPricesForm2()
        {
            InitializeComponent();
        }
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
        private void ModifyPricesForm2_Load(object sender, EventArgs e)
        {
            LoadSupplierData();
        }
        private void LoadSupplierData()
        {
            string query = "SELECT supplier_id, supplier_name FROM suppliers"; // Query to get supplier data

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            SupplierComboBox.Items.Clear(); // Clear ComboBox before adding new items

                            while (reader.Read())
                            {
                                string supplierName = reader["supplier_name"].ToString(); // Get supplier name
                                SupplierComboBox.Items.Add(supplierName); // Add supplier to ComboBox
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier data: " + ex.Message);
            }
        }

        private void ApplyIncreaseButton_Click(object sender, EventArgs e)
        {
            string selectedSupplierName = SupplierComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedSupplierName))
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            decimal discountPercentage;
            if (!decimal.TryParse(DiscountPercentageTextBox.Text, out discountPercentage))
            {
                MessageBox.Show("Please enter a valid discount percentage.");
                return;
            }

            int supplierId = GetSupplierIdByName(selectedSupplierName);
            ApplyProductDiscount(supplierId, discountPercentage);
        }
        private int GetSupplierIdByName(string supplierName)
        {
            string query = "SELECT supplier_id FROM suppliers WHERE supplier_name = @supplierName";
            int supplierId = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@supplierName", supplierName);
                        supplierId = Convert.ToInt32(cmd.ExecuteScalar()); // Get the supplier ID
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving supplier ID: " + ex.Message);
            }

            return supplierId;
        }
        private void ApplyProductDiscount(int supplierId, decimal discountPercentage)
        {
            string query = "CALL discount_supplier_products(@supplierId, @productId, @percentage)"; // Call the discount procedure

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@supplierId", supplierId);
                        cmd.Parameters.AddWithValue("@productId", Convert.ToInt32(ProductIdTextBox.Text)); 
                        cmd.Parameters.AddWithValue("@percentage", discountPercentage);

                        cmd.ExecuteNonQuery(); // Execute the stored procedure
                    }
                }

                MessageBox.Show("Discount applied successfully.");
                LoadUpdatedPrices(supplierId); // Reload the updated prices for the selected supplier
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying discount: " + ex.Message);
            }
        }
        private void LoadUpdatedPrices(int supplierId)
        {
            string query = "SELECT product_name, price FROM products WHERE supplier_id = @supplierId"; // Query to get updated prices for the supplier

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@supplierId", supplierId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt; // Bind DataTable to DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading updated prices: " + ex.Message);
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
