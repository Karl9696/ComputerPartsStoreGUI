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
    public partial class Login_Signup_Form : Form
    {
        public Login_Signup_Form()
        {
            InitializeComponent();
        }

        private void Login_Signup_Form_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            string hashedPassword = HashPassword(password);

            string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";
            string query = "SELECT * FROM users WHERE username = @username AND password_hash = @password";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Login Successful!");
                        Form1 NavigationForm = new Form1();
                        NavigationForm.Show();
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void SignupRedirect_Click(object sender, EventArgs e)
        {
            Form7 signupForm = new Form7();
            signupForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Password_Recovery_Form passRecoveryForm = new Password_Recovery_Form();
            passRecoveryForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

