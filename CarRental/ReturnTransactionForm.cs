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
    public partial class ReturnTransactionForm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        

        public ReturnTransactionForm()
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
                //Retrieving customerIDs
                myCommand.CommandText = "select * from Customer";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    customerIDBox.Items.Add(myReader["customerID"].ToString() + " - " + myReader["fname"].ToString() + " " + myReader["lname"].ToString());
                }
                myReader.Close();
                //Retrieving branchIDs
                myCommand.CommandText = "select * from Branch";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    returnBranch.Items.Add(myReader["branchID"].ToString() + " - " + myReader["branchName"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        /* Helper function that will extract the ID number from the combo box text */
        public string extractID(ComboBox box)
        {
            string[] words = box.Text.Split(' ');
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

        /* Helper function that will check if customer is a gold Member */
        public bool checkMembership(ComboBox box)
        {
            bool goldMembership = false;
            string custID = extractID(box);
            myCommand.CommandText = "select goldMember from Customer where customerID = " + custID;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader["goldMember"] != DBNull.Value)
                {
                    goldMembership = true;
                }
            }
            myReader.Close();

            return goldMembership;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        /* Load Button */
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (customerIDBox.Text == "")
            {
                MessageBox.Show("Select Customer first.");
                return;
            }
            string custID = extractID(customerIDBox);
            myCommand.CommandText = "select * from Car,CarType,Rental,Customer where Car.carTypeID = CarType.carTypeID and Car.carID = Rental.carID and Customer.customerID = Rental.customerID and Rental.customerID = " + custID +
                                    " and Rental.returnDate is NULL";
            myReader = myCommand.ExecuteReader();
            listOfRentals.Rows.Clear();
            listOfRentals.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
            listOfRentals.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
            while (myReader.Read())
            {
                listOfRentals.Rows.Add(myReader["rentalID"].ToString(), Convert.ToDateTime(myReader["pickUpDate"]).ToShortDateString(), Convert.ToDateTime(myReader["expectedDate"]).ToShortDateString(), myReader["pickUpBranchID"].ToString(),
                                    myReader["carID"].ToString(), myReader["make"].ToString(), myReader["model"].ToString(), myReader["year"].ToString(), myReader["dailyPricing"].ToString(), myReader["weeklyPricing"].ToString(),
                                    myReader["monthlyPricing"].ToString(), myReader["lateFee"].ToString(), myReader["changeBranch"].ToString(), myReader["employeeID"].ToString(), myReader["expectedCarTypeID"].ToString());
            }
            myReader.Close();
        }

        /* Back Button */
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }

        private void listOfRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        /* Calculate Button */
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (returnBranch.Text == "" || mileageUsed.Text == "" || (listOfRentals.SelectedRows.Count < 1))
            {
                MessageBox.Show("Some fields are not filled.");
                return;
            }
            if (returnDate.Value < Convert.ToDateTime(listOfRentals.SelectedRows[0].Cells[1]))
            {
                MessageBox.Show("Return Date is not valid.");
                return;
            }
            bool goldMembership = checkMembership(customerIDBox);

            //Initialize variables
            DateTime pickUpDate = Convert.ToDateTime(listOfRentals.SelectedRows[0].Cells[1].Value.ToString());
            DateTime expectedDate = Convert.ToDateTime(listOfRentals.SelectedRows[0].Cells[2].Value.ToString());
            string pickUpBranch = listOfRentals.SelectedRows[0].Cells[3].Value.ToString();
            float dailyPricing = Convert.ToSingle(listOfRentals.SelectedRows[0].Cells[8].Value);
            float weeklyPricing = Convert.ToSingle(listOfRentals.SelectedRows[0].Cells[9].Value);
            float monthlyPricing = Convert.ToSingle(listOfRentals.SelectedRows[0].Cells[10].Value);
            float lateFee = Convert.ToSingle(listOfRentals.SelectedRows[0].Cells[11].Value);
            float changeBranch = Convert.ToSingle(listOfRentals.SelectedRows[0].Cells[12].Value);
            string requestedClass = listOfRentals.SelectedRows[0].Cells[14].Value.ToString();
            string returnBranchID = extractID(returnBranch);

            //If gold member had a requested car during rental transaction, then override current car price with the requested one
            if (goldMembership == true && requestedClass != "")
            {
                myCommand.CommandText = "select * from CarType where carTypeID = " + requestedClass;
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    dailyPricing = Convert.ToSingle(myReader["dailyPricing"]);
                    weeklyPricing = Convert.ToSingle(myReader["weeklyPricing"]);
                    monthlyPricing = Convert.ToSingle(myReader["monthlyPricing"]);
                }
                myReader.Close();
            }

            //Calculate total fee
            float estimatedCost = 0;
            int days = (returnDate.Value - pickUpDate).Days;
            if (days < 7)
            {
                estimatedCost = days * dailyPricing;
            }
            if (days >= 7 & days < 30)
            {
                int weeks = days / 7;
                int leftDays = days - (weeks * 7);
                estimatedCost = (weeks * weeklyPricing) + (leftDays * dailyPricing);
            }
            if (days >= 30)
            {
                int months = days / 30;
                int leftDays = days - (months * 30);
                int weeks = 0;
                if (leftDays > 7)
                {
                    weeks = leftDays / 7;
                    leftDays = leftDays - (weeks * 7);
                }
                estimatedCost = (months * monthlyPricing) + (weeks * weeklyPricing) + (leftDays * dailyPricing);
            }
            baseCost.Text = estimatedCost.ToString();
            //Check for late cost
            if (returnDate.Value > expectedDate)
            {
                int lateDays = (returnDate.Value - expectedDate).Days;
                float lateTotalCost = (lateDays * lateFee);
                estimatedCost += lateTotalCost;
                lateCost.Text = lateTotalCost.ToString();
            }
            else
            {
                lateCost.Text = "0.00";
            }
            //Check for different return branch cost
            if (goldMembership != true && pickUpBranch != returnBranchID)
            {
                estimatedCost += changeBranch;
                changeBranchCost.Text = changeBranch.ToString();
            }
            else
            {
                changeBranchCost.Text = "0.00";
            }
            //Display Final Result
            result.Text = estimatedCost.ToString();
        }

        /* Submit Button */
        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Text == "")
            {
                MessageBox.Show("Calculate Total Fee first before submitting.");
                return;
            }
            if (returnBranch.Text == "" || mileageUsed.Text == "" || (listOfRentals.SelectedRows.Count < 1))
            {
                MessageBox.Show("Some fields are not filled.");
                return;
            }
            if (returnDate.Value < Convert.ToDateTime(listOfRentals.SelectedRows[0].Cells[1]))
            {
                MessageBox.Show("Return Date is not valid.");
                return;
            }
            //Initialize variables
            string rentalID = listOfRentals.SelectedRows[0].Cells[0].Value.ToString();
            string carID = listOfRentals.SelectedRows[0].Cells[4].Value.ToString();
            string branchID = extractID(returnBranch);
            string custID = extractID(customerIDBox);
            string goldID = "";
            int currentMileage = 0;
            try
            {
                //Update Rental Transaction
                myCommand.CommandText = "UPDATE Rental SET returnDate = '" + returnDate.Text + "', mileageUsed = " + mileageUsed.Text + ",totalFee = " + result.Text + ", returnBranchID = " +
                                        branchID + " where rentalID = " + rentalID;
                myCommand.ExecuteNonQuery();

                //Update Car Record for current mileage and branch location
                myCommand.CommandText = "select currentMileage from Car where carID = " + carID;
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    currentMileage = Convert.ToInt32(myReader["currentMileage"]);
                }
                myReader.Close();
                currentMileage += Convert.ToInt32(mileageUsed.Text);
                myCommand.CommandText = "UPDATE Car SET currentMileage = " + currentMileage.ToString() + ", branchID = " + branchID + " where carID = " + carID;
                MessageBox.Show("RentalID = " + rentalID + " record has been successfully updated.");
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error: Missing Some Fields.");
            }

            //Update Customer to Gold Member Status if Applicable
            try
            {
                //Find the non-gold member customer with number of closed rental transactions to be 3 in the same year
                myCommand.CommandText = "select Customer.customerID, year(returnDate) as rentalYear from Customer,Rental " +
                                        "where Customer.customerID = Rental.customerID and Customer.customerID = " + custID + " and returnDate is not NULL and Customer.goldMember is NULL " +
                                        "group by Customer.customerID, year(returnDate) having count(*) = 3";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    goldID = myReader["customerID"].ToString();
                }
                myReader.Close();
                //If there is an applicable customer, then update customer to gold member status
                if (goldID != "")
                {
                    myCommand.CommandText = "UPDATE Customer SET goldMember = '1' where customerID = " + goldID;
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Customer with Customer ID = " + goldID + " has rented 3 times in the same year and has been successfully upgraded to Gold Member Status");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error: Missing Some Fields.");
            }
            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }

        /* Function that will pop a message indicating if customer is eligible to have their return branch fee waived */
        private void returnBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool eligible = checkMembership(customerIDBox);

            string branchID = extractID(returnBranch);
            if (eligible == true && listOfRentals.SelectedRows[0].Cells[4].Value.ToString() != branchID)
            {
                MessageBox.Show("Different Return Branch Fee is waived for Gold Member Customer.");
            }
        }
    }
}
