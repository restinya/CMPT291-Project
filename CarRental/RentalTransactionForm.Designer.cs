
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
            this.label4 = new System.Windows.Forms.Label();
            this.requestedClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pickUpBranch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pickUpDate = new System.Windows.Forms.DateTimePicker();
            this.expectedDate = new System.Windows.Forms.DateTimePicker();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
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
            this.carID = new System.Windows.Forms.ComboBox();
            this.customerForm.SuspendLayout();
            this.requestCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick Up Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expected Return Date";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(24, 499);
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
            this.label6.Location = new System.Drawing.Point(24, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Customer ID";
            // 
            // customerID
            // 
            this.customerID.FormattingEnabled = true;
            this.customerID.Location = new System.Drawing.Point(24, 48);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(121, 23);
            this.customerID.TabIndex = 15;
            this.customerID.SelectedIndexChanged += new System.EventHandler(this.customerID_SelectedIndexChanged);
            // 
            // checkBoxCustomer
            // 
            this.checkBoxCustomer.AutoSize = true;
            this.checkBoxCustomer.Location = new System.Drawing.Point(179, 50);
            this.checkBoxCustomer.Name = "checkBoxCustomer";
            this.checkBoxCustomer.Size = new System.Drawing.Size(149, 19);
            this.checkBoxCustomer.TabIndex = 16;
            this.checkBoxCustomer.Text = "Select If New Customer";
            this.checkBoxCustomer.UseVisualStyleBackColor = true;
            this.checkBoxCustomer.CheckedChanged += new System.EventHandler(this.checkBoxCustomer_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gold Member";
            // 
            // requestedClass
            // 
            this.requestedClass.FormattingEnabled = true;
            this.requestedClass.Location = new System.Drawing.Point(13, 32);
            this.requestedClass.Name = "requestedClass";
            this.requestedClass.Size = new System.Drawing.Size(121, 23);
            this.requestedClass.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pick-Up Branch ID";
            // 
            // pickUpBranch
            // 
            this.pickUpBranch.FormattingEnabled = true;
            this.pickUpBranch.Location = new System.Drawing.Point(27, 154);
            this.pickUpBranch.Name = "pickUpBranch";
            this.pickUpBranch.Size = new System.Drawing.Size(121, 23);
            this.pickUpBranch.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Car ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Requested Vehicle Class";
            // 
            // pickUpDate
            // 
            this.pickUpDate.CustomFormat = "YYYYMMDD";
            this.pickUpDate.Location = new System.Drawing.Point(25, 272);
            this.pickUpDate.Name = "pickUpDate";
            this.pickUpDate.Size = new System.Drawing.Size(200, 23);
            this.pickUpDate.TabIndex = 28;
            // 
            // expectedDate
            // 
            this.expectedDate.CustomFormat = "YYYYMMDD";
            this.expectedDate.Location = new System.Drawing.Point(25, 332);
            this.expectedDate.Name = "expectedDate";
            this.expectedDate.Size = new System.Drawing.Size(200, 23);
            this.expectedDate.TabIndex = 29;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(27, 105);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(42, 19);
            this.radioButtonYes.TabIndex = 30;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(83, 105);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(41, 19);
            this.radioButtonNo.TabIndex = 31;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(24, 435);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(163, 40);
            this.calculateButton.TabIndex = 32;
            this.calculateButton.Text = "Calculate Estimated Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(218, 445);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(117, 23);
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
            this.customerDetails.Location = new System.Drawing.Point(407, 32);
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
            this.customerForm.Location = new System.Drawing.Point(408, 65);
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
            this.addButton.Location = new System.Drawing.Point(794, 512);
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
            this.label22.Location = new System.Drawing.Point(25, 368);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 15);
            this.label22.TabIndex = 38;
            this.label22.Text = "Employee ID";
            // 
            // empID
            // 
            this.empID.FormattingEnabled = true;
            this.empID.Location = new System.Drawing.Point(25, 386);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(121, 23);
            this.empID.TabIndex = 39;
            // 
            // requestCar
            // 
            this.requestCar.Controls.Add(this.label9);
            this.requestCar.Controls.Add(this.requestedClass);
            this.requestCar.Location = new System.Drawing.Point(179, 75);
            this.requestCar.Name = "requestCar";
            this.requestCar.Size = new System.Drawing.Size(162, 61);
            this.requestCar.TabIndex = 40;
            this.requestCar.TabStop = false;
            this.requestCar.Visible = false;
            // 
            // carID
            // 
            this.carID.FormattingEnabled = true;
            this.carID.Location = new System.Drawing.Point(27, 214);
            this.carID.Name = "carID";
            this.carID.Size = new System.Drawing.Size(121, 23);
            this.carID.TabIndex = 41;
            // 
            // RentalTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 577);
            this.Controls.Add(this.carID);
            this.Controls.Add(this.requestCar);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.customerForm);
            this.Controls.Add(this.customerDetails);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.expectedDate);
            this.Controls.Add(this.pickUpDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pickUpBranch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxCustomer);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RentalTransactionForm";
            this.Text = "RentalTransactionForm";
            this.customerForm.ResumeLayout(false);
            this.customerForm.PerformLayout();
            this.requestCar.ResumeLayout(false);
            this.requestCar.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox requestedClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pickUpBranch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox car;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker pickUpDate;
        private System.Windows.Forms.DateTimePicker expectedDate;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
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
        private System.Windows.Forms.ComboBox carID;
    }
}