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


    public partial class carTypeSel : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public carTypeSel()
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


            //Populate the items in the following comboboxes
            try
            {
                //Retrieving branchIDs
                myCommand.CommandText = "select branchID, branchName from Branch";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    pickupLocation.Items.Add(myReader["branchID"].ToString() + " - " + myReader["branchName"].ToString());
                    returnLocation.Items.Add(myReader["branchID"].ToString() + " - " + myReader["branchName"].ToString());
                    /* branchName.Items.Add(myReader["branchName"].ToString()); */
                }
                myReader.Close();

                //Retrieving Vehicle Classes
                myCommand.CommandText = "select carTypeID, carClass from CarType";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    vehicleClass.Items.Add(myReader["carTypeID"].ToString() + " - " + myReader["carClass"].ToString());
                    /* carClass.Items.Add(myReader["carClass"].ToString()); */
                }
                myReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

        }

        public static string SetValueForPickupLoc = "";
        public static string SetValueForReturnLoc = "";
        public static DateTime SetValueForPickupDate;
        public static DateTime SetValueForReturnDate;
        public static string SetValueForCarType = "";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (returnCheckbox.Checked) {
                returnLocLabel.Visible = true;
                returnLocation.Visible = true;
            }
            if (returnCheckbox.Checked == false)
            {
                returnLocLabel.Visible = false;
                returnLocation.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForPickupLoc = pickupLocation.Text;
            SetValueForPickupDate = pickupDate.Value;
            SetValueForReturnDate = returnDate.Value;
            SetValueForCarType = vehicleClass.Text;

            //if return location is different to pickup location
            if (returnCheckbox.Checked == true)
            {
               SetValueForReturnLoc = returnLocation.Text;
            } else
            {
                SetValueForReturnLoc = pickupLocation.Text;   // if returning to same location
            }
            


            this.Hide();
            CarList c1 = new CarList();
            c1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w1 = new Welcome();
            w1.ShowDialog();
        }

        private void returnLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pickupLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Selection_Load(object sender, EventArgs e)
        {

        }

        private void vehicleClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
