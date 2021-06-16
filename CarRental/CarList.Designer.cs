
namespace CarRental
{
    partial class CarList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vehicleSelection = new System.Windows.Forms.Label();
            this.pickupLocLabel = new System.Windows.Forms.Label();
            this.returnLocLabel = new System.Windows.Forms.Label();
            this.pickupLocation = new System.Windows.Forms.Label();
            this.returnLocation = new System.Windows.Forms.Label();
            this.pickupDateLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.pickupDate = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.Label();
            this.classType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.listOfCars = new System.Windows.Forms.DataGridView();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.make2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentMileage2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionType2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.seats2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BranchID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.status2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCars)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleSelection
            // 
            this.vehicleSelection.AutoSize = true;
            this.vehicleSelection.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vehicleSelection.Location = new System.Drawing.Point(17, 26);
            this.vehicleSelection.Name = "vehicleSelection";
            this.vehicleSelection.Size = new System.Drawing.Size(156, 25);
            this.vehicleSelection.TabIndex = 1;
            this.vehicleSelection.Text = "Vehicle Selection";
            this.vehicleSelection.Click += new System.EventHandler(this.vehicleSelection_Click);
            // 
            // pickupLocLabel
            // 
            this.pickupLocLabel.AutoSize = true;
            this.pickupLocLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickupLocLabel.Location = new System.Drawing.Point(26, 62);
            this.pickupLocLabel.Name = "pickupLocLabel";
            this.pickupLocLabel.Size = new System.Drawing.Size(92, 15);
            this.pickupLocLabel.TabIndex = 2;
            this.pickupLocLabel.Text = "Pickup Location";
            // 
            // returnLocLabel
            // 
            this.returnLocLabel.AutoSize = true;
            this.returnLocLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnLocLabel.Location = new System.Drawing.Point(26, 86);
            this.returnLocLabel.Name = "returnLocLabel";
            this.returnLocLabel.Size = new System.Drawing.Size(91, 15);
            this.returnLocLabel.TabIndex = 3;
            this.returnLocLabel.Text = "Return Location";
            // 
            // pickupLocation
            // 
            this.pickupLocation.AutoSize = true;
            this.pickupLocation.Location = new System.Drawing.Point(134, 62);
            this.pickupLocation.Name = "pickupLocation";
            this.pickupLocation.Size = new System.Drawing.Size(0, 15);
            this.pickupLocation.TabIndex = 4;
            // 
            // returnLocation
            // 
            this.returnLocation.AutoSize = true;
            this.returnLocation.Location = new System.Drawing.Point(134, 86);
            this.returnLocation.Name = "returnLocation";
            this.returnLocation.Size = new System.Drawing.Size(0, 15);
            this.returnLocation.TabIndex = 5;
            // 
            // pickupDateLabel
            // 
            this.pickupDateLabel.AutoSize = true;
            this.pickupDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickupDateLabel.Location = new System.Drawing.Point(246, 61);
            this.pickupDateLabel.Name = "pickupDateLabel";
            this.pickupDateLabel.Size = new System.Drawing.Size(71, 15);
            this.pickupDateLabel.TabIndex = 6;
            this.pickupDateLabel.Text = "Pickup Date";
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnDateLabel.Location = new System.Drawing.Point(246, 86);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(70, 15);
            this.returnDateLabel.TabIndex = 7;
            this.returnDateLabel.Text = "Return Date";
            // 
            // pickupDate
            // 
            this.pickupDate.AutoSize = true;
            this.pickupDate.Location = new System.Drawing.Point(360, 61);
            this.pickupDate.Name = "pickupDate";
            this.pickupDate.Size = new System.Drawing.Size(0, 15);
            this.pickupDate.TabIndex = 8;
            // 
            // returnDate
            // 
            this.returnDate.AutoSize = true;
            this.returnDate.Location = new System.Drawing.Point(360, 85);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(0, 15);
            this.returnDate.TabIndex = 9;
            // 
            // classType
            // 
            this.classType.AutoSize = true;
            this.classType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classType.Location = new System.Drawing.Point(26, 114);
            this.classType.Name = "classType";
            this.classType.Size = new System.Drawing.Size(0, 20);
            this.classType.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 11;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(668, 546);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(92, 32);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // listOfCars
            // 
            this.listOfCars.AllowUserToAddRows = false;
            this.listOfCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarID,
            this.CarType,
            this.make2,
            this.model2,
            this.year2,
            this.licensePlate2,
            this.currentMileage2,
            this.transmissionType2,
            this.seats2,
            this.BranchID,
            this.status2});
            this.listOfCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.listOfCars.Location = new System.Drawing.Point(26, 144);
            this.listOfCars.Name = "listOfCars";
            this.listOfCars.RowTemplate.Height = 25;
            this.listOfCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfCars.Size = new System.Drawing.Size(734, 386);
            this.listOfCars.TabIndex = 38;
            this.listOfCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfCars_CellContentClick);
            // 
            // CarID
            // 
            this.CarID.HeaderText = "CarID";
            this.CarID.Name = "CarID";
            this.CarID.ReadOnly = true;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "CarType";
            this.CarType.Items.AddRange(new object[] {
            "SUV",
            "Standard",
            "Intermediate",
            "Luxury"});
            this.CarType.Name = "CarType";
            this.CarType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CarType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // make2
            // 
            this.make2.HeaderText = "Make";
            this.make2.Name = "make2";
            // 
            // model2
            // 
            this.model2.HeaderText = "Model";
            this.model2.Name = "model2";
            // 
            // year2
            // 
            this.year2.HeaderText = "Year";
            this.year2.Name = "year2";
            // 
            // licensePlate2
            // 
            this.licensePlate2.HeaderText = "License Plate";
            this.licensePlate2.Name = "licensePlate2";
            // 
            // currentMileage2
            // 
            this.currentMileage2.HeaderText = "Current Mileage";
            this.currentMileage2.Name = "currentMileage2";
            // 
            // transmissionType2
            // 
            this.transmissionType2.HeaderText = "Transmission Type";
            this.transmissionType2.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.transmissionType2.Name = "transmissionType2";
            this.transmissionType2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transmissionType2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // seats2
            // 
            this.seats2.HeaderText = "Seats";
            this.seats2.Items.AddRange(new object[] {
            "2",
            "4",
            "5",
            "7",
            "8"});
            this.seats2.Name = "seats2";
            this.seats2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.seats2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BranchID
            // 
            this.BranchID.HeaderText = "BranchID";
            this.BranchID.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.BranchID.Name = "BranchID";
            this.BranchID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // status2
            // 
            this.status2.HeaderText = "Status";
            this.status2.Items.AddRange(new object[] {
            "Available",
            "Repair",
            "Maintenance"});
            this.status2.Name = "status2";
            this.status2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(26, 546);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 32);
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 599);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listOfCars);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classType);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.pickupDate);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.pickupDateLabel);
            this.Controls.Add(this.returnLocation);
            this.Controls.Add(this.pickupLocation);
            this.Controls.Add(this.returnLocLabel);
            this.Controls.Add(this.pickupLocLabel);
            this.Controls.Add(this.vehicleSelection);
            this.Name = "CarList";
            this.Text = "CarList";
            this.Load += new System.EventHandler(this.CarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label vehicleSelection;
        private System.Windows.Forms.Label pickupLocLabel;
        private System.Windows.Forms.Label returnLocLabel;
        private System.Windows.Forms.Label pickupLocation;
        private System.Windows.Forms.Label returnLocation;
        private System.Windows.Forms.Label pickupDateLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.Label pickupDate;
        private System.Windows.Forms.Label returnDate;
        private System.Windows.Forms.Label classType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView listOfCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewComboBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn make2;
        private System.Windows.Forms.DataGridViewTextBoxColumn model2;
        private System.Windows.Forms.DataGridViewTextBoxColumn year2;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentMileage2;
        private System.Windows.Forms.DataGridViewComboBoxColumn transmissionType2;
        private System.Windows.Forms.DataGridViewComboBoxColumn seats2;
        private System.Windows.Forms.DataGridViewComboBoxColumn BranchID;
        private System.Windows.Forms.DataGridViewComboBoxColumn status2;
        private System.Windows.Forms.Button backButton;
    }
}