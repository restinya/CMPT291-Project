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
    public partial class CarList : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

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

        /* Helper function that will display all of the car records in the data grid view */
        public void DisplayData()
        {
            listOfCars.Rows.Clear();
            myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                listOfCars.Rows.Add(myReader["status"].ToString(), myReader["carClass"].ToString(), myReader["make"].ToString(), myReader["model"].ToString(),
                                    myReader["year"].ToString(), myReader["transmissionType"].ToString(), myReader["seats"].ToString(), myReader["dailyPricing"].ToString(), 
                                    myReader["monthlyPricing"].ToString());
            }
            myReader.Close();
        }


        public CarList()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void CarList_Load(object sender, EventArgs e)
        {
            //set variable text parameters for form information header
            pickupLocation.Text = carTypeSel.SetValueForPickupLoc;
            returnLocation.Text = carTypeSel.SetValueForReturnLoc;
            pickupDate.Text = carTypeSel.SetValueForPickupDate.ToString();
            returnDate.Text = carTypeSel.SetValueForReturnDate.ToString();
            classType.Text = carTypeSel.SetValueForCarType;

            //DisplayData();

            listOfCars.Rows.Clear();
            //Extract the id number from parameters
            string branchID = "", carTypeID = "";
            if (pickupLocation.Text != "")
            {
                branchID = extractID(pickupLocation.Text);
            }
            if (classType.Text != "")
            {
                carTypeID = extractID(classType.Text);
            }

            //Retrieve records based on branch and vehicle class
            if ((pickupLocation.Text == "") && (classType.Text != ""))
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID and CarType.carTypeID = " + carTypeID;
            }
            else if ((pickupLocation.Text != "") && (classType.Text == ""))
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID and branchID = " + branchID;
            }
            else if ((pickupLocation.Text == "") && (classType.Text == ""))
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID";
            }
            else
            {
                //myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID and branchID = " + branchID + " and CarType.carTypeID = " + carTypeID;
                myCommand.CommandText = "select * from Car, Branch, CarType where Car.branchID = Branch.branchID and Car.cartypeID = CarType.cartypeID and " +
                "Branch.branchID = " + branchID + " and Car.carID not in " +
                "((select carID from Rental where pickUpDate between '" + pickupDate.Text + "' and '" + returnDate.Text + "') UNION " +
                "(select carID from Rental where expectedDate between '" + pickupDate.Text + "' and '" + returnDate.Text + "'))";
            }
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                listOfCars.Rows.Add(myReader["carID"].ToString(), myReader["carClass"].ToString(), myReader["make"].ToString(), myReader["model"].ToString(),
                                    myReader["year"].ToString(), myReader["licensePlate"].ToString(), myReader["currentMileage"].ToString(),
                                    myReader["transmissionType"].ToString(), myReader["seats"].ToString(), myReader["branchID"].ToString(), myReader["status"].ToString());
            }
            myReader.Close();
        }

        private void vehicleSelection_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void listOfCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            carTypeSel c1 = new carTypeSel();
            c1.ShowDialog();
        }
    }
}
