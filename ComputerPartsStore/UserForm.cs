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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
            string query = "SELECT id, username, email FROM users";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                UserView.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UserView.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(UserView.SelectedRows[0].Cells["id"].Value);
                string newUsername = txtusername.Text.Trim();
                string newEmail = txtemail.Text.Trim();

                string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
                string query = "UPDATE users SET username = @username, email = @email WHERE id = @id";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", newUsername);
                    cmd.Parameters.AddWithValue("@email", newEmail);
                    cmd.Parameters.AddWithValue("@id", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User updated successfully.");
                button1_Click(null, null); 
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (UserView.SelectedRows.Count > 0)
            {
                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int userId = Convert.ToInt32(UserView.SelectedRows[0].Cells["id"].Value);
                    string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
                    string query = "DELETE FROM users WHERE id = @id";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User deleted successfully.");
                    button1_Click(null, null); 
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }
    }
}
