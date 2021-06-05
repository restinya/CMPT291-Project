using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRental
{
    public partial class RentalTransactionForm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public RentalTransactionForm()
        {
            InitializeComponent();

            SqlConnection myConnection = new SqlConnection("user id=admin291;" +
                                        "password=cmpt291;" +
                                        "server=localhost;" +
                                        "database=CarRental; " +
                                        "connection timeout=30");


            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pickUpDate, expectedDate, requestedClass, goldMember;

            pickUpDate = PickUpDate2.Text;
            expectedDate = ExpectedDate2.Text;
            requestedClass = RequestedClass2.Text;
            goldMember = Membership2.Text;

            try
            {
                myCommand.CommandText = "insert into Test values (" + "001," + PickUpDate.Text + ", " + ExpectedDate.Text + ", " + RequestedClass.Text + ", "  + Membership.Text + ")";
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
            }

            catch (Exception e2) 
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }
    }
}
