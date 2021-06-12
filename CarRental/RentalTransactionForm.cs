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

        public void DisplayCustomers()
        {
            customerID.Items.Clear();
            myCommand.CommandText = "select customerID, fName, lName from Customer";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                customerID.Items.Add(myReader["customerID"].ToString() + " - " + myReader["fName"].ToString() + " " + myReader["lName"].ToString());
            }
            myReader.Close();
        }

        public void DisplayReturnBranch()
        {
            returnBranch.Items.Clear();
            myCommand.CommandText = "select branchID, branchName from Branch";
            myReader = myCommand.ExecuteReader();
            string pickUpBranchID = extractID(pickUpBranch);
            while (myReader.Read())
            {
                if (myReader["branchID"].ToString() == pickUpBranchID)
                {
                    continue;
                }
                returnBranch.Items.Add(myReader["branchID"].ToString() + " - " + myReader["branchName"].ToString());
            }
            myReader.Close();
        }

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

            try
            {
                //Retrieving customerIDs
                DisplayCustomers();
                //Retrieving branchIDs
                myCommand.CommandText = "select branchID, branchName from Branch";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    pickUpBranch.Items.Add(myReader["branchID"].ToString() + " - " + myReader["branchName"].ToString());
                }
                myReader.Close();
                //Retrieving carTypeIDs
                myCommand.CommandText = "select carTypeID, carClass from CarType";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    requestedClass.Items.Add(myReader["carTypeID"].ToString() + " - " + myReader["carClass"].ToString());
                }
                myReader.Close();
                //Retrieving employeeIDs
                myCommand.CommandText = "select empID, fName, lName from Employee";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    empID.Items.Add(myReader["empID"].ToString() + " - " + myReader["fName"].ToString() + " " + myReader["lName"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
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
            String RequestedClass = ",NULL,";
            try
            {
                if (requestedClass.Text != "")
                {
                    string carClassID = extractID(requestedClass);
                    RequestedClass = "," + carClassID + ",";
                }
                string custID = extractID(customerID);
                string employeeID = extractID(empID);
                string branchID = extractID(pickUpBranch);

                myCommand.CommandText = "insert into Rental values ('" + pickUpDate.Text + "','" + expectedDate.Text +
                                        "'," + "NULL,NULL," + result.Text + ",NULL," +
                                        custID + "," + employeeID + RequestedClass + availableCars.SelectedRows[0].Cells[0].Value.ToString() + "," + branchID + ",NULL" + ")";
                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
            }

            catch (Exception e2) 
            {
                MessageBox.Show(e2.ToString(), "Error: Missing Some Fields.");
            }

            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String custID = "sample";
            try
            {
                
                myCommand.CommandText = "insert into Customer values (" + "'" + fName.Text + "','" + lName.Text + "',NULL,'" + 
                                            city.Text + "','" + state.Text + "','" + street.Text + "','" + postalCode.Text + "','" + 
                                            dateOfBirth.Text + "')";
                myCommand.ExecuteNonQuery();

                //Retrive the newly created customerID
                myCommand.CommandText = "select customerID from Customer where customerID = (select max(customerID) from Customer)";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    custID = myReader["customerID"].ToString();
                    MessageBox.Show("Customer ID " + custID + " is created.");
                    
                }
                myReader.Close();

                //Create records for customer phone number table
                if (homeNum.Text != "")
                {
                    myCommand.CommandText = "insert into PhoneNum values (" + custID + ",'" + homeNum.Text +  "')";
                    myCommand.ExecuteNonQuery();
                }
                if (mobileNum.Text != "")
                {
                    myCommand.CommandText = "insert into PhoneNum values (" + custID + ",'" + mobileNum.Text + "')";
                    myCommand.ExecuteNonQuery();
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error: Missing Some Fields.");
            }

            try
            {
                //Display updated customers in the customerID drop down menu
                DisplayCustomers();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
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
           
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void customerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Initialize variables
            float dayPricing = 0;
            float weekPricing = 0;
            float monthPricing = 0;
            float estimatedCost = 0;

            //Retrieve pricing for cartype selecteD
            try
            {
                myCommand.CommandText = "select dailyPricing, weeklyPricing, monthlyPricing from Car, CarType where Car.cartypeID = CarType.cartypeID and Car.carID = " + availableCars.SelectedRows[0].Cells[0].Value.ToString();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    dayPricing = Convert.ToSingle(myReader["dailyPricing"]);
                    weekPricing = Convert.ToSingle(myReader["weeklyPricing"]);
                    monthPricing = Convert.ToSingle(myReader["monthlyPricing"]);
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error: Missing some fields.");
            }

            //Retrieve pricing for requested carType for goldMember
            if (requestedClass.Text != "")
            {
                try
                {
                    string carClassID = extractID(requestedClass);
                    myCommand.CommandText = "select dailyPricing, weeklyPricing, monthlyPricing from CarType where carTypeID = '" + carClassID + "'";
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        float requestedDayPricing = Convert.ToSingle(myReader["dailyPricing"]);
                        float requestedWeekPricing = Convert.ToSingle(myReader["weeklyPricing"]);
                        float requestedMonthPricing = Convert.ToSingle(myReader["monthlyPricing"]);

                        if (requestedDayPricing < dayPricing)
                        {
                            dayPricing = requestedDayPricing;
                            weekPricing = requestedWeekPricing;
                            monthPricing = requestedMonthPricing;
                        }
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error: Missing some fields.");
                }
            }

            //Calculate estimatedCost
            int days = (expectedDate.Value - pickUpDate.Value).Days;
            if (days < 7)
            {
                estimatedCost = days * dayPricing;
            }
            if (days >= 7 & days < 30)
            {
                int weeks = days / 7;
                int leftDays = days - (weeks * 7);
                estimatedCost = (weeks * weekPricing) + (leftDays * dayPricing);
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
                estimatedCost = (months * monthPricing) + (weeks * weekPricing) + (leftDays * dayPricing);
            }
            if (returnBranch.Text != "")
            {
                float changeBranch = 0;
                try
                {
                    myCommand.CommandText = "select changeBranch from Car, CarType where Car.cartypeID = CarType.cartypeID and Car.carID = " + availableCars.SelectedRows[0].Cells[0].Value.ToString();
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        changeBranch = Convert.ToSingle(myReader["changeBranch"]);
                    }
                    estimatedCost += changeBranch;
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error: Missing some fields.");
                }
            }
            result.Text = estimatedCost.ToString();
        }

        private void expectedDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void carID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Retrieving available carIDs based on branchID selected
            string branchID = extractID(pickUpBranch);
            myCommand.CommandText = "select * from Car, Branch, CarType where Car.branchID = Branch.branchID and Car.cartypeID = CarType.cartypeID and " +
                                    "Branch.branchID = " + branchID + " and Car.carID not in " +
                                    "((select carID from Rental where pickUpDate between '" + pickUpDate.Text + "' and '" + expectedDate.Text + "') UNION " +
                                    "(select carID from Rental where expectedDate between '" + pickUpDate.Text + "' and '" + expectedDate.Text + "'))";
            myReader = myCommand.ExecuteReader();
            availableCars.Rows.Clear();
            while (myReader.Read())
            {
                availableCars.Rows.Add(myReader["carID"].ToString(), myReader["carClass"].ToString(), myReader["make"].ToString(), myReader["model"].ToString(), myReader["year"].ToString(), myReader["dailyPricing"].ToString(),
                                        myReader["weeklyPricing"].ToString(), myReader["monthlyPricing"].ToString(), myReader["lateFee"].ToString(), myReader["changeBranch"].ToString());
            }
            myReader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Retrieving goldMembership
            string idNo = extractID(customerID);
            if (idNo != "")
            {
                myCommand.CommandText = "select goldMember from Customer where customerID = " + idNo;
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (myReader["goldMember"] == DBNull.Value)
                    {
                        membership.Text = "No";
                    }
                    else
                    {
                        membership.Text = "Yes";
                        requestCar.Visible = true;
                    }
                }
                myReader.Close();
            }
        }

        private void changeBranchCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (changeBranchCheck.Checked)
            {
                returnBranchID.Visible = true;
                returnBranch.Visible = true;
                returnBranch.Text = "";
                DisplayReturnBranch();
            }
            if (changeBranchCheck.Checked == false)
            {
                returnBranchID.Visible = false;
                returnBranch.Visible = false;
                returnBranch.Items.Clear();
                returnBranch.Text = "";
            }
        }
    }
}
