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
    public partial class Form3 : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            ProductTable.Rows.Clear();
            ProductTable.Columns.Clear();

            string query = "SELECT product_id, product_name, category_id, price, stock_quantity, supplier_id, description, is_active, original_price FROM products";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            ProductTable.Columns.Add("product_id", "Product ID");
                            ProductTable.Columns.Add("product_name", "Product Name");
                            ProductTable.Columns.Add("category_id", "Category ID");
                            ProductTable.Columns.Add("price", "Price");
                            ProductTable.Columns.Add("stock_quantity", "Stock Quantity");
                            ProductTable.Columns.Add("supplier_id", "Supplier ID");
                            ProductTable.Columns.Add("description", "Description");
                            ProductTable.Columns.Add("is_active", "Is Active");
                            ProductTable.Columns.Add("original_price", "Original Price");

                            while (reader.Read())
                            {
                                ProductTable.Rows.Add(
                                    reader["product_id"].ToString(),
                                    reader["product_name"].ToString(),
                                    reader["category_id"].ToString(),
                                    reader["price"].ToString(),
                                    reader["stock_quantity"].ToString(),
                                    reader["supplier_id"].ToString(),
                                    reader["description"].ToString(),
                                    reader["is_active"].ToString(),
                                    reader["original_price"].ToString()
                                );
                            }
                        }
                    }
                }

                ProductTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "INSERT INTO products (product_name, category_id, price, stock_quantity, supplier_id, description, is_active, original_price) " +
                "VALUES (@name, @category, @price, @stock, @supplier, @desc, @active, @original)";

            try
            {
             
                decimal price = 0;
                decimal originalPrice = 0; 
                int stock = 0;

                bool isPriceValid = decimal.TryParse(txtPrice.Text, out price);
                bool isStockValid = int.TryParse(txtStock.Text, out stock);

                if (!isPriceValid || !isStockValid)
                {
                    MessageBox.Show("Please ensure the price, original price, and stock quantity are valid numbers.");
                    return;
                }

                originalPrice = price;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@category", txtCategoryID.Text);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@supplier", txtSupplierID.Text);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@active", chkIsActive.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@original", originalPrice);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully.");

                   
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
      
            if (ProductTable.SelectedRows.Count > 0)
            {
               
                string productId = ProductTable.SelectedRows[0].Cells["product_id"].Value.ToString();

              
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM products WHERE product_id = @product_id";

                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@product_id", productId);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Product deleted successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Error: Product not found.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting product: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ProductTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

  
            string productId = ProductTable.SelectedRows[0].Cells["product_id"].Value.ToString();

            string query = "UPDATE products SET " +
                           "product_name = @name, " +
                           "category_id = @category, " +
                           "price = @price, " +
                           "stock_quantity = @stock, " +
                           "supplier_id = @supplier, " +
                           "description = @desc, " +
                           "is_active = @active, " +
                           "original_price = @original " +
                           "WHERE product_id = @id";

            try
            {
           
                decimal price = 0;
                int stock = 0;

                bool isPriceValid = decimal.TryParse(txtPrice.Text, out price);
                bool isStockValid = int.TryParse(txtStock.Text, out stock);

                if (!isPriceValid || !isStockValid)
                {
                    MessageBox.Show("Please ensure the price, original price, and stock quantity are valid numbers.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@category", txtCategoryID.Text);
                        cmd.Parameters.AddWithValue("@price", price);
                        decimal originalPrice = price;
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@supplier", txtSupplierID.Text);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@active", chkIsActive.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@original", originalPrice);
                        cmd.Parameters.AddWithValue("@id", productId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductTable.Rows.Clear();
        }
    }
}
