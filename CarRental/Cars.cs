using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Cars : Form
    {
#pragma warning disable CS0414 // The field 'Cars.carDetails' is assigned but its value is never used
        String carDetails = "{0, -10}{1, -20}{2, -20}{3, -20}{4, -20}{5, -16}";
#pragma warning restore CS0414 // The field 'Cars.carDetails' is assigned but its value is never used

        public Cars()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeLOC_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            carTypeSel s1 = new carTypeSel();
            s1.ShowDialog();
        }
    }
}
