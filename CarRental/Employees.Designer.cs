
namespace CarRental
{
    partial class Employees
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
            this.empSearchButton = new System.Windows.Forms.Button();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empIDBox = new System.Windows.Forms.TextBox();
            this.postalBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.branchCombo = new System.Windows.Forms.ComboBox();
            this.empDataView = new System.Windows.Forms.DataGridView();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.Button();
            this.editEmployee = new System.Windows.Forms.GroupBox();
            this.editEmpIDBox = new System.Windows.Forms.TextBox();
            this.editPostalBox = new System.Windows.Forms.TextBox();
            this.editCityBox = new System.Windows.Forms.TextBox();
            this.editBranchCombo = new System.Windows.Forms.ComboBox();
            this.editLNameBox = new System.Windows.Forms.TextBox();
            this.editStreetBox = new System.Windows.Forms.TextBox();
            this.editFNameBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDataView)).BeginInit();
            this.editEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // empSearchButton
            // 
            this.empSearchButton.Location = new System.Drawing.Point(10, 139);
            this.empSearchButton.Name = "empSearchButton";
            this.empSearchButton.Size = new System.Drawing.Size(99, 23);
            this.empSearchButton.TabIndex = 1;
            this.empSearchButton.Text = "Search";
            this.empSearchButton.UseVisualStyleBackColor = true;
            this.empSearchButton.Click += new System.EventHandler(this.empSearchButton_Click);
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(8, 52);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(100, 23);
            this.streetBox.TabIndex = 2;
            this.streetBox.Text = "Street";
            this.streetBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fNameBox
            // 
            this.fNameBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.fNameBox.Location = new System.Drawing.Point(6, 22);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(100, 23);
            this.fNameBox.TabIndex = 3;
            this.fNameBox.Text = "First Name";
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(112, 22);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(100, 23);
            this.lNameBox.TabIndex = 4;
            this.lNameBox.Text = "Last Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empIDBox);
            this.groupBox1.Controls.Add(this.postalBox);
            this.groupBox1.Controls.Add(this.cityBox);
            this.groupBox1.Controls.Add(this.empSearchButton);
            this.groupBox1.Controls.Add(this.branchCombo);
            this.groupBox1.Controls.Add(this.lNameBox);
            this.groupBox1.Controls.Add(this.streetBox);
            this.groupBox1.Controls.Add(this.fNameBox);
            this.groupBox1.Location = new System.Drawing.Point(649, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Employee";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // empIDBox
            // 
            this.empIDBox.Location = new System.Drawing.Point(9, 110);
            this.empIDBox.Name = "empIDBox";
            this.empIDBox.Size = new System.Drawing.Size(100, 23);
            this.empIDBox.TabIndex = 8;
            this.empIDBox.Text = "Employee ID.";
            // 
            // postalBox
            // 
            this.postalBox.Location = new System.Drawing.Point(8, 81);
            this.postalBox.Name = "postalBox";
            this.postalBox.Size = new System.Drawing.Size(100, 23);
            this.postalBox.TabIndex = 7;
            this.postalBox.Text = "Postal Code";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(111, 51);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 23);
            this.cityBox.TabIndex = 6;
            this.cityBox.Text = "City";
            // 
            // branchCombo
            // 
            this.branchCombo.FormattingEnabled = true;
            this.branchCombo.Location = new System.Drawing.Point(110, 81);
            this.branchCombo.Name = "branchCombo";
            this.branchCombo.Size = new System.Drawing.Size(101, 23);
            this.branchCombo.TabIndex = 5;
            this.branchCombo.Text = "Branch No.";
            // 
            // empDataView
            // 
            this.empDataView.AllowUserToDeleteRows = false;
            this.empDataView.AllowUserToOrderColumns = true;
            this.empDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.branchID,
            this.fName,
            this.lName,
            this.Street,
            this.City,
            this.postalCode});
            this.empDataView.Location = new System.Drawing.Point(12, 35);
            this.empDataView.Name = "empDataView";
            this.empDataView.RowTemplate.Height = 25;
            this.empDataView.Size = new System.Drawing.Size(631, 514);
            this.empDataView.TabIndex = 6;
            this.empDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empDataView_CellContentClick);
            this.empDataView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.empDataView_RowHeaderMouseClick);
            // 
            // empID
            // 
            this.empID.HeaderText = "Employee ID";
            this.empID.Name = "empID";
            this.empID.ReadOnly = true;
            // 
            // branchID
            // 
            this.branchID.HeaderText = "Branch ID";
            this.branchID.Name = "branchID";
            // 
            // fName
            // 
            this.fName.HeaderText = "First Name";
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // lName
            // 
            this.lName.HeaderText = "Last Name";
            this.lName.Name = "lName";
            this.lName.ReadOnly = true;
            // 
            // Street
            // 
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // postalCode
            // 
            this.postalCode.HeaderText = "Postal Code";
            this.postalCode.Name = "postalCode";
            this.postalCode.ReadOnly = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(7, 139);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editEmployee
            // 
            this.editEmployee.Controls.Add(this.editEmpIDBox);
            this.editEmployee.Controls.Add(this.editPostalBox);
            this.editEmployee.Controls.Add(this.editButton);
            this.editEmployee.Controls.Add(this.editCityBox);
            this.editEmployee.Controls.Add(this.editBranchCombo);
            this.editEmployee.Controls.Add(this.editLNameBox);
            this.editEmployee.Controls.Add(this.editStreetBox);
            this.editEmployee.Controls.Add(this.editFNameBox);
            this.editEmployee.Location = new System.Drawing.Point(649, 378);
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(221, 171);
            this.editEmployee.TabIndex = 8;
            this.editEmployee.TabStop = false;
            this.editEmployee.Text = "Edit Selected Employee";
            // 
            // editEmpIDBox
            // 
            this.editEmpIDBox.Location = new System.Drawing.Point(6, 109);
            this.editEmpIDBox.Name = "editEmpIDBox";
            this.editEmpIDBox.ReadOnly = true;
            this.editEmpIDBox.Size = new System.Drawing.Size(100, 23);
            this.editEmpIDBox.TabIndex = 8;
            this.editEmpIDBox.Text = "Employee ID";
            // 
            // editPostalBox
            // 
            this.editPostalBox.Location = new System.Drawing.Point(6, 80);
            this.editPostalBox.Name = "editPostalBox";
            this.editPostalBox.Size = new System.Drawing.Size(100, 23);
            this.editPostalBox.TabIndex = 7;
            this.editPostalBox.Text = "Postal Code";
            // 
            // editCityBox
            // 
            this.editCityBox.Location = new System.Drawing.Point(110, 52);
            this.editCityBox.Name = "editCityBox";
            this.editCityBox.Size = new System.Drawing.Size(100, 23);
            this.editCityBox.TabIndex = 6;
            this.editCityBox.Text = "City";
            // 
            // editBranchCombo
            // 
            this.editBranchCombo.FormattingEnabled = true;
            this.editBranchCombo.Location = new System.Drawing.Point(110, 81);
            this.editBranchCombo.Name = "editBranchCombo";
            this.editBranchCombo.Size = new System.Drawing.Size(101, 23);
            this.editBranchCombo.TabIndex = 5;
            this.editBranchCombo.Text = "Branch No.";
            // 
            // editLNameBox
            // 
            this.editLNameBox.Location = new System.Drawing.Point(110, 22);
            this.editLNameBox.Name = "editLNameBox";
            this.editLNameBox.Size = new System.Drawing.Size(100, 23);
            this.editLNameBox.TabIndex = 4;
            this.editLNameBox.Text = "Last Name";
            // 
            // editStreetBox
            // 
            this.editStreetBox.Location = new System.Drawing.Point(6, 51);
            this.editStreetBox.Name = "editStreetBox";
            this.editStreetBox.Size = new System.Drawing.Size(100, 23);
            this.editStreetBox.TabIndex = 2;
            this.editStreetBox.Text = "Street";
            // 
            // editFNameBox
            // 
            this.editFNameBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.editFNameBox.Location = new System.Drawing.Point(6, 22);
            this.editFNameBox.Name = "editFNameBox";
            this.editFNameBox.Size = new System.Drawing.Size(100, 23);
            this.editFNameBox.TabIndex = 3;
            this.editFNameBox.Text = "First Name";
            this.editFNameBox.TextChanged += new System.EventHandler(this.editFNameBox_TextChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 561);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editEmployee);
            this.Controls.Add(this.empDataView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employees";
            this.Text = "Employees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDataView)).EndInit();
            this.editEmployee.ResumeLayout(false);
            this.editEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button empSearchButton;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox branchCombo;
        private System.Windows.Forms.DataGridView empDataView;
        private System.Windows.Forms.TextBox postalBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCode;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.GroupBox editEmployee;
        private System.Windows.Forms.TextBox editPostalBox;
        private System.Windows.Forms.TextBox editCityBox;
        private System.Windows.Forms.ComboBox editBranchCombo;
        private System.Windows.Forms.TextBox editLNameBox;
        private System.Windows.Forms.TextBox editStreetBox;
        private System.Windows.Forms.TextBox editFNameBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox empIDBox;
        private System.Windows.Forms.TextBox editEmpIDBox;
    }
}