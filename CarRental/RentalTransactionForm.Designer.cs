
namespace CarRental
{
    partial class RentalTransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.ComboBox();
            this.checkBoxCustomer = new System.Windows.Forms.CheckBox();
            this.requestedClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pickUpBranch = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pickUpDate = new System.Windows.Forms.DateTimePicker();
            this.expectedDate = new System.Windows.Forms.DateTimePicker();
            this.calculateButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.customerDetails = new System.Windows.Forms.Label();
            this.customerForm = new System.Windows.Forms.GroupBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.mobileNum = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.homeNum = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.postalCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.ComboBox();
            this.requestCar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.returnBranch = new System.Windows.Forms.ComboBox();
            this.returnBranchID = new System.Windows.Forms.Label();
            this.changeBranchCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.availableCars = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyPricing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeklyPricing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyPricing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerForm.SuspendLayout();
            this.requestCar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableCars)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick Up Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expected Return Date";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(535, 715);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Customer ID";
            // 
            // customerID
            // 
            this.customerID.FormattingEnabled = true;
            this.customerID.Location = new System.Drawing.Point(15, 107);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(121, 23);
            this.customerID.TabIndex = 15;
            this.customerID.SelectedIndexChanged += new System.EventHandler(this.customerID_SelectedIndexChanged);
            // 
            // checkBoxCustomer
            // 
            this.checkBoxCustomer.AutoSize = true;
            this.checkBoxCustomer.Location = new System.Drawing.Point(170, 109);
            this.checkBoxCustomer.Name = "checkBoxCustomer";
            this.checkBoxCustomer.Size = new System.Drawing.Size(149, 19);
            this.checkBoxCustomer.TabIndex = 16;
            this.checkBoxCustomer.Text = "Select If New Customer";
            this.checkBoxCustomer.UseVisualStyleBackColor = true;
            this.checkBoxCustomer.CheckedChanged += new System.EventHandler(this.checkBoxCustomer_CheckedChanged);
            // 
            // requestedClass
            // 
            this.requestedClass.FormattingEnabled = true;
            this.requestedClass.Location = new System.Drawing.Point(13, 32);
            this.requestedClass.Name = "requestedClass";
            this.requestedClass.Size = new System.Drawing.Size(121, 23);
            this.requestedClass.TabIndex = 20;
            this.requestedClass.SelectedIndexChanged += new System.EventHandler(this.requestedClass_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pick-Up Branch ID";
            // 
            // pickUpBranch
            // 
            this.pickUpBranch.FormattingEnabled = true;
            this.pickUpBranch.Location = new System.Drawing.Point(14, 37);
            this.pickUpBranch.Name = "pickUpBranch";
            this.pickUpBranch.Size = new System.Drawing.Size(121, 23);
            this.pickUpBranch.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Requested Vehicle Class";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pickUpDate
            // 
            this.pickUpDate.CustomFormat = "YYYYMMDD";
            this.pickUpDate.Location = new System.Drawing.Point(14, 115);
            this.pickUpDate.Name = "pickUpDate";
            this.pickUpDate.Size = new System.Drawing.Size(200, 23);
            this.pickUpDate.TabIndex = 28;
            // 
            // expectedDate
            // 
            this.expectedDate.CustomFormat = "YYYYMMDD";
            this.expectedDate.Location = new System.Drawing.Point(258, 114);
            this.expectedDate.Name = "expectedDate";
            this.expectedDate.Size = new System.Drawing.Size(200, 23);
            this.expectedDate.TabIndex = 29;
            this.expectedDate.ValueChanged += new System.EventHandler(this.expectedDate_ValueChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(411, 558);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(163, 40);
            this.calculateButton.TabIndex = 32;
            this.calculateButton.Text = "Calculate Estimated Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(141, 613);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(166, 23);
            this.result.TabIndex = 33;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(23, 48);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(198, 23);
            this.fName.TabIndex = 34;
            // 
            // customerDetails
            // 
            this.customerDetails.AutoSize = true;
            this.customerDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerDetails.Location = new System.Drawing.Point(638, 55);
            this.customerDetails.Name = "customerDetails";
            this.customerDetails.Size = new System.Drawing.Size(179, 30);
            this.customerDetails.TabIndex = 35;
            this.customerDetails.Text = "Customer Details";
            this.customerDetails.Visible = false;
            // 
            // customerForm
            // 
            this.customerForm.Controls.Add(this.dateOfBirth);
            this.customerForm.Controls.Add(this.label7);
            this.customerForm.Controls.Add(this.label20);
            this.customerForm.Controls.Add(this.mobileNum);
            this.customerForm.Controls.Add(this.label19);
            this.customerForm.Controls.Add(this.homeNum);
            this.customerForm.Controls.Add(this.label18);
            this.customerForm.Controls.Add(this.label17);
            this.customerForm.Controls.Add(this.postalCode);
            this.customerForm.Controls.Add(this.label16);
            this.customerForm.Controls.Add(this.state);
            this.customerForm.Controls.Add(this.label15);
            this.customerForm.Controls.Add(this.city);
            this.customerForm.Controls.Add(this.label14);
            this.customerForm.Controls.Add(this.street);
            this.customerForm.Controls.Add(this.label13);
            this.customerForm.Controls.Add(this.label12);
            this.customerForm.Controls.Add(this.label11);
            this.customerForm.Controls.Add(this.lName);
            this.customerForm.Controls.Add(this.label10);
            this.customerForm.Controls.Add(this.fName);
            this.customerForm.Location = new System.Drawing.Point(639, 88);
            this.customerForm.Name = "customerForm";
            this.customerForm.Size = new System.Drawing.Size(461, 441);
            this.customerForm.TabIndex = 36;
            this.customerForm.TabStop = false;
            this.customerForm.Visible = false;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CustomFormat = "";
            this.dateOfBirth.Location = new System.Drawing.Point(23, 321);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dateOfBirth.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Date of Birth";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(172, 412);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 15);
            this.label20.TabIndex = 52;
            this.label20.Text = "Mobile Number";
            // 
            // mobileNum
            // 
            this.mobileNum.Location = new System.Drawing.Point(172, 383);
            this.mobileNum.Name = "mobileNum";
            this.mobileNum.Size = new System.Drawing.Size(128, 23);
            this.mobileNum.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 409);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 15);
            this.label19.TabIndex = 50;
            this.label19.Text = "Home Number";
            // 
            // homeNum
            // 
            this.homeNum.Location = new System.Drawing.Point(23, 383);
            this.homeNum.Name = "homeNum";
            this.homeNum.Size = new System.Drawing.Size(128, 23);
            this.homeNum.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(23, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 20);
            this.label18.TabIndex = 48;
            this.label18.Text = "Phone Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 265);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "Postal Code";
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(23, 239);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(397, 23);
            this.postalCode.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(237, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 45;
            this.label16.Text = "State";
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(237, 185);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(198, 23);
            this.state.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 15);
            this.label15.TabIndex = 43;
            this.label15.Text = "City";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(23, 185);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(198, 23);
            this.city.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 41;
            this.label14.Text = "Street Address";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(23, 131);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(397, 23);
            this.street.TabIndex = 40;
            this.street.TextChanged += new System.EventHandler(this.street_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(23, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(237, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "First Name";
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(237, 48);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(198, 23);
            this.lName.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(23, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Full Name";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1025, 535);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 27);
            this.addButton.TabIndex = 37;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 15);
            this.label22.TabIndex = 38;
            this.label22.Text = "Employee ID";
            // 
            // empID
            // 
            this.empID.FormattingEnabled = true;
            this.empID.Location = new System.Drawing.Point(15, 51);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(121, 23);
            this.empID.TabIndex = 39;
            this.empID.SelectedIndexChanged += new System.EventHandler(this.empID_SelectedIndexChanged);
            // 
            // requestCar
            // 
            this.requestCar.Controls.Add(this.label9);
            this.requestCar.Controls.Add(this.requestedClass);
            this.requestCar.Location = new System.Drawing.Point(202, 134);
            this.requestCar.Name = "requestCar";
            this.requestCar.Size = new System.Drawing.Size(162, 61);
            this.requestCar.TabIndex = 40;
            this.requestCar.TabStop = false;
            this.requestCar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.returnBranch);
            this.groupBox1.Controls.Add(this.returnBranchID);
            this.groupBox1.Controls.Add(this.changeBranchCheck);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pickUpBranch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pickUpDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.expectedDate);
            this.groupBox1.Location = new System.Drawing.Point(17, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 153);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // returnBranch
            // 
            this.returnBranch.FormattingEnabled = true;
            this.returnBranch.Location = new System.Drawing.Point(176, 37);
            this.returnBranch.Name = "returnBranch";
            this.returnBranch.Size = new System.Drawing.Size(121, 23);
            this.returnBranch.TabIndex = 32;
            this.returnBranch.Visible = false;
            // 
            // returnBranchID
            // 
            this.returnBranchID.AutoSize = true;
            this.returnBranchID.Location = new System.Drawing.Point(176, 19);
            this.returnBranchID.Name = "returnBranchID";
            this.returnBranchID.Size = new System.Drawing.Size(96, 15);
            this.returnBranchID.TabIndex = 31;
            this.returnBranchID.Text = "Return Branch ID";
            this.returnBranchID.Visible = false;
            // 
            // changeBranchCheck
            // 
            this.changeBranchCheck.AutoSize = true;
            this.changeBranchCheck.Location = new System.Drawing.Point(15, 66);
            this.changeBranchCheck.Name = "changeBranchCheck";
            this.changeBranchCheck.Size = new System.Drawing.Size(194, 19);
            this.changeBranchCheck.TabIndex = 30;
            this.changeBranchCheck.Text = "Select If Different Return Branch";
            this.changeBranchCheck.UseVisualStyleBackColor = true;
            this.changeBranchCheck.CheckedChanged += new System.EventHandler(this.changeBranchCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 43;
            this.button1.Text = "Find Available Cars";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 45;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Estimated Cost";
            // 
            // s
            // 
            this.s.Controls.Add(this.button3);
            this.s.Controls.Add(this.availableCars);
            this.s.Controls.Add(this.label22);
            this.s.Controls.Add(this.label6);
            this.s.Controls.Add(this.label2);
            this.s.Controls.Add(this.customerID);
            this.s.Controls.Add(this.checkBoxCustomer);
            this.s.Controls.Add(this.button1);
            this.s.Controls.Add(this.groupBox1);
            this.s.Controls.Add(this.requestCar);
            this.s.Controls.Add(this.calculateButton);
            this.s.Controls.Add(this.empID);
            this.s.Controls.Add(this.result);
            this.s.Location = new System.Drawing.Point(24, 55);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(586, 654);
            this.s.TabIndex = 48;
            this.s.TabStop = false;
            this.s.Text = "NEW RENTAL RESERVATION";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 29);
            this.button3.TabIndex = 48;
            this.button3.Text = "Check Gold Membership";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // availableCars
            // 
            this.availableCars.AllowUserToDeleteRows = false;
            this.availableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CarType,
            this.Make,
            this.Model,
            this.Year,
            this.dailyPricing,
            this.weeklyPricing,
            this.monthlyPricing,
            this.lateFee,
            this.changeBranch});
            this.availableCars.Location = new System.Drawing.Point(14, 402);
            this.availableCars.Name = "availableCars";
            this.availableCars.RowTemplate.Height = 25;
            this.availableCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableCars.Size = new System.Drawing.Size(560, 150);
            this.availableCars.TabIndex = 47;
            this.availableCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CarID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Car Type";
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            // 
            // Make
            // 
            this.Make.HeaderText = "Make";
            this.Make.Name = "Make";
            this.Make.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // dailyPricing
            // 
            this.dailyPricing.HeaderText = "Daily Price";
            this.dailyPricing.Name = "dailyPricing";
            this.dailyPricing.ReadOnly = true;
            // 
            // weeklyPricing
            // 
            this.weeklyPricing.HeaderText = "Weekly Price";
            this.weeklyPricing.Name = "weeklyPricing";
            this.weeklyPricing.ReadOnly = true;
            // 
            // monthlyPricing
            // 
            this.monthlyPricing.HeaderText = "Monthly Price";
            this.monthlyPricing.Name = "monthlyPricing";
            this.monthlyPricing.ReadOnly = true;
            // 
            // lateFee
            // 
            this.lateFee.HeaderText = "Late Fee";
            this.lateFee.Name = "lateFee";
            this.lateFee.ReadOnly = true;
            // 
            // changeBranch
            // 
            this.changeBranch.HeaderText = "Different Branch Fee";
            this.changeBranch.Name = "changeBranch";
            this.changeBranch.ReadOnly = true;
            // 
            // RentalTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 757);
            this.Controls.Add(this.s);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.customerForm);
            this.Controls.Add(this.customerDetails);
            this.Controls.Add(this.submitButton);
            this.Name = "RentalTransactionForm";
            this.Text = "RentalTransactionForm";
            this.customerForm.ResumeLayout(false);
            this.customerForm.PerformLayout();
            this.requestCar.ResumeLayout(false);
            this.requestCar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox customerID;
        private System.Windows.Forms.CheckBox checkBoxCustomer;
        private System.Windows.Forms.ComboBox requestedClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pickUpBranch;
#pragma warning disable CS0169 // The field 'RentalTransactionForm.car' is never used
        private System.Windows.Forms.TextBox car;
#pragma warning restore CS0169 // The field 'RentalTransactionForm.car' is never used
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker pickUpDate;
        private System.Windows.Forms.DateTimePicker expectedDate;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label customerDetails;
        private System.Windows.Forms.GroupBox customerForm;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox mobileNum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox homeNum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox postalCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox empID;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox requestCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
#pragma warning disable CS0169 // The field 'RentalTransactionForm.member' is never used
        private System.Windows.Forms.GroupBox member;
#pragma warning restore CS0169 // The field 'RentalTransactionForm.member' is never used
        private System.Windows.Forms.DataGridView availableCars;
        private System.Windows.Forms.GroupBox s;
#pragma warning disable CS0169 // The field 'RentalTransactionForm.hi' is never used
        private System.Windows.Forms.TextBox hi;
#pragma warning restore CS0169 // The field 'RentalTransactionForm.hi' is never used
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox returnBranch;
        private System.Windows.Forms.Label returnBranchID;
        private System.Windows.Forms.CheckBox changeBranchCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyPricing;
        private System.Windows.Forms.DataGridViewTextBoxColumn weeklyPricing;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyPricing;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeBranch;
    }
}