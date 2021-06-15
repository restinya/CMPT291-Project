using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CustomerRecordsScreen : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Boolean edit = false;
        public Boolean editPhone = false;

        public CustomerRecordsScreen()
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

            //Retrieving Customer records
            myCommand.CommandText = "select * from customer";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                customerRecords.Rows.Add(myReader["customerID"].ToString(), myReader["fName"].ToString(), myReader["lName"].ToString(), myReader["goldMember"].ToString(), myReader["city"].ToString(), myReader["state"].ToString(), myReader["street"].ToString(),
                    myReader["postalCode"].ToString(), myReader["dateOfBirth"].ToString());
            }
            myReader.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void customerRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// Displays an editable form with the data from the selected row 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateCus_Click(object sender, EventArgs e)
        {
            if (customerRecords.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                customerForm.Visible = true;
                submitForm.Visible = true;
                cusID.Visible = true;
                cusText.Visible = true;
                string customerID = customerRecords.SelectedRows[0].Cells[0].Value + string.Empty;
                string fName = customerRecords.SelectedRows[0].Cells[1].Value + string.Empty;
                string lName = customerRecords.SelectedRows[0].Cells[2].Value + string.Empty;
                String goldMem = customerRecords.SelectedRows[0].Cells[3].Value + string.Empty;
                string city = customerRecords.SelectedRows[0].Cells[4].Value + string.Empty;
                string state = customerRecords.SelectedRows[0].Cells[5].Value + string.Empty;
                string street = customerRecords.SelectedRows[0].Cells[6].Value + string.Empty;
                string postalCode = customerRecords.SelectedRows[0].Cells[7].Value + string.Empty;
                DateTime dob = DateTime.Parse(customerRecords.SelectedRows[0].Cells[8].Value + string.Empty);
                cusID.Text = customerID;
                fNameBox.Text = fName;
                lNameBox.Text = lName;
                if (goldMem == "True")
                {
                    goldCheck.Checked = true;
                }
                else
                {
                    goldCheck.Checked = false;
                }
                cityBox.Text = city;
                stateBox.Text = state;
                postalCodeBox.Text = postalCode;
                dateOfBirthBox.Value = dob;
                streetBox.Text = street;
                edit = true;
            }
        }

        /// <summary>
        /// Updates customer record inside the mysql database
        /// </summary>
        /// <param name="cusID"> The customer ID of the customer to be edited</param>
        private void updateCusRecord(String cusID)
        {
            myCommand.Parameters.Clear();
            int goldMem = 0;
            if (goldCheck.Checked)
            {
                goldMem = 1;
            }

            String bDay = dateOfBirthBox.Value.ToString();
            myCommand.CommandText = "UPDATE Customer SET fName = @fn,dateOfBirth = @dob, goldMember = @gold,lName = @ln,city = @city, state = @state , street = @street ,postalCode = @postal where customerID = '" + cusID + "'";
            myCommand.Parameters.AddWithValue("@ln", lNameBox.Text);
            myCommand.Parameters.AddWithValue("@fn", fNameBox.Text);
            myCommand.Parameters.AddWithValue("@gold", goldMem);
            myCommand.Parameters.AddWithValue("@city", cityBox.Text);
            myCommand.Parameters.AddWithValue("@state", stateBox.Text);
            myCommand.Parameters.AddWithValue("@street", streetBox.Text);
            myCommand.Parameters.AddWithValue("@postal", postalCodeBox.Text);
            myCommand.Parameters.AddWithValue("@dob", bDay);
            myCommand.ExecuteNonQuery();

        }

        /// <summary>
        /// Adds a new customer to the mysql database
        /// </summary>
        private void addCusRecord()
        {
            myCommand.Parameters.Clear();
            int goldMem = 0;
            if (goldCheck.Checked)
            {
                goldMem = 1;
            }
            String bDay = dateOfBirthBox.Value.ToString();

            myCommand.CommandText = "Insert into Customer (fName,lName,goldMember,city,state,street,postalCode,dateOfBirth) Values " +
                "(@fn,@ln,@gold,@city,@state,@street,@postal,@dob)";
            myCommand.Parameters.AddWithValue("@ln", lNameBox.Text);
            myCommand.Parameters.AddWithValue("@fn", fNameBox.Text);
            myCommand.Parameters.AddWithValue("@gold", goldMem);
            myCommand.Parameters.AddWithValue("@city", cityBox.Text);
            myCommand.Parameters.AddWithValue("@state", stateBox.Text);
            myCommand.Parameters.AddWithValue("@street", streetBox.Text);
            myCommand.Parameters.AddWithValue("@postal", postalCodeBox.Text);
            myCommand.Parameters.AddWithValue("@dob", bDay);
            myCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Handles when the user submits the customer information form.
        /// Updates a customers records in the database if a record
        /// is being updated and adds a customer to the record if a new
        /// customer is being added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitForm_Click(object sender, EventArgs e)
        {
            //Edit a customer record
            if (edit == true)
            {
                updateCusRecord(cusID.Text);
                //Retrieving changed customer records
                myCommand.CommandText = "select * from customer";
                myReader = myCommand.ExecuteReader();
                customerRecords.Rows.Clear();
                while (myReader.Read())
                {
                    customerRecords.Rows.Add(myReader["customerID"].ToString(), myReader["fName"].ToString(), myReader["lName"].ToString(), myReader["goldMember"].ToString(), myReader["city"].ToString(), myReader["state"].ToString(), myReader["street"].ToString(),
                        myReader["postalCode"].ToString(), myReader["dateOfBirth"].ToString());
                }
                myReader.Close();
                customerForm.Visible = false;
                submitForm.Visible = false;
                cusID.Visible = false;
                cusText.Visible = false;
                confirm.Text = "Selected customer entry has been updated!";
                resetFields();
                edit = false;

            }
            //Add a new customer record
            else
            {
                addCusRecord();
                customerRecords.Rows.Clear();
                //Retrieving changed customer records
                myCommand.CommandText = "select * from customer";
                myReader = myCommand.ExecuteReader();
                customerRecords.Rows.Clear();
                while (myReader.Read())
                {
                    customerRecords.Rows.Add(myReader["customerID"].ToString(), myReader["fName"].ToString(), myReader["lName"].ToString(), myReader["goldMember"].ToString(), myReader["city"].ToString(), myReader["state"].ToString(), myReader["street"].ToString(),
                        myReader["postalCode"].ToString(), myReader["dateOfBirth"].ToString());
                }
                myReader.Close();
                confirm.Text = "A new customer entry has been added!";
                resetFields();
                edit = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cusID_Click(object sender, EventArgs e)
        {

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            customerForm.Visible = true;
            submitForm.Visible = true;
        }
        /// <summary>
        /// Reset all text fields for user entry
        /// </summary>
        private void resetFields()
        {
            lNameBox.Clear();
            fNameBox.Clear();
            dateOfBirthBox.ResetText();
            cityBox.Clear();
            stateBox.Clear();
            streetBox.Clear();
            postalCodeBox.Clear();
            goldCheck.Checked = false;
            phoneNumBox.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Display the phone table for the selected customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerRecords_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            phoneRecords.Rows.Clear();
            try
            {
                if (customerRecords.SelectedRows.Count > 0)
                {
                    //display selected customer records phones
                    string customerID = customerRecords.SelectedRows[0].Cells[0].Value + string.Empty;
                    myCommand.CommandText = "select phoneNum from PhoneNum where customerID = '" + customerID + "'";
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        phoneRecords.Rows.Add(myReader["phoneNum"].ToString());
                    }
                    myReader.Close();
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void homeNumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneForm_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Displays the add phone form when add phone button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPhone_Click(object sender, EventArgs e)
        {
            editPhone = false;
            phoneForm.Visible = true;
            submitPhone.Visible = true;
            oldNumber.Visible = false;
            oldLabel.Visible = false;
            phoneLabel.Text = "Phone Number";

        }

        /// <summary>
        /// Handles when the user submits the phone form.
        /// Updates a phone record in the database if a record
        /// is being updated and adds a phone to the customers 
        /// phone record if a new customer is being added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitPhone_Click(object sender, EventArgs e)
        {
            string customerID = customerRecords.SelectedRows[0].Cells[0].Value + string.Empty;
            //Edit the currently selected phone record
            if (editPhone == true)
            {
                phoneRecords.Rows.Clear();
                updatePhoneRecord(customerID, oldNumber.Text);
                myCommand.CommandText = "select phoneNum from PhoneNum where customerID = '" + customerID + "'";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    phoneRecords.Rows.Add(myReader["phoneNum"].ToString());
                }
                myReader.Close();
                editPhone = false;
                resetFields();
                phoneForm.Visible = false;
                confirm.Text = "Selected phone number has been updated!";
            }
            //Add a new phone record the customers phone records
            else
            {
                phoneRecords.Rows.Clear();
                addPhoneRecord(customerID);
                myCommand.CommandText = "select phoneNum from PhoneNum where customerID = '" + customerID + "'";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    phoneRecords.Rows.Add(myReader["phoneNum"].ToString());
                }
                myReader.Close();
                editPhone = false;
                resetFields();
                phoneForm.Visible = false;
                confirm.Text = "Phone number has been added!";
            }
        }
        /// <summary>
        /// Update phone number button displays the edit phone form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updatePhone_Click(object sender, EventArgs e)
        {
            if (phoneRecords.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                phoneForm.Visible = true;
                submitPhone.Visible = true;
                oldLabel.Visible = true;
                string phoneNum = phoneRecords.SelectedRows[0].Cells[0].Value + string.Empty;
                oldNumber.Text = phoneNum;
                oldNumber.Visible = true;
                phoneLabel.Text = "New Phone Number";
                editPhone = true;
            }
        }

        private void phoneRecords_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Updates a phone record in the mysql database
        /// </summary>
        /// <param name="cusID"></param>
        /// <param name="Num"></param>
        private void updatePhoneRecord(String cusID, String Num)
        {
            myCommand.Parameters.Clear();
            myCommand.CommandText = "UPDATE PhoneNum SET phoneNum = @num where customerID = '" + cusID + "' and phoneNum='" + Num + "'";
            myCommand.Parameters.AddWithValue("@num", phoneNumBox.Text);
            myCommand.ExecuteNonQuery();

        }
        /// <summary>
        /// Add a phone record in the mysql database
        /// </summary>
        /// <param name="cusID"></param>
        private void addPhoneRecord(String cusID)
        {
            myCommand.Parameters.Clear();
            myCommand.CommandText = "Insert into PhoneNum (customerID,phoneNum) Values (@cusID,@num)";
            myCommand.Parameters.AddWithValue("@num", phoneNumBox.Text);
            myCommand.Parameters.AddWithValue("@cusID", cusID);
            myCommand.ExecuteNonQuery();
        }

        private void CustomerRecordsScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }
    }
}
