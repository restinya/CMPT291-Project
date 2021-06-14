
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
            this.button1 = new System.Windows.Forms.Button();
            this.listOfCars = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addForm = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.licensePlate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carClass = new System.Windows.Forms.TextBox();
            this.branchName = new System.Windows.Forms.TextBox();
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
            this.transmissionType = new System.Windows.Forms.TextBox();
            this.seats = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.vehicleClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.make2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentMileage2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionType2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seats2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.EmployeeLOC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCars)).BeginInit();
            this.addForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EmployeeLOC);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 720);
            this.tabControl1.TabIndex = 1;
            // 
            // EmployeeLOC
            // 
            this.EmployeeLOC.BackColor = System.Drawing.Color.DarkGray;
            this.EmployeeLOC.Controls.Add(this.button1);
            this.EmployeeLOC.Controls.Add(this.listOfCars);
            this.EmployeeLOC.Controls.Add(this.button8);
            this.EmployeeLOC.Controls.Add(this.button7);
            this.EmployeeLOC.Controls.Add(this.button6);
            this.EmployeeLOC.Controls.Add(this.button5);
            this.EmployeeLOC.Controls.Add(this.addForm);
            this.EmployeeLOC.Controls.Add(this.deleteButton);
            this.EmployeeLOC.Controls.Add(this.button3);
            this.EmployeeLOC.Controls.Add(this.vehicleClass);
            this.EmployeeLOC.Controls.Add(this.label2);
            this.EmployeeLOC.Controls.Add(this.branch);
            this.EmployeeLOC.Controls.Add(this.label1);
            this.EmployeeLOC.Controls.Add(this.addButton);
            this.EmployeeLOC.Controls.Add(this.loadButton);
            this.EmployeeLOC.Location = new System.Drawing.Point(4, 24);
            this.EmployeeLOC.Name = "EmployeeLOC";
            this.EmployeeLOC.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeLOC.Size = new System.Drawing.Size(991, 692);
            this.EmployeeLOC.TabIndex = 1;
            this.EmployeeLOC.Text = "EmployeeLOC";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(331, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Clear Filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOfCars
            // 
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
            this.listOfCars.Location = new System.Drawing.Point(31, 136);
            this.listOfCars.Name = "listOfCars";
            this.listOfCars.RowTemplate.Height = 25;
            this.listOfCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfCars.Size = new System.Drawing.Size(558, 439);
            this.listOfCars.TabIndex = 37;
            this.listOfCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.listOfCars.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
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
            this.button7.Location = new System.Drawing.Point(788, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(176, 23);
            this.button7.TabIndex = 35;
            this.button7.Text = "Custom Reports";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(788, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "New Return Transaction";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(788, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "New Rental Transaction";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addForm
            // 
            this.addForm.Controls.Add(this.status);
            this.addForm.Controls.Add(this.label14);
            this.addForm.Controls.Add(this.label4);
            this.addForm.Controls.Add(this.label13);
            this.addForm.Controls.Add(this.licensePlate);
            this.addForm.Controls.Add(this.label12);
            this.addForm.Controls.Add(this.label5);
            this.addForm.Controls.Add(this.carClass);
            this.addForm.Controls.Add(this.branchName);
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
            this.addForm.Controls.Add(this.transmissionType);
            this.addForm.Controls.Add(this.seats);
            this.addForm.Location = new System.Drawing.Point(609, 128);
            this.addForm.Name = "addForm";
            this.addForm.Size = new System.Drawing.Size(355, 447);
            this.addForm.TabIndex = 33;
            this.addForm.TabStop = false;
            this.addForm.Text = "NEW CAR RECORD";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(145, 382);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(197, 23);
            this.status.TabIndex = 34;
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
            // carClass
            // 
            this.carClass.Location = new System.Drawing.Point(145, 76);
            this.carClass.Name = "carClass";
            this.carClass.Size = new System.Drawing.Size(197, 23);
            this.carClass.TabIndex = 15;
            // 
            // branchName
            // 
            this.branchName.Location = new System.Drawing.Point(145, 342);
            this.branchName.Name = "branchName";
            this.branchName.Size = new System.Drawing.Size(197, 23);
            this.branchName.TabIndex = 28;
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
            // transmissionType
            // 
            this.transmissionType.Location = new System.Drawing.Point(146, 226);
            this.transmissionType.Name = "transmissionType";
            this.transmissionType.Size = new System.Drawing.Size(197, 23);
            this.transmissionType.TabIndex = 21;
            // 
            // seats
            // 
            this.seats.Location = new System.Drawing.Point(146, 265);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(197, 23);
            this.seats.TabIndex = 22;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(511, 581);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // vehicleClass
            // 
            this.vehicleClass.FormattingEnabled = true;
            this.vehicleClass.Location = new System.Drawing.Point(178, 75);
            this.vehicleClass.Name = "vehicleClass";
            this.vehicleClass.Size = new System.Drawing.Size(121, 23);
            this.vehicleClass.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vehicle Class";
            // 
            // branch
            // 
            this.branch.FormattingEnabled = true;
            this.branch.Location = new System.Drawing.Point(29, 75);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(121, 23);
            this.branch.TabIndex = 5;
            this.branch.SelectedIndexChanged += new System.EventHandler(this.branch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Branch";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(889, 581);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loadButton.Location = new System.Drawing.Point(331, 75);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(114, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
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
            this.CarType.Name = "CarType";
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
            this.transmissionType2.Name = "transmissionType2";
            // 
            // seats2
            // 
            this.seats2.HeaderText = "Seats";
            this.seats2.Name = "seats2";
            // 
            // BranchID
            // 
            this.BranchID.HeaderText = "BranchID";
            this.BranchID.Name = "BranchID";
            // 
            // status2
            // 
            this.status2.HeaderText = "Status";
            this.status2.Name = "status2";
            // 
            // EmployeeCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 718);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeCars";
            this.Text = "EmployeeCars";
            this.tabControl1.ResumeLayout(false);
            this.EmployeeLOC.ResumeLayout(false);
            this.EmployeeLOC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCars)).EndInit();
            this.addForm.ResumeLayout(false);
            this.addForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EmployeeLOC;
        private System.Windows.Forms.GroupBox addForm;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox licensePlate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox branchName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
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
        private System.Windows.Forms.TextBox carClass;
        private System.Windows.Forms.TextBox make;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox currentMileage;
        private System.Windows.Forms.TextBox transmissionType;
        private System.Windows.Forms.TextBox seats;
        private System.Windows.Forms.TextBox ranc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn make2;
        private System.Windows.Forms.DataGridViewTextBoxColumn model2;
        private System.Windows.Forms.DataGridViewTextBoxColumn year2;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentMileage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn seats2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn status2;
    }
}