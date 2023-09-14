using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        DataTable employees;
        public Form1()
        {
            InitializeComponent();
            InitializeValues();
            InitializeEvents();
        }

        private void InitializeValues()
        {
            employees = new DataTable();
            employees.Columns.Add("Name");

            dgv_Employees.DataSource = employees;
        }

        private void InitializeEvents()
        {
            // Create Event
            btn_Add.Click += Btn_Add_Click;
        }

        private void Btn_Add_Click(object? sender, EventArgs e)
        {
            employees.Rows.Add(tb_Name.Text);
            dgv_Employees.Refresh();
            tb_Name.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
