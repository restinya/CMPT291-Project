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
            try
            {
                //Insert dummy values for branch, car type, car and employee
                myCommand.CommandText = "insert into Branch values (001, 'Edmonton', 'Edmonton', 'Millwoods', T6L5M5, 7806049803)";
                myCommand.CommandText = "insert into CarType values (001, 'Intermediate SUV', 56.60, 250.50, 800.25, 25.00, 25.00)";
                myCommand.CommandText = "insert into Car values (001, 'BXN2267', 'Available', 95000, 'Automatic', 5, 2020, 'Toyota', 'RAV4', 001, 001";
                myCommand.CommandText = "insert into Employee values (001, 'Edmonton', 'Edmonton', 'Millwoods', T6L5M5, 7806049803)";

                myCommand.CommandText = "insert into Rental values (" + "001,NULL,NULL" + "," + "NULL,NULL,NULL,NULL," + 
                                        customerID.Text + ","  + empID.Text + ",NULL," 
                                         + carID.Text + "," + pickUpBranch.Text + ",NULL" + 
                                        ")";

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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                myCommand.CommandText = "insert into Customer values (" + "004,'" + fName.Text + "','" + lName.Text + "',NULL,'" + city.Text + "','" + state.Text + "','" + street.Text + "','" + postalCode.Text + "',NULL" + ")";

                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void checkBoxCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomer.Checked)
            {
                customerDetails.Visible = true;
                customerForm.Visible = true;
                addButton.Visible = true;
            }
            if (checkBoxCustomer.Checked == false)
            {
                customerDetails.Visible = false;
                customerForm.Visible = false;
                addButton.Visible = false;
            }
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked)
            {
                requestCar.Visible = true;
            }
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked)
            {
                requestCar.Visible = false;
            }
        }
    }
}
