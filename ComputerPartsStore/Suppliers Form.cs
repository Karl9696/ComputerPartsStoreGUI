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
            suppliertable.Rows.Clear();
            suppliertable.Columns.Clear();

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
                            suppliertable.Columns.Add("supplier_id", "Supplier ID");
                            suppliertable.Columns.Add("supplier_name", "Supplier Name");
                            suppliertable.Columns.Add("contact_name", "Contact Name");
                            suppliertable.Columns.Add("contact_phone", "Phone");
                            suppliertable.Columns.Add("contact_email", "Email");
                            suppliertable.Columns.Add("address", "Address");

                            while (reader.Read())
                            {
                                suppliertable.Rows.Add(
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

                suppliertable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Supplier data: " + ex.Message);

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Form1 NavigationForm = new Form1();
            NavigationForm.Show();
            this.Hide();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.");
                return;
            }

            suppliertable.Rows.Clear();
            suppliertable.Columns.Clear();

            string query = "SELECT supplier_id, supplier_name, contact_name, contact_phone, contact_email, address " +
                           "FROM suppliers " +
                           "WHERE supplier_name LIKE @keyword OR contact_name LIKE @keyword";

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
                            suppliertable.Columns.Add("supplier_id", "Supplier ID");
                            suppliertable.Columns.Add("supplier_name", "Supplier Name");
                            suppliertable.Columns.Add("contact_name", "Contact Name");
                            suppliertable.Columns.Add("contact_phone", "Phone");
                            suppliertable.Columns.Add("contact_email", "Email");
                            suppliertable.Columns.Add("address", "Address");

                            while (reader.Read())
                            {
                                suppliertable.Rows.Add(
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

                suppliertable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for Suppliers: " + ex.Message);
            }
        }

        private void btnaddsupplier_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO suppliers (supplier_name, contact_name, contact_phone, contact_email, address) " +
                   "VALUES (@name, @contact, @phone, @email, @address)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtsuppliername.Text);
                        cmd.Parameters.AddWithValue("@contact", txtcontactname.Text);
                        cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                        cmd.Parameters.AddWithValue("@email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@address", txtaddress.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Supplier added successfully.");
                    }
                }

                LoadData_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding supplier: " + ex.Message);
            }
        }

        private void btnupdatesupplier_Click(object sender, EventArgs e)
        {
            if (suppliertable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to update.");
                return;
            }

            string supplierid = suppliertable.SelectedRows[0].Cells["supplier_id"].Value.ToString();

            string query = "UPDATE suppliers SET supplier_name = @name, contact_name = @contact, contact_phone = @phone, contact_email = @email, address = @address WHERE supplier_id = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtsuppliername.Text);
                        cmd.Parameters.AddWithValue("@contact", txtcontactname.Text);
                        cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                        cmd.Parameters.AddWithValue("@email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                        cmd.Parameters.AddWithValue("@id", supplierid);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Supplier updated successfully.");
                    }
                }

                LoadData_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier: " + ex.Message);
            }
        }

        private void btndeletesupplier_Click(object sender, EventArgs e)
        {
            if (suppliertable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            string supplierid = suppliertable.SelectedRows[0].Cells["supplier_id"].Value.ToString();

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this supplier?", "confirm delete", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                string query = "DELETE FROM suppliers WHERE supplier_id = @id";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", supplierid);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Supplier deleted successfully.");
                        }
                    }

                    LoadData_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting supplier: " + ex.Message);
                }
            }
        }
    }
}
