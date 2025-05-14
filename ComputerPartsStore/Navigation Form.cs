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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrdersForm form6 = new OrdersForm();
            form6.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserForm UserForm = new UserForm();
            UserForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login_Signup_Form LoginForm = new Login_Signup_Form();
            LoginForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CustomerOrdersForm CustomerOrdersForm = new CustomerOrdersForm();
            CustomerOrdersForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SupplierProductsForm SupplierProductsForm = new SupplierProductsForm();
            SupplierProductsForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ModifyPricesForm ModifyPricesForm = new ModifyPricesForm();
            ModifyPricesForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModifyPricesForm2 ModifyPricesForm2 = new ModifyPricesForm2();
            ModifyPricesForm2.Show();
            this.Hide();
        }   
    }
}
