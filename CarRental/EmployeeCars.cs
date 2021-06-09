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
                //Retrieving current car records
                myCommand.CommandText = "select * from Car";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    listOfCars.Rows.Add(myReader["carID"].ToString(), myReader["carTypeID"].ToString(), myReader["make"].ToString(), myReader["model"].ToString(),
                                        myReader["year"].ToString(), myReader["licensePlate"].ToString(), myReader["currentMileage"].ToString(),
                                        myReader["transmissionType"].ToString(), myReader["seats"].ToString(), myReader["branchID"].ToString(), myReader["status"].ToString());
                }
                myReader.Close();
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
            myCommand.CommandText = "select carTypeID from CarType where carClass = '" + CarClass + "'";
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
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
        }
    }
    }
