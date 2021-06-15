using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }
    }
}
