
namespace CarRental
{
    partial class EmployeeCars
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EmployeeLOC = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.branch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addForm = new System.Windows.Forms.GroupBox();
            this.seats = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.branchName = new System.Windows.Forms.ComboBox();
            this.transmissionType = new System.Windows.Forms.ComboBox();
            this.carClass = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.licensePlate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentMileage = new System.Windows.Forms.TextBox();
            this.make = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.listOfCars = new System.Windows.Forms.DataGridView();
            this.vehicleClass = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.tabControl1.SuspendLayout();
            this.EmployeeLOC.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.addForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCars)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EmployeeLOC);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 796);
            this.tabControl1.TabIndex = 1;
            // 
            // EmployeeLOC
            // 
            this.EmployeeLOC.BackColor = System.Drawing.Color.DarkGray;
            this.EmployeeLOC.Controls.Add(this.groupBox3);
            this.EmployeeLOC.Controls.Add(this.groupBox2);
            this.EmployeeLOC.Controls.Add(this.groupBox1);
            this.EmployeeLOC.Controls.Add(this.button8);
            this.EmployeeLOC.Controls.Add(this.button7);
            this.EmployeeLOC.Location = new System.Drawing.Point(4, 24);
            this.EmployeeLOC.Name = "EmployeeLOC";
            this.EmployeeLOC.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeLOC.Size = new System.Drawing.Size(1050, 768);
            this.EmployeeLOC.TabIndex = 1;
            this.EmployeeLOC.Text = "EmployeeLOC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.loadButton);
            this.groupBox3.Controls.Add(this.branch);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.addForm);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.listOfCars);
            this.groupBox3.Controls.Add(this.vehicleClass);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Location = new System.Drawing.Point(16, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1002, 579);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Car Records";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Branch";
            // 
            // loadButton
            // 
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loadButton.Location = new System.Drawing.Point(322, 34);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(114, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // branch
            // 
            this.branch.FormattingEnabled = true;
            this.branch.Location = new System.Drawing.Point(20, 34);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(121, 23);
            this.branch.TabIndex = 5;
            this.branch.SelectedIndexChanged += new System.EventHandler(this.branch_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(322, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Clear Filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vehicle Class";
            // 
            // addForm
            // 
            this.addForm.Controls.Add(this.seats);
            this.addForm.Controls.Add(this.status);
            this.addForm.Controls.Add(this.branchName);
            this.addForm.Controls.Add(this.transmissionType);
            this.addForm.Controls.Add(this.carClass);
            this.addForm.Controls.Add(this.label14);
            this.addForm.Controls.Add(this.label4);
            this.addForm.Controls.Add(this.label13);
            this.addForm.Controls.Add(this.licensePlate);
            this.addForm.Controls.Add(this.label12);
            this.addForm.Controls.Add(this.label5);
            this.addForm.Controls.Add(this.label6);
            this.addForm.Controls.Add(this.currentMileage);
            this.addForm.Controls.Add(this.make);
            this.addForm.Controls.Add(this.label11);
            this.addForm.Controls.Add(this.label7);
            this.addForm.Controls.Add(this.label10);
            this.addForm.Controls.Add(this.model);
            this.addForm.Controls.Add(this.label9);
            this.addForm.Controls.Add(this.year);
            this.addForm.Controls.Add(this.label8);
            this.addForm.Location = new System.Drawing.Point(617, 87);
            this.addForm.Name = "addForm";
            this.addForm.Size = new System.Drawing.Size(355, 447);
            this.addForm.TabIndex = 33;
            this.addForm.TabStop = false;
            this.addForm.Text = "NEW CAR RECORD";
            // 
            // seats
            // 
            this.seats.FormattingEnabled = true;
            this.seats.Items.AddRange(new object[] {
            "2",
            "4",
            "5",
            "7",
            "8"});
            this.seats.Location = new System.Drawing.Point(146, 268);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(196, 23);
            this.seats.TabIndex = 37;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Available",
            "Repair",
            "Maintenance"});
            this.status.Location = new System.Drawing.Point(146, 385);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(196, 23);
            this.status.TabIndex = 36;
            // 
            // branchName
            // 
            this.branchName.FormattingEnabled = true;
            this.branchName.Location = new System.Drawing.Point(146, 345);
            this.branchName.Name = "branchName";
            this.branchName.Size = new System.Drawing.Size(196, 23);
            this.branchName.TabIndex = 35;
            // 
            // transmissionType
            // 
            this.transmissionType.FormattingEnabled = true;
            this.transmissionType.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.transmissionType.Location = new System.Drawing.Point(145, 229);
            this.transmissionType.Name = "transmissionType";
            this.transmissionType.Size = new System.Drawing.Size(197, 23);
            this.transmissionType.TabIndex = 34;
            // 
            // carClass
            // 
            this.carClass.FormattingEnabled = true;
            this.carClass.Location = new System.Drawing.Point(145, 76);
            this.carClass.Name = "carClass";
            this.carClass.Size = new System.Drawing.Size(197, 23);
            this.carClass.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Branch Located In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "License Plate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Vehicle Class";
            // 
            // licensePlate
            // 
            this.licensePlate.Location = new System.Drawing.Point(145, 41);
            this.licensePlate.Name = "licensePlate";
            this.licensePlate.Size = new System.Drawing.Size(197, 23);
            this.licensePlate.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Car Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Make";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 16;
            // 
            // currentMileage
            // 
            this.currentMileage.Location = new System.Drawing.Point(145, 304);
            this.currentMileage.Name = "currentMileage";
            this.currentMileage.Size = new System.Drawing.Size(197, 23);
            this.currentMileage.TabIndex = 27;
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(145, 111);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(197, 23);
            this.make.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "No. of Seats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Current Mileage";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(145, 149);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(197, 23);
            this.model.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Transmission Type";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(145, 188);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(197, 23);
            this.year.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Year";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(897, 540);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.listOfCars.Location = new System.Drawing.Point(22, 95);
            this.listOfCars.Name = "listOfCars";
            this.listOfCars.RowTemplate.Height = 25;
            this.listOfCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfCars.Size = new System.Drawing.Size(558, 439);
            this.listOfCars.TabIndex = 37;
            this.listOfCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.listOfCars.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // vehicleClass
            // 
            this.vehicleClass.FormattingEnabled = true;
            this.vehicleClass.Location = new System.Drawing.Point(169, 34);
            this.vehicleClass.Name = "vehicleClass";
            this.vehicleClass.Size = new System.Drawing.Size(121, 23);
            this.vehicleClass.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 540);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(502, 540);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(532, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 86);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer and Employee";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(26, 51);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(171, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Employee Records";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Customer Records";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(780, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 112);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental Reservations";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Rental Reservations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "New Rental Transaction";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(30, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "New Return Transaction";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(31, 21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 36;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(338, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 23);
            this.button7.TabIndex = 35;
            this.button7.Text = "Custom Reports";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            // EmployeeCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 793);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeCars";
            this.Text = "EmployeeCars";
            this.tabControl1.ResumeLayout(false);
            this.EmployeeLOC.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.addForm.ResumeLayout(false);
            this.addForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCars)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EmployeeLOC;
        private System.Windows.Forms.GroupBox addForm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox licensePlate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
#pragma warning disable CS0169 // The field 'EmployeeCars.textBox3' is never used
        private System.Windows.Forms.TextBox textBox3;
#pragma warning restore CS0169 // The field 'EmployeeCars.textBox3' is never used
        private System.Windows.Forms.Label label6;
#pragma warning disable CS0169 // The field 'EmployeeCars.textBox9' is never used
        private System.Windows.Forms.TextBox textBox9;
#pragma warning restore CS0169 // The field 'EmployeeCars.textBox9' is never used
#pragma warning disable CS0169 // The field 'EmployeeCars.textBox4' is never used
        private System.Windows.Forms.TextBox textBox4;
#pragma warning restore CS0169 // The field 'EmployeeCars.textBox4' is never used
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
#pragma warning disable CS0169 // The field 'EmployeeCars.textBox5' is never used
        private System.Windows.Forms.TextBox textBox5;
#pragma warning restore CS0169 // The field 'EmployeeCars.textBox5' is never used
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label8;
#pragma warning disable CS0169 // The field 'EmployeeCars.textBox7' is never used
        private System.Windows.Forms.TextBox textBox7;
#pragma warning restore CS0169 // The field 'EmployeeCars.textBox7' is never used
#pragma warning disable CS0169 // The field 'EmployeeCars.textBox8' is never used
        private System.Windows.Forms.TextBox textBox8;
#pragma warning restore CS0169 // The field 'EmployeeCars.textBox8' is never used
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox vehicleClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox branch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView listOfCars;
        private System.Windows.Forms.TextBox make;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox currentMileage;
#pragma warning disable CS0169 // The field 'EmployeeCars.ranc' is never used
        private System.Windows.Forms.TextBox ranc;
#pragma warning restore CS0169 // The field 'EmployeeCars.ranc' is never used
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox seats;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox branchName;
        private System.Windows.Forms.ComboBox transmissionType;
        private System.Windows.Forms.ComboBox carClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn make2;
        private System.Windows.Forms.DataGridViewTextBoxColumn model2;
        private System.Windows.Forms.DataGridViewTextBoxColumn year2;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentMileage2;
        private System.Windows.Forms.DataGridViewComboBoxColumn transmissionType2;
        private System.Windows.Forms.DataGridViewComboBoxColumn seats2;
        private System.Windows.Forms.DataGridViewComboBoxColumn status2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn CarType;
        private System.Windows.Forms.DataGridViewComboBoxColumn BranchID;
    }
}