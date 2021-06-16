using System;
using System.Data;
using System.Data.SqlClient;
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

        /* Helper function that will display all of the car records in the data grid view */
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

            //Populate the items in the following comboboxes
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

            /* Helper function that will retrieve all of the items for the BranchID combobox in data grid view */
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

            /* Helper function that will retrieve all of the items for the CarType combobox in data grid view */
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

        /* Button linking to Rental Transaction Form */
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalTransactionForm r1 = new RentalTransactionForm();
            r1.ShowDialog();
        }

        /* Button linking to Return Transaction Form */
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnTransactionForm r1 = new ReturnTransactionForm();
            r1.ShowDialog();
        }

        /* Customer Records Button */
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRecordsScreen r1 = new CustomerRecordsScreen();
            r1.ShowDialog();
        }

        /* Employee Records Button */
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees r1 = new Employees();
            r1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalReservations r1 = new RentalReservations();
            r1.ShowDialog();
        }

        private void vehicleClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* Button linking to Reports Form */
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports r1 = new Reports();
            r1.ShowDialog();
        }

        /* Back Button */
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w1 = new Welcome();
            w1.ShowDialog();
        }

        /* Helper function that will connect the populated combobox to the data grid view */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
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
            }*/
        }

        /* Helper function that will retrieve the modified values once the data grid view is done being edited */
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

        /* Add Button */
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
            myCommand.CommandText = "select carTypeID from CarType where carClass = '" + carClass.Text + "'";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                carTypeID = myReader["carTypeID"].ToString();
            }
            myReader.Close();
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
                string carID = myReader["carID"].ToString();
                MessageBox.Show("Car ID " + carID + " is created.");

            }
            myReader.Close();
            //Clear All of the Textbox in the Add Form
            foreach (Control childControl in addForm.Controls)
            {
                if (childControl is TextBox || childControl is ComboBox)
                {
                    childControl.ResetText();
                }
            }
            DisplayData();
        }

        /* Load Button */
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

        /* Clear Filters Button */
        private void button1_Click(object sender, EventArgs e)
        {
            branch.Text = "";
            vehicleClass.Text = "";
        }

        /* Delete Button */
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
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    myCommand.CommandText = "delete from Car where carID = " + id;
                    myCommand.ExecuteNonQuery();
                    //Load the display
                    DisplayData();

                }
            }
        }

        /* Modify Button */
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
