using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPartsStore
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            CustomerTable.Columns.Clear();

            CustomerTable.Columns.Add("customer_id", "Customer ID");
            CustomerTable.Columns.Add("first_name", "First Name");
            CustomerTable.Columns.Add("last_name", "Last Name");
            CustomerTable.Columns.Add("email", "Email");
            CustomerTable.Columns.Add("phone", "Phone");
            CustomerTable.Columns.Add("address", "Address");

    
            CustomerTable.Rows.Add(1, "Jollibee", "Smith", "johnsmith21@gmail.com", "09171432765", "456 New Street, NY");
            CustomerTable.Rows.Add(2, "Jane", "Smith", "jane.smith@gmail.com", "09181234567", "4567 Elm St, Manila, Philippines");
            CustomerTable.Rows.Add(3, "Alice", "Johnson", "alice.johnson@gmail.com", "09191234567", "7890 Oak St, Makati, Philippines");
            CustomerTable.Rows.Add(4, "Bob", "Brown", "bob.brown@gmail.com", "09201234567", "1357 Pine St, Cebu City, Philippines");
            CustomerTable.Rows.Add(5, "Charlie", "Davis", "charlie.davis@gmail.com", "09211234567", "2468 Maple St, Davao City, Philippines");
            CustomerTable.Rows.Add(6, "David", "Miller", "david.miller@gmail.com", "09221234567", "3690 Birch St, Baguio City, Philippines");
            CustomerTable.Rows.Add(7, "Eve", "Wilson", "eve.wilson@gmail.com", "09231234567", "4821 Cedar St, Taguig, Philippines");
            CustomerTable.Rows.Add(8, "Frank", "Taylor", "frank.taylor@gmail.com", "09241234567", "5790 Pine St, Quezon City, Philippines");
            CustomerTable.Rows.Add(9, "Grace", "Martinez", "grace.martinez@gmail.com", "09251234567", "6823 Oak St, Cebu City, Philippines");
            CustomerTable.Rows.Add(10, "Hannah", "Garcia", "hannah.garcia@gmail.com", "09261234567", "7945 Birch St, Manila, Philippines");

            
            CustomerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerTable.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
