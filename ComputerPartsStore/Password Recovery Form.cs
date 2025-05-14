using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerPartsStore
{
    public partial class Password_Recovery_Form : Form
    {
        public Password_Recovery_Form()
        {
            InitializeComponent();
        }
        private string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";

        private void Password_Recovery_Form_Load(object sender, EventArgs e)
        {

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();
            string resetCode = new Random().Next(100000, 999999).ToString();
            DateTime expiry = DateTime.Now.AddMinutes(15);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                "UPDATE users SET reset_code = @code, reset_code_expiry = @expiry WHERE email = @email", conn))
            {
                cmd.Parameters.AddWithValue("@code", resetCode);
                cmd.Parameters.AddWithValue("@expiry", expiry);
                cmd.Parameters.AddWithValue("@email", email);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Reset code generated: {resetCode}\nIt will expire in 15 minutes.");
                }
                else
                {
                    MessageBox.Show("Email not found.");
                }
            }
        }

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();
            string code = txtresetcode.Text.Trim();
            string newPassword = txtnewpassword.Text.Trim();
            string hashedPassword = HashPassword(newPassword);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Check if code is valid and not expired
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT reset_code_expiry FROM users WHERE email = @email AND reset_code = @code", conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@code", code);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime expiry = Convert.ToDateTime(reader["reset_code_expiry"]);
                            if (DateTime.Now <= expiry)
                            {
                                reader.Close();

                                // Update password and clear reset code
                                using (MySqlCommand updateCmd = new MySqlCommand(
                                    "UPDATE users SET password_hash = @password, reset_code = NULL, reset_code_expiry = NULL WHERE email = @email", conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@password", hashedPassword);
                                    updateCmd.Parameters.AddWithValue("@email", email);
                                    updateCmd.ExecuteNonQuery();

                                    MessageBox.Show("Password reset successful.");
                                    this.Hide();

                                    Login_Signup_Form LoginForm = new Login_Signup_Form();
                                    LoginForm.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Reset code has expired.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid reset code or username.");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Signup_Form LoginForm = new Login_Signup_Form();
            LoginForm.Show();
            this.Hide();
        }
    }
}
