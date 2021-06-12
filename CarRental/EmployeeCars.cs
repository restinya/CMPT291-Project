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
    public partial class EmployeeCars : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public string id = "", updateCarID, updateCarType, updateMake, updateModel, updateYear, updateLicensePlate;
        public string updateCurrentMileage, updateTransmissionType, updateSeats, updateBranchID, updateStatus;

        public void DisplayData()
        {
            listOfCars.Rows.Clear();
            myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                listOfCars.Rows.Add(myReader["carID"].ToString(), myReader["carClass"].ToString(), myReader["make"].ToString(), myReader["model"].ToString(),
                                    myReader["year"].ToString(), myReader["licensePlate"].ToString(), myReader["currentMileage"].ToString(),
                                    myReader["transmissionType"].ToString(), myReader["seats"].ToString(), myReader["branchID"].ToString(), myReader["status"].ToString());
            }
            myReader.Close();
        }

        public string readCarTypeID(string CarClass)
        {
            String carTypeID = "";
            //Retrieve carTypeID
            myCommand.CommandText = "select carTypeID from CarType where carClass = '" + CarClass + "'";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                carTypeID = myReader["carTypeID"].ToString();
            }
            myReader.Close();
            

            return carTypeID;
        }

        public EmployeeCars()
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
                //Retrieving branchIDs
                myCommand.CommandText = "select branchID from Branch";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    branch.Items.Add(myReader["branchID"].ToString());
                }
                myReader.Close();
                //Retrieving Vehicle Classes
                myCommand.CommandText = "select carClass from CarType";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    vehicleClass.Items.Add(myReader["carClass"].ToString());
                }
                myReader.Close();
                //Retrieving current car records
                DisplayData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }


            private void button5_Click(object sender, EventArgs e)
            {
                this.Hide();
                RentalTransactionForm r1 = new RentalTransactionForm();
                r1.ShowDialog();
            }

            private void button6_Click(object sender, EventArgs e)
            {
                this.Hide();
                ReturnTransactionForm r1 = new ReturnTransactionForm();
                r1.ShowDialog();
            }

            private void button7_Click(object sender, EventArgs e)
            {
                this.Hide();
                Reports r1 = new Reports();
                r1.ShowDialog();
            }

            private void button8_Click(object sender, EventArgs e)
            {
                this.Hide();
                Welcome w1 = new Welcome();
                w1.ShowDialog();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            }
    
            private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            {
                int rowselect = e.RowIndex;
                updateCarID = listOfCars.Rows[rowselect].Cells[0].Value.ToString();
                updateCarType = listOfCars.Rows[rowselect].Cells[1].Value.ToString();
                updateMake = listOfCars.Rows[rowselect].Cells[2].Value.ToString();
                updateModel = listOfCars.Rows[rowselect].Cells[3].Value.ToString();
                updateYear = listOfCars.Rows[rowselect].Cells[4].Value.ToString();
                updateLicensePlate = listOfCars.Rows[rowselect].Cells[5].Value.ToString();
                updateCurrentMileage = listOfCars.Rows[rowselect].Cells[6].Value.ToString();
                updateTransmissionType = listOfCars.Rows[rowselect].Cells[7].Value.ToString();
                updateSeats = listOfCars.Rows[rowselect].Cells[8].Value.ToString();
                updateBranchID = listOfCars.Rows[rowselect].Cells[9].Value.ToString();
                updateStatus = listOfCars.Rows[rowselect].Cells[10].Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String BranchName, CarClass, branchID = "sample", carTypeID = "sample";
            BranchName = branchName.Text;
            CarClass = carClass.Text;

            //Retrieve branchID
            myCommand.CommandText = "select branchID from Branch where branchName = '" + BranchName + "'";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                branchID = myReader["branchID"].ToString();
            }
            myReader.Close();
            //Retrieve carTypeID
            carTypeID = readCarTypeID(CarClass);
            //Add to Database
            myCommand.CommandText = "insert into Car values (" + "'" + licensePlate.Text + "','" + status.Text + "'," + currentMileage.Text + ",'" + transmissionType.Text + "'," +
                                            seats.Text + "," + year.Text + ",'" + make.Text + "','" + model.Text + "'," +
                                            carTypeID + "," + branchID + ")";
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
            //Clear All of the Textbox in the Add Form
            foreach(Control childControl in addForm.Controls)
            {
                if (childControl is TextBox)
                {
                    childControl.ResetText();
                }
            }
            DisplayData();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //Retrieve records based on branch and vehicle class
            if (branch.Text == "" && vehicleClass.Text != "")
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID and carClass = '" + vehicleClass.Text + "'";
            }
            else if (branch.Text != "" && vehicleClass.Text == "")
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID and branchID = " + branch.Text;
            }
            else if (branch.Text == "" && vehicleClass.Text == "")
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID";
            }
            else
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID and branchID = " + branch.Text + " and carClass = '" + vehicleClass.Text + "'";
            }
            myReader = myCommand.ExecuteReader();
            listOfCars.Rows.Clear();
            while (myReader.Read())
            {
                listOfCars.Rows.Add(myReader["carID"].ToString(), myReader["carClass"].ToString(), myReader["make"].ToString(), myReader["model"].ToString(),
                                        myReader["year"].ToString(), myReader["licensePlate"].ToString(), myReader["currentMileage"].ToString(),
                                        myReader["transmissionType"].ToString(), myReader["seats"].ToString(), myReader["branchID"].ToString(), myReader["status"].ToString());
            }
            myReader.Close();
        }

        private void branch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            branch.Text = "";
            vehicleClass.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String id = listOfCars.SelectedRows[0].Cells[0].Value.ToString();
            if (id != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?","Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    myCommand.CommandText = "delete from Car where carID = " + id;
                    myCommand.ExecuteNonQuery();
                    //Load the display
                    DisplayData();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*String id = listOfCars.SelectedRows[0].Cells[0].Value.ToString();*/
            if (updateCarID != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string carTypeID = readCarTypeID(updateCarType);
                    myCommand.CommandText = "UPDATE Car SET licensePlate = '" + updateLicensePlate + "', status = '" + updateStatus + "', currentMileage = " +
                                    updateCurrentMileage + ", transmissionType = '" + updateTransmissionType + "', seats = " + updateSeats +
                                    ", year = " + updateYear + ", make = '" + updateMake + "', model = '" + updateModel + "', carTypeID = " +
                                    carTypeID + ", branchID = " + updateBranchID + " where carID = " + updateCarID;
                    MessageBox.Show(myCommand.CommandText);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Car Record with carID = " + updateCarID + " has been successfully updated.");
                }
            }
        }
    }
    }
