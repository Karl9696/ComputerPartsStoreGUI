using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPartsStore
{
    public partial class Form2 : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=admin;database=computerparts_db;";

        public Form2()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void LoadData_Click(object sender, EventArgs e)
        {


            dataGridView1.Columns.Clear();  
            dataGridView1.Columns.Add("category_id", "Category ID");
            dataGridView1.Columns.Add("category_name", "Category Name");
            dataGridView1.Columns.Add("description", "Description");

            dataGridView1.Rows.Add("1", "CPU", "The brain of the computer; handles instructions and processing.");
            dataGridView1.Rows.Add("2", "GPU", "Graphics card; handles rendering of images, video, and animations.");
            dataGridView1.Rows.Add("3", "Motherboard", "Main circuit board; connects all internal components.");
            dataGridView1.Rows.Add("4", "Memory (RAM)", "Temporary storage for active data used by the CPU.");
            dataGridView1.Rows.Add("5", "Storage", "Devices like HDD and SSD for storing data permanently.");
            dataGridView1.Rows.Add("6", "PSU", "Power Supply Unit; converts electrical power to required voltages.");
            dataGridView1.Rows.Add("7", "Cooling Systems", "Components like fans and coolers to maintain safe temperatures.");
            dataGridView1.Rows.Add("8", "Optical Drives", "Drives that read/write optical discs (CDs, DVDs, Blu-ray).");
            dataGridView1.Rows.Add("9", "Sound Card", "A device that processes audio for better sound quality.");
            dataGridView1.Rows.Add("10", "NIC", "Network Interface Card; enables network connectivity.");
            dataGridView1.Rows.Add("11", "Input Devices", "Devices like keyboard and mouse for user interaction.");
            dataGridView1.Rows.Add("12", "Output Devices", "Devices like monitors and speakers for output.");
            dataGridView1.Rows.Add("13", "Cases and Enclosures",     "The physical case that houses the computer components.");
            dataGridView1.Rows.Add("14", "Peripheral Devices", "Additional devices like printers, webcams, and external drives.");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
