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

        public EmployeeCars()
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
                //Retrieving branchIDs
                myCommand.CommandText = "select branchID, branchName from Branch";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    branch.Items.Add(myReader["branchID"].ToString() + " - " + myReader["branchName"].ToString());
                    branchName.Items.Add(myReader["branchName"].ToString());
                }
                myReader.Close();
                //Retrieving Vehicle Classes
                myCommand.CommandText = "select carTypeID, carClass from CarType";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    vehicleClass.Items.Add(myReader["carTypeID"].ToString() + " - " + myReader["carClass"].ToString());
                    carClass.Items.Add(myReader["carClass"].ToString());
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

            private DataTable GetBranchTable()
            {
                DataTable l_dtBranch = new DataTable();
                l_dtBranch.Columns.Add("BranchID", typeof(string));

                myCommand.CommandText = "select branchID, branchName from Branch";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    l_dtBranch.Rows.Add(myReader["branchID"].ToString());
                }
                myReader.Close();

                return l_dtBranch;
            }

            private DataTable GetVehicleClassTable()
            {
                DataTable l_dtVehicleClass = new DataTable();
                l_dtVehicleClass.Columns.Add("CarType", typeof(string));

                myCommand.CommandText = "select carClass from CarType";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    l_dtVehicleClass.Rows.Add(myReader["carClass"].ToString());
                }
                myReader.Close();

                return l_dtVehicleClass;
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
            if (e.ColumnIndex > -1)
            {
                if (listOfCars.Columns[e.ColumnIndex].Name.Contains("BranchID"))
                {
                    DataGridViewComboBoxCell objGridDropbox = new DataGridViewComboBoxCell();
                    listOfCars[e.ColumnIndex, e.RowIndex] = objGridDropbox;
                    objGridDropbox.DataSource = GetBranchTable();
                    objGridDropbox.ValueMember = "BranchID";
                    objGridDropbox.DisplayMember = "BranchID";
                }

                if (listOfCars.Columns[e.ColumnIndex].Name.Contains("CarType"))
                {
                    DataGridViewComboBoxCell objGridDropbox = new DataGridViewComboBoxCell();
                    listOfCars[e.ColumnIndex, e.RowIndex] = objGridDropbox;
                    objGridDropbox.DataSource = GetVehicleClassTable();
                    objGridDropbox.ValueMember = "CarType";
                    objGridDropbox.DisplayMember = "CarType";
                }
            }
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
            //Check if all of the fields are filled
            foreach (Control childControl in addForm.Controls)
            {
                if (childControl is TextBox || childControl is ComboBox)
                {
                    if (childControl.Text == "")
                    {
                        MessageBox.Show("All fields need to be filled first.");
                        return;
                    }
                }
            }
            String BranchName, branchID = "sample", carTypeID = "sample";
            BranchName = branchName.Text;

            //Retrieve branchID
            myCommand.CommandText = "select branchID from Branch where branchName = '" + BranchName + "'";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                branchID = myReader["branchID"].ToString();
            }
            myReader.Close();
            //Retrieve carTypeID
            carTypeID = extractID(carClass.Text);
            //Add to Database
            myCommand.CommandText = "insert into Car values (" + "'" + licensePlate.Text + "','" + status.Text + "'," + currentMileage.Text + ",'" + transmissionType.Text + "'," +
                                            seats.Text + "," + year.Text + ",'" + make.Text + "','" + model.Text + "'," +
                                            carTypeID + "," + branchID + ")";
            myCommand.ExecuteNonQuery();
            //Retrive the newly created carID
            myCommand.CommandText = "select carID from Car where carID = (select max(carID) from Car)";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                string carID = myReader["customerID"].ToString();
                MessageBox.Show("Car ID " + carID + " is created.");

            }
            myReader.Close();
            //Clear All of the Textbox in the Add Form
            foreach (Control childControl in addForm.Controls)
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
            listOfCars.Rows.Clear();
            //Extract the id number from parameters
            string branchID = "", carTypeID = "";
            if (branch.Text != "")
            {
                branchID = extractID(branch.Text);
            }
            if (vehicleClass.Text != "")
            {
                carTypeID = extractID(vehicleClass.Text);
            }

            //Retrieve records based on branch and vehicle class
            if ((branch.Text == "") && (vehicleClass.Text != ""))
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID and CarType.carTypeID = " + carTypeID;
            }
            else if ((branch.Text != "") && (vehicleClass.Text == ""))
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID and branchID = " + branchID;
            }
            else if ((branch.Text == "") && (vehicleClass.Text == ""))
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID";
            }
            else
            {
                myCommand.CommandText = "select * from Car, CarType where Car.carTypeID = CarType.carTypeID and branchID = " + branchID + " and CarType.carTypeID = " + carTypeID;
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
            if (listOfCars.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a record first.");
                return;
            }
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
            if (listOfCars.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a record first.");
                return;
            }
            /*String id = listOfCars.SelectedRows[0].Cells[0].Value.ToString();*/
            if (updateCarID != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string carTypeID = extractID(updateCarType);
                    myCommand.CommandText = "UPDATE Car SET licensePlate = '" + updateLicensePlate + "', status = '" + updateStatus + "', currentMileage = " +
                                    updateCurrentMileage + ", transmissionType = '" + updateTransmissionType + "', seats = " + updateSeats +
                                    ", year = " + updateYear + ", make = '" + updateMake + "', model = '" + updateModel + "', carTypeID = " +
                                    carTypeID + ", branchID = " + updateBranchID + " where carID = " + updateCarID;
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Car Record with carID = " + updateCarID + " has been successfully updated.");
                }
            }
        }
    }
    }
