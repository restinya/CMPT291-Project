using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarList : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public CarList()
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarList_Load(object sender, EventArgs e)
        {
            //set variable text parameters for form information header
            pickupLocation.Text = carTypeSel.SetValueForPickupLoc;
            returnLocation.Text = carTypeSel.SetValueForReturnLoc;
            pickupDate.Text = carTypeSel.SetValueForPickupDate.ToString();
            returnDate.Text = carTypeSel.SetValueForReturnDate.ToString();
            classType.Text = carTypeSel.SetValueForCarType;

        }

        private void vehicleSelection_Click(object sender, EventArgs e)
        {

        }
    }
}
