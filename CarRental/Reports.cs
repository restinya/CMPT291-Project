﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Reports : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public DataTable dt = new DataTable();
        public Reports()
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
            selectReport.Items.Add("Top 3 employees based on number of rental reservations completed");
            selectReport.Items.Add("Customer with most SUVs reserved in the same month");
            selectReport.Items.Add("10 Most Used Cars");
            selectReport.Items.Add("Top 3 customers with the most reserved cars returned in a branch");
            selectReport.Items.Add("Top 3 Highest Earning Employees");
            selectReport.Items.Add("Top 3 Cars with the most mileage used");
        }
        /// <summary>
        /// Back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }
        /// <summary>
        /// Displays the contents of the selected report on a table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getReport_Click(object sender, EventArgs e)
        {
            String query;
            String choice = selectReport.Text;
            queryData.DataSource = null;
            queryData.Rows.Clear();
            queryData.Columns.Clear();
            dt.Rows.Clear();
            dt.Columns.Clear();

            switch (choice)
            {
                case "Top 3 employees based on number of rental reservations completed":
                    query = "SELECT TOP (3) *\n" + 
                    "FROM(SELECT TOP(3) employeeID, COUNT(*) as [Rental reservations completed]\n" + 
                    "from Rental\n" + 
                    "GROUP BY employeeID\n" +
                    "ORDER BY COUNT(*) DESC) as subQuery;";

                    myCommand.CommandText = query;
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    queryData.DataSource = dt;
                    myReader.Close();
                    break;

                case "Customer with most SUVs reserved in the same month":
                    query = "SELECT Top(1) customerID\n" +
                             "FROM (SELECT Rental.customerID, CarType.carTypeID, MONTH(pickUpDate) as [month], COUNT(*) as [count]\n" +
                             "FROM Rental, Car, CarType\n" +
                             "WHERE Rental.carID = Car.carID and Car.carTypeID = CarType.carTypeID and CarType.carTypeID = 1\n" +
                             "GROUP BY Rental.customerID, CarType.carTypeID, MONTH(pickUpDate)) as subQuery Order BY count desc;";
                  
                    myCommand.CommandText = query;
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    queryData.DataSource = dt;
                    myReader.Close();
                    break;

                case "10 Most Used Cars":
                    query = "SELECT TOP (10) *\n"+
                            "FROM(SELECT TOP(10) carID, COUNT(*) as [Times Used]\n"+
                            "FROM Rental\n" +
                            "GROUP BY carID\n" +
                            "ORDER BY COUNT(*) DESC) as subQuery";

                    
                    myCommand.CommandText = query;
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    queryData.DataSource = dt;
                    myReader.Close();
                    break;

                case "Top 3 customers with the most reserved cars returned in a branch":
                    query = "SELECT *\n" + 
                            "From(SELECT TOP(3) customerID, COUNT(*) as [Cars Returned]\n" +
                            "FROM Rental, Branch\n" +
                            "where Rental.returnBranchID = Branch.branchID\n" +
                            "GROUP BY customerID Order BY Count(*) desc) as subquery";


                    myCommand.CommandText = query;
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    queryData.DataSource = dt;
                    myReader.Close();
                    break;

                case "Top 3 Highest Earning Employees":
                    query = "SELECT TOP(3) *\n" +
                            "FROM(SELECT TOP(3) employeeID, Sum(totalFee) as [Total Fees from Transactions]\n" +
                            "from Rental\n" +
                            "GROUP BY employeeID\n" +
                            "ORDER BY Sum(totalFee) DESC) as subQuery";


                    myCommand.CommandText = query;
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    queryData.DataSource = dt;
                    myReader.Close();
                    break;

                case "Top 3 Cars with the most mileage used":
                    query = "SELECT TOP (3) *\n" +
                            "FROM(SELECT TOP(10) carID, Sum(mileageUsed) as [Total Mileage used]\n" +
                            "FROM Rental\n" +
                            "GROUP BY carID\n" +
                            "ORDER BY Sum(mileageUsed) DESC) as subQuery";


                    myCommand.CommandText = query;
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    queryData.DataSource = dt;
                    myReader.Close();
                    break;

                default:
                    break;
            }

        }

        private void selectReport_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
