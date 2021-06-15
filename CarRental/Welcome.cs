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
    public partial class Welcome : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Welcome()
        {
            InitializeComponent();

            SqlConnection myConnection = new SqlConnection("user id=admin291;" +
                                        "password=cmpt291;" +
                                        "server=localhost;" +
                                        "database=CarRental; " +
                                        "connection timeout=30");
            //Connecting to DB
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = userSelectBox.SelectedIndex;

            // if Employee is selected
            // when Employee specific screen is ready, change Selection below to the name of the corresponding form
            if (selectedIndex == 1)
            {
                try
                {
                    int i = 0;
                    //Checking if empID is valid
                    myCommand.CommandText = "select * from employee where empID = '"+empIdBox.Text+"'";
                    myCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());

                    // Match was not found
                    if (i == 0)
                    {
                        MessageBox.Show("Invalid Employee ID");
                    }

                    // Match was found
                    else
                    {
                        this.Hide();
                        EmployeeCars e1 = new EmployeeCars();
                        e1.ShowDialog();
                    }

                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            };
            
            // if Customer is Selected
            if (selectedIndex == 0)
            {
                this.Hide();
                carTypeSel s1 = new carTypeSel();
                s1.ShowDialog();
            };

            



        }

        private void empIdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
