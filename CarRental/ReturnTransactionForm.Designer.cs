
namespace CarRental
{
    partial class ReturnTransactionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.mileageUsed = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.customerIDBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.returnBranch = new System.Windows.Forms.ComboBox();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.listOfRentals = new System.Windows.Forms.DataGridView();
            this.rentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyPricing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeklyPricing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyPricing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Return Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mileage Used";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // mileageUsed
            // 
            this.mileageUsed.Location = new System.Drawing.Point(15, 91);
            this.mileageUsed.Name = "mileageUsed";
            this.mileageUsed.Size = new System.Drawing.Size(100, 23);
            this.mileageUsed.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(619, 596);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(20, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer ID";
            // 
            // customerIDBox
            // 
            this.customerIDBox.FormattingEnabled = true;
            this.customerIDBox.Location = new System.Drawing.Point(18, 49);
            this.customerIDBox.Name = "customerIDBox";
            this.customerIDBox.Size = new System.Drawing.Size(121, 23);
            this.customerIDBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listOfRentals);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.customerIDBox);
            this.groupBox1.Location = new System.Drawing.Point(20, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 533);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Form";
            // 
            // loadButton
            // 
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loadButton.Location = new System.Drawing.Point(166, 48);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(158, 23);
            this.loadButton.TabIndex = 49;
            this.loadButton.Text = "Load Ongoing Rentals";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Total Fee";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(114, 493);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(166, 23);
            this.result.TabIndex = 47;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(528, 456);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 30);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate Total Fee";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.returnBranch);
            this.groupBox2.Controls.Add(this.returnDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mileageUsed);
            this.groupBox2.Location = new System.Drawing.Point(18, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 128);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(379, 36);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(158, 23);
            this.checkButton.TabIndex = 17;
            this.checkButton.Text = "Check Gold Membership";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Return Branch";
            // 
            // returnBranch
            // 
            this.returnBranch.FormattingEnabled = true;
            this.returnBranch.Location = new System.Drawing.Point(237, 37);
            this.returnBranch.Name = "returnBranch";
            this.returnBranch.Size = new System.Drawing.Size(121, 23);
            this.returnBranch.TabIndex = 14;
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(15, 37);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 23);
            this.returnDate.TabIndex = 16;
            // 
            // listOfRentals
            // 
            this.listOfRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalID,
            this.pickUpDate,
            this.expectedDate,
            this.carType,
            this.make,
            this.model,
            this.year,
            this.dailyPricing,
            this.weeklyPricing,
            this.monthlyPricing,
            this.lateFee,
            this.changeBranch,
            this.employeeID,
            this.requestedClass});
            this.listOfRentals.Location = new System.Drawing.Point(18, 90);
            this.listOfRentals.Name = "listOfRentals";
            this.listOfRentals.RowTemplate.Height = 25;
            this.listOfRentals.Size = new System.Drawing.Size(636, 226);
            this.listOfRentals.TabIndex = 13;
            this.listOfRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfRentals_CellContentClick);
            // 
            // rentalID
            // 
            this.rentalID.HeaderText = "Rental ID";
            this.rentalID.Name = "rentalID";
            // 
            // pickUpDate
            // 
            this.pickUpDate.HeaderText = "Pick-Up Date";
            this.pickUpDate.Name = "pickUpDate";
            // 
            // expectedDate
            // 
            this.expectedDate.HeaderText = "Expected Date";
            this.expectedDate.Name = "expectedDate";
            // 
            // carType
            // 
            this.carType.HeaderText = "Car Type";
            this.carType.Name = "carType";
            // 
            // make
            // 
            this.make.HeaderText = "Make";
            this.make.Name = "make";
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            // 
            // dailyPricing
            // 
            this.dailyPricing.HeaderText = "Daily Pricing";
            this.dailyPricing.Name = "dailyPricing";
            // 
            // weeklyPricing
            // 
            this.weeklyPricing.HeaderText = "Weekly Pricing";
            this.weeklyPricing.Name = "weeklyPricing";
            // 
            // monthlyPricing
            // 
            this.monthlyPricing.HeaderText = "Monthly Pricing";
            this.monthlyPricing.Name = "monthlyPricing";
            // 
            // lateFee
            // 
            this.lateFee.HeaderText = "Late Fee";
            this.lateFee.Name = "lateFee";
            // 
            // changeBranch
            // 
            this.changeBranch.HeaderText = "Different Return Branch Fee";
            this.changeBranch.Name = "changeBranch";
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "Employee ID";
            this.employeeID.Name = "employeeID";
            // 
            // requestedClass
            // 
            this.requestedClass.HeaderText = "Requested Car Type ID";
            this.requestedClass.Name = "requestedClass";
            // 
            // ReturnTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Name = "ReturnTransactionForm";
            this.Text = "ReturnTransactionForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mileageUsed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox customerIDBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox returnBranch;
        private System.Windows.Forms.DataGridView listOfRentals;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox rn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn carType;
        private System.Windows.Forms.DataGridViewTextBoxColumn make;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyPricing;
        private System.Windows.Forms.DataGridViewTextBoxColumn weeklyPricing;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyPricing;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedClass;
    }
}