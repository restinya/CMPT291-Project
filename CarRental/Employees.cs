using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRental
{
    public partial class Employees : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Employees()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void empSearchButton_Click(object sender, EventArgs e)
        {
            //Generate list of employees given query
            myCommand.CommandText = "SELECT * FROM Employee, Branch WHERE Employee.branchID = Branch.branchID AND " +
                                    "Employee.fName LIKE '" + fNameBox.Text + "%' AND " +
                                    "Employee.lName LIKE '" + lNameBox.Text + "%' AND " +
                                    "Employee.street LIKE '" + streetBox.Text + "%' AND " +
                                    "Employee.city LIKE '" + cityBox.Text +  "%' AND " +
                                    "Employee.postalcode = '" + postalBox.Text + "'";
            myReader = myCommand.ExecuteReader();
            empDataView.Rows.Clear();
            while (myReader.Read())
            {
                empDataView.Rows.Add(myReader["empID"].ToString(),
                                     myReader["branchID"].ToString(),
                                     myReader["fName"].ToString(),
                                     myReader["lName"].ToString(),
                                     myReader["street"].ToString(),
                                     myReader["city"].ToString(),
                                     myReader["postalcode"].ToString());
            }
            myReader.Close();
        }

        private void empDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }
    }
}
