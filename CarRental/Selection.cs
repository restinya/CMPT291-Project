using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (returnCheckbox.Checked) {
                returnLocLabel.Visible = true;
                returnLocation.Visible = true;
            }
            if (returnCheckbox.Checked == false)
            {
                returnLocLabel.Visible = false;
                returnLocation.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cars c1 = new Cars();
            c1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w1 = new Welcome();
            w1.ShowDialog();
        }
    }
}
