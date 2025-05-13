using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerPartsStore
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string email = txtemail.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (username == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            string hashedPassword = HashPassword(password);
            string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
            string query = "INSERT INTO users (username, email, password_hash) VALUES (@username, @email, @password)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!");
                    this.Hide();

                    Login_Signup_Form loginForm = new Login_Signup_Form();
                    loginForm.Show();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) 
                    MessageBox.Show("Username or email already exists.");
                else
                    MessageBox.Show("Database error: " + ex.Message);
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginRedirect_Click(object sender, EventArgs e)
        {
            Login_Signup_Form loginForm = new Login_Signup_Form();
            loginForm.Show();
            this.Hide();
        }
    }
}
