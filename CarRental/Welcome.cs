using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = userSelectBox.SelectedIndex;

            // if Employee is selected
            // when Employee specific screen is ready, change Selection below to the name of the corresponding form
            if (selectedIndex == 1)
            {
                this.Hide();
                Selection s1 = new Selection();
                s1.ShowDialog();
            };
            
            // if Customer is Selected
            if (selectedIndex == 0)
            {
                this.Hide();
                Selection s1 = new Selection();
                s1.ShowDialog();
            };



        }
    }
}
