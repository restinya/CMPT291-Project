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
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string custID = extractID(customerIDBox);
            myCommand.CommandText = "select * from Car,CarType,Rental,Customer where Car.carTypeID = CarType.carTypeID and Car.carID = Rental.carID and Customer.customerID = Rental.customerID and Rental.customerID = " + custID +
                                    " and Rental.returnDate is NULL";
            MessageBox.Show(myCommand.CommandText);
            myReader = myCommand.ExecuteReader();
            listOfRentals.Rows.Clear();
            listOfRentals.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
            listOfRentals.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
            while (myReader.Read())
            {
                listOfRentals.Rows.Add(myReader["rentalID"].ToString(), Convert.ToDateTime(myReader["pickUpDate"]).ToShortDateString(), Convert.ToDateTime(myReader["expectedDate"]).ToShortDateString(), myReader["carTypeID"].ToString(),
                                    myReader["make"].ToString(), myReader["model"].ToString(), myReader["year"].ToString(), myReader["dailyPricing"].ToString(), myReader["weeklyPricing"].ToString(),
                                    myReader["monthlyPricing"].ToString(), myReader["lateFee"].ToString(), myReader["changeBranch"].ToString(), myReader["employeeID"].ToString(), myReader["estimatedCost"].ToString());
            }
            myReader.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }

        private void listOfRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            bool goldMembership = false;
            int requestedClass = 0;
            string custID = extractID(customerIDBox);
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

            DateTime pickUpDate = Convert.ToDateTime(listOfRentals.SelectedRows[0].Cells[1].Value.ToString());
            DateTime expectedDate = Convert.ToDateTime(listOfRentals.SelectedRows[0].Cells[2].Value.ToString());
            float dailyPricing = Convert.ToSingle(listOfRentals.SelectedRows[0].Cells[7].Value);
            float weeklyPricing = Convert.ToSingle(listOfRentals.SelectedRows[0].Cells[8].Value);
            float monthlyPricing = Convert.ToSingle(listOfRentals.SelectedRows[0].Cells[9].Value);

            //If gold member, then override 
            if (goldMembership == true)
            {
                requestedClass = Convert.ToInt32(listOfRentals.SelectedRows[0].Cells[13].Value);
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
            int days = (returnDate.Value - pickUpDate).Days;
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




        }
    }
}
