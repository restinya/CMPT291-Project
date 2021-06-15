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
    public partial class RentalReservations : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public RentalReservations()
        {
            InitializeComponent();

            SqlConnection myConnection = new SqlConnection("user id=admin291;" +
                                        "password=cmpt291;" +
                                        "server=localhost;" +
                                        "database=CarRental; " +
                                        "connection timeout=30");
            //Connect to Database
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

            //Populate the items in the following comboboxes
            try
            {
                //Retrieving customers
                myCommand.CommandText = "select * from Customer";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    customerList.Items.Add(myReader["customerID"].ToString() + " - " + myReader["fName"].ToString() + " " + myReader["lName"].ToString());
                }
                myReader.Close();
                //Retrieving employees
                myCommand.CommandText = "select * from Employee";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    employeeList.Items.Add(myReader["empID"].ToString() + " - " + myReader["fName"].ToString() + " " + myReader["lName"].ToString());
                }
                myReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCars r1 = new EmployeeCars();
            r1.ShowDialog();
        }
    }
}
