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
    public partial class AddProductFormcs : Form
    {
        string connectionString = "server=localhost;user=root;password=admin;database=computerparts_db;";
        MySqlConnection conn;
        public AddProductFormcs()
        {
            InitializeComponent();
            conn = new MySqlConnection(connectionString);
        }

        private void AddProductFormcs_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadSuppliers();
        }

        private void LoadCategories()
        {
            try
            {
                conn.Open();
                string query = "SELECT category_id, category_name FROM product_categories";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "category_name";
                cmbCategory.ValueMember = "category_id";
                cmbCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                conn.Open();
                string query = "SELECT supplier_id, supplier_name FROM suppliers";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSupplier.DataSource = dt;
                cmbSupplier.DisplayMember = "supplier_name";
                cmbSupplier.ValueMember = "supplier_id";
                cmbSupplier.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                cmbCategory.SelectedIndex == -1 ||
                cmbSupplier.SelectedIndex == -1 ||
                !decimal.TryParse(txtPrice.Text, out decimal price) ||
                !int.TryParse(txtStockQuantity.Text, out int stockQuantity))
            {
                MessageBox.Show("Please fill all fields with valid values.");
                return;
            }

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("add_product", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_product_name", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@p_category_id", Convert.ToInt32(cmbCategory.SelectedValue));
                cmd.Parameters.AddWithValue("@p_price", price);
                cmd.Parameters.AddWithValue("@p_stock_quantity", stockQuantity);
                cmd.Parameters.AddWithValue("@p_supplier_id", Convert.ToInt32(cmbSupplier.SelectedValue));
                cmd.Parameters.AddWithValue("@p_description", txtDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@p_is_active", chkIsActive.Checked);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product added successfully!");
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void ClearInputs()
        {
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtPrice.Clear();
            txtStockQuantity.Clear();
            cmbSupplier.SelectedIndex = -1;
            txtDescription.Clear();
            chkIsActive.Checked = false;
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Form1 NavigationForm = new Form1();
            NavigationForm.Show();
            this.Hide();
        }
    }
}
