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
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        SqlConnection myConnection = new SqlConnection("user id=admin291;" +
                "password=cmpt291;" +
                "server=localhost;" +
                "database=CarRental; " +
                "connection timeout=30");

        public Employees()
        {
            InitializeComponent();
            DisplayEmployees();
        }

        private void DisplayEmployees()
        {
            myConnection.Open();
            myCommand = new SqlCommand("SELECT * FROM Employee", myConnection);
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
            myConnection.Close();
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
            myCommand = new SqlCommand("SELECT * FROM Employee WHERE IsDeleted = 0", myConnection);
            if (empIDBox.Text != "")
            {
                myCommand.CommandText = " AND empID = @empID";
                myCommand.Parameters.AddWithValue("@empID", empIDBox.Text);
            }
            if (branchBox.Text != "")
            {
                myCommand.CommandText = " AND branchID = @branchID";
                myCommand.Parameters.AddWithValue("@branchID", branchBox.Text);
            }
            if (fNameBox.Text != "")
            {
                myCommand.CommandText = " AND fName = @fName";
                myCommand.Parameters.AddWithValue("@fName", fNameBox.Text + '%');
            }
            if (lNameBox.Text != "")
            {
                myCommand.CommandText = " AND lName = @lName";
                myCommand.Parameters.AddWithValue("@lName", lNameBox.Text + '%');
            }
            if (streetBox.Text != "")
            {
                myCommand.CommandText = " AND street = @street";
                myCommand.Parameters.AddWithValue("@street", streetBox.Text + '%');
            }
            if (cityBox.Text != "")
            {
                myCommand.CommandText = " AND city = @city";
                myCommand.Parameters.AddWithValue("@city", cityBox.Text + '%');
            }
            if (postalBox.Text != "")
            {
                myCommand.CommandText = " AND postalCode = @postalCode";
                myCommand.Parameters.AddWithValue("@postalCode", postalBox.Text);
            }
            myConnection.Open();

            //myCommand.CommandText = "SELECT * FROM Employee WHERE Employee.branchID =" + branchCombo.Text + " AND " +
            //                        "Employee.fName LIKE '" + fNameBox.Text + "%' AND " +
            //                        "Employee.lName LIKE '" + lNameBox.Text + "%' AND " +
            //                        "Employee.street LIKE '" + streetBox.Text + "%' AND " +
            //                        "Employee.city LIKE '" + cityBox.Text +  "%' AND " +
            //                        "Employee.postalcode = '" + postalBox.Text + "'";
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
            myConnection.Close();
        }

        private void empDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void empDataView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editEmpIDBox.Text = empDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
            editFNameBox.Text = empDataView.Rows[e.RowIndex].Cells[2].Value.ToString();
            editLNameBox.Text = empDataView.Rows[e.RowIndex].Cells[3].Value.ToString();
            editStreetBox.Text = empDataView.Rows[e.RowIndex].Cells[4].Value.ToString();
            editCityBox.Text = empDataView.Rows[e.RowIndex].Cells[5].Value.ToString();
            editBranchBox.Text = empDataView.Rows[e.RowIndex].Cells[1].Value.ToString();
            editPostalBox.Text = empDataView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //update selected row
            myCommand = new SqlCommand("update Employee set branchID = @branchID," +
                "fName = @fName," +
                "lName = @lName," +
                "street = @street," +
                "city = @city," +
                "postalcode = @postalcode " +
                "WHERE empID = @empID", myConnection);
            myConnection.Open();
            myCommand.Parameters.AddWithValue("@empID", editEmpIDBox.Text);
            myCommand.Parameters.AddWithValue("@branchID", editBranchBox.Text);
            myCommand.Parameters.AddWithValue("@fName", editFNameBox.Text); 
            myCommand.Parameters.AddWithValue("@lName", editLNameBox.Text);
            myCommand.Parameters.AddWithValue("@street", editStreetBox.Text);
            myCommand.Parameters.AddWithValue("@city", editCityBox.Text); 
            myCommand.Parameters.AddWithValue("@postalcode", editPostalBox.Text);
            myCommand.ExecuteNonQuery();
            MessageBox.Show("Employee Record Updated Successfully.");
            myConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCars e1 = new EmployeeCars();
            e1.ShowDialog();
        }

        private void editFNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
