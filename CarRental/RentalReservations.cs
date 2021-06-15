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
                DisplayData();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        public void DisplayData()
        {
            listOfRentals.Rows.Clear();
            myCommand.CommandText = "select * from Rental,Customer,Car,CarType where Rental.carID = Car.carID and Rental.customerID = Customer.customerID and Car.carTypeID = CarType.carTypeID";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                listOfRentals.Rows.Add(myReader["rentalID"].ToString(), myReader["customerID"].ToString() + " - " + myReader["fName"].ToString() + " " + myReader["lName"].ToString(),
                                    myReader["pickUpDate"].ToString(), myReader["expectedDate"].ToString(), myReader["returnDate"].ToString(), myReader["carID"].ToString() + " - " + myReader["make"].ToString() + " " + myReader["model"].ToString() + " " + myReader["year"].ToString(),
                                    myReader["carID"].ToString(), myReader["expectedCarTypeID"].ToString(), myReader["pickUpBranchID"].ToString(), myReader["returnBranchID"].ToString(),
                                    myReader["mileageUsed"].ToString(), myReader["estimatedCost"].ToString(), myReader["totalFee"].ToString(), myReader["employeeID"].ToString());
            }
            myReader.Close();
        }

        /* Helper function that will parse a string and extract the id number */
        public string extractID(string box)
        {
            string[] words = box.Split(' ');
            string idNo = "";
            foreach (var word in words)
            {
                int myInt;
                bool isNumerical = int.TryParse(word, out myInt);
                if (isNumerical)
                {
                    idNo = word;
                    break;
                }
            }
            return idNo;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCars r1 = new EmployeeCars();
            r1.ShowDialog();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            listOfRentals.Rows.Clear();
            myCommand.CommandText = "SELECT * FROM Rental, Customer, Car, CarType WHERE Rental.customerID = Customer.customerID " +
                "AND Rental.carID = Car.carID " +
                "AND Car.carTypeID = CarType.carTypeID ";

            if (customerList.Text != "" && employeeList.Text != "")
            {
                string custID = extractID(customerList.Text);
                string empID = extractID(employeeList.Text);
                myCommand.CommandText += "AND Customer.customerID = " + custID +
                " AND employeeID = " + empID;
            }
            else if (customerList.Text != "" && employeeList.Text == "")
            {
                string custID = extractID(customerList.Text);
                myCommand.CommandText += "AND Customer.customerID = " + custID;
            }
            else if (customerList.Text == "" && employeeList.Text != "")
            {
                string empID = extractID(employeeList.Text);
                myCommand.CommandText += "AND employeeID = " + empID;
            }

            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                listOfRentals.Rows.Add(myReader["rentalID"].ToString(), myReader["customerID"].ToString() + " - " + myReader["fName"].ToString() + " " + myReader["lName"].ToString(),
                                    myReader["pickUpDate"].ToString(), myReader["expectedDate"].ToString(), myReader["returnDate"].ToString(), myReader["carID"].ToString() + " - " + myReader["make"].ToString() + " " + myReader["model"].ToString() + " " + myReader["year"].ToString(),
                                    myReader["carID"].ToString(), myReader["expectedCarTypeID"].ToString(), myReader["pickUpBranchID"].ToString(), myReader["returnBranchID"].ToString(),
                                    myReader["mileageUsed"].ToString(), myReader["estimatedCost"].ToString(), myReader["totalFee"].ToString(), myReader["employeeID"].ToString());
            }
            myReader.Close();
 
        }

        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            customerList.ResetText();
            employeeList.ResetText();
            DisplayData();
        }
    }
}
