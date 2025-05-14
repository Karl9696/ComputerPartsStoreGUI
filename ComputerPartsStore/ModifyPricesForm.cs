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
    public partial class ModifyPricesForm : Form
    {
        public ModifyPricesForm()
        {
            InitializeComponent();
        }
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
        private void ModifyPricesForm_Load(object sender, EventArgs e)
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

            decimal percentageIncrease;
            if (!decimal.TryParse(PercentageIncreaseTextBox.Text, out percentageIncrease))
            {
                MessageBox.Show("Please enter a valid percentage.");
                return;
            }

            int supplierId = GetSupplierIdByName(selectedSupplierName);
            ApplyPriceIncrease(supplierId, percentageIncrease);
            LoadUpdatedPrices(supplierId);
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
        private void ApplyPriceIncrease(int supplierId, decimal percentageIncrease)
        {
            string query = "CALL increase_supplier_prices(@supplierId, @percentageIncrease)"; // Call the stored procedure

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@supplierId", supplierId);
                        cmd.Parameters.AddWithValue("@percentageIncrease", percentageIncrease);

                        cmd.ExecuteNonQuery(); // Execute the stored procedure
                    }
                }

                MessageBox.Show("Price increase applied successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying price increase: " + ex.Message);
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
                            dataGridView1.DataSource = dt; 
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


