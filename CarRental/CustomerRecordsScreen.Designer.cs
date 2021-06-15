
namespace CarRental
{
    partial class CustomerRecordsScreen
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
            this.customerForm = new System.Windows.Forms.GroupBox();
            this.cusText = new System.Windows.Forms.Label();
            this.submitForm = new System.Windows.Forms.Button();
            this.cusID = new System.Windows.Forms.Label();
            this.goldCheck = new System.Windows.Forms.CheckBox();
            this.dateOfBirthBox = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.customerRecords = new System.Windows.Forms.DataGridView();
            this.cusIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goldMemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateCus = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Label();
            this.homeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneRecords = new System.Windows.Forms.DataGridView();
            this.phoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatePhone = new System.Windows.Forms.Button();
            this.addPhone = new System.Windows.Forms.Button();
            this.phoneNumBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.submitPhone = new System.Windows.Forms.Button();
            this.phoneForm = new System.Windows.Forms.GroupBox();
            this.oldNumber = new System.Windows.Forms.Label();
            this.oldLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.customerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneRecords)).BeginInit();
            this.phoneForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerForm
            // 
            this.customerForm.Controls.Add(this.cusText);
            this.customerForm.Controls.Add(this.submitForm);
            this.customerForm.Controls.Add(this.cusID);
            this.customerForm.Controls.Add(this.goldCheck);
            this.customerForm.Controls.Add(this.dateOfBirthBox);
            this.customerForm.Controls.Add(this.label7);
            this.customerForm.Controls.Add(this.label17);
            this.customerForm.Controls.Add(this.postalCodeBox);
            this.customerForm.Controls.Add(this.label16);
            this.customerForm.Controls.Add(this.stateBox);
            this.customerForm.Controls.Add(this.label15);
            this.customerForm.Controls.Add(this.cityBox);
            this.customerForm.Controls.Add(this.label14);
            this.customerForm.Controls.Add(this.streetBox);
            this.customerForm.Controls.Add(this.label13);
            this.customerForm.Controls.Add(this.label12);
            this.customerForm.Controls.Add(this.label11);
            this.customerForm.Controls.Add(this.lNameBox);
            this.customerForm.Controls.Add(this.label10);
            this.customerForm.Controls.Add(this.fNameBox);
            this.customerForm.Location = new System.Drawing.Point(446, 0);
            this.customerForm.Name = "customerForm";
            this.customerForm.Size = new System.Drawing.Size(495, 413);
            this.customerForm.TabIndex = 37;
            this.customerForm.TabStop = false;
            this.customerForm.Visible = false;
            // 
            // cusText
            // 
            this.cusText.AutoSize = true;
            this.cusText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cusText.Location = new System.Drawing.Point(239, 19);
            this.cusText.Name = "cusText";
            this.cusText.Size = new System.Drawing.Size(97, 20);
            this.cusText.TabIndex = 61;
            this.cusText.Text = "Customer ID:";
            this.cusText.Visible = false;
            // 
            // submitForm
            // 
            this.submitForm.Location = new System.Drawing.Point(23, 359);
            this.submitForm.Name = "submitForm";
            this.submitForm.Size = new System.Drawing.Size(75, 23);
            this.submitForm.TabIndex = 59;
            this.submitForm.Text = "Submit";
            this.submitForm.UseVisualStyleBackColor = true;
            this.submitForm.Visible = false;
            this.submitForm.Click += new System.EventHandler(this.submitForm_Click);
            // 
            // cusID
            // 
            this.cusID.AutoSize = true;
            this.cusID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cusID.Location = new System.Drawing.Point(342, 19);
            this.cusID.Name = "cusID";
            this.cusID.Size = new System.Drawing.Size(46, 20);
            this.cusID.TabIndex = 58;
            this.cusID.Text = "cusID";
            this.cusID.Visible = false;
            this.cusID.Click += new System.EventHandler(this.cusID_Click);
            // 
            // goldCheck
            // 
            this.goldCheck.AutoSize = true;
            this.goldCheck.Location = new System.Drawing.Point(237, 324);
            this.goldCheck.Name = "goldCheck";
            this.goldCheck.Size = new System.Drawing.Size(99, 19);
            this.goldCheck.TabIndex = 56;
            this.goldCheck.Text = "Gold Member";
            this.goldCheck.UseVisualStyleBackColor = true;
            this.goldCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateOfBirthBox
            // 
            this.dateOfBirthBox.CustomFormat = "";
            this.dateOfBirthBox.Location = new System.Drawing.Point(23, 321);
            this.dateOfBirthBox.Name = "dateOfBirthBox";
            this.dateOfBirthBox.Size = new System.Drawing.Size(200, 23);
            this.dateOfBirthBox.TabIndex = 54;
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 265);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "Postal Code";
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Location = new System.Drawing.Point(23, 239);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(397, 23);
            this.postalCodeBox.TabIndex = 46;
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
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(237, 185);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(198, 23);
            this.stateBox.TabIndex = 44;
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
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(23, 185);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(198, 23);
            this.cityBox.TabIndex = 42;
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
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(23, 131);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(397, 23);
            this.streetBox.TabIndex = 40;
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
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(237, 48);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(198, 23);
            this.lNameBox.TabIndex = 36;
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
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(23, 48);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(198, 23);
            this.fNameBox.TabIndex = 34;
            // 
            // customerRecords
            // 
            this.customerRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusIdCol,
            this.fNameCol,
            this.lNameCol,
            this.goldMemCol,
            this.cityCol,
            this.stateCol,
            this.streetCol,
            this.postalCodeCol,
            this.DobCol});
            this.customerRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.customerRecords.Location = new System.Drawing.Point(-3, 0);
            this.customerRecords.Name = "customerRecords";
            this.customerRecords.ReadOnly = true;
            this.customerRecords.RowTemplate.Height = 25;
            this.customerRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerRecords.Size = new System.Drawing.Size(443, 413);
            this.customerRecords.TabIndex = 48;
            this.customerRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerRecords_CellContentClick);
            this.customerRecords.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerRecords_RowEnter);
            // 
            // cusIdCol
            // 
            this.cusIdCol.HeaderText = "customerID";
            this.cusIdCol.Name = "cusIdCol";
            this.cusIdCol.ReadOnly = true;
            // 
            // fNameCol
            // 
            this.fNameCol.HeaderText = "fName";
            this.fNameCol.Name = "fNameCol";
            this.fNameCol.ReadOnly = true;
            // 
            // lNameCol
            // 
            this.lNameCol.HeaderText = "lName";
            this.lNameCol.Name = "lNameCol";
            this.lNameCol.ReadOnly = true;
            // 
            // goldMemCol
            // 
            this.goldMemCol.HeaderText = "goldMember";
            this.goldMemCol.Name = "goldMemCol";
            this.goldMemCol.ReadOnly = true;
            // 
            // cityCol
            // 
            this.cityCol.HeaderText = "City";
            this.cityCol.Name = "cityCol";
            this.cityCol.ReadOnly = true;
            // 
            // stateCol
            // 
            this.stateCol.HeaderText = "State";
            this.stateCol.Name = "stateCol";
            this.stateCol.ReadOnly = true;
            // 
            // streetCol
            // 
            this.streetCol.HeaderText = "Street";
            this.streetCol.Name = "streetCol";
            this.streetCol.ReadOnly = true;
            // 
            // postalCodeCol
            // 
            this.postalCodeCol.HeaderText = "Postal Code";
            this.postalCodeCol.Name = "postalCodeCol";
            this.postalCodeCol.ReadOnly = true;
            // 
            // DobCol
            // 
            this.DobCol.HeaderText = "DateOfBirth";
            this.DobCol.Name = "DobCol";
            this.DobCol.ReadOnly = true;
            // 
            // updateCus
            // 
            this.updateCus.Location = new System.Drawing.Point(6, 419);
            this.updateCus.Name = "updateCus";
            this.updateCus.Size = new System.Drawing.Size(156, 27);
            this.updateCus.TabIndex = 58;
            this.updateCus.Text = "Update Selected Customer";
            this.updateCus.UseVisualStyleBackColor = true;
            this.updateCus.Click += new System.EventHandler(this.updateCus_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(168, 419);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(101, 27);
            this.addCustomer.TabIndex = 59;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm.Location = new System.Drawing.Point(526, 458);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(0, 22);
            this.confirm.TabIndex = 60;
            // 
            // homeNum
            // 
            this.homeNum.HeaderText = "Home Number";
            this.homeNum.Name = "homeNum";
            this.homeNum.ReadOnly = true;
            // 
            // phoneRecords
            // 
            this.phoneRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNum});
            this.phoneRecords.Location = new System.Drawing.Point(-3, 458);
            this.phoneRecords.Name = "phoneRecords";
            this.phoneRecords.RowTemplate.Height = 25;
            this.phoneRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phoneRecords.Size = new System.Drawing.Size(443, 308);
            this.phoneRecords.TabIndex = 61;
            this.phoneRecords.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.phoneRecords_RowEnter);
            // 
            // phoneNum
            // 
            this.phoneNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNum.HeaderText = "Phone Number(s)";
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.ReadOnly = true;
            // 
            // updatePhone
            // 
            this.updatePhone.Location = new System.Drawing.Point(6, 772);
            this.updatePhone.Name = "updatePhone";
            this.updatePhone.Size = new System.Drawing.Size(156, 23);
            this.updatePhone.TabIndex = 62;
            this.updatePhone.Text = "Update Phone Number";
            this.updatePhone.UseVisualStyleBackColor = true;
            this.updatePhone.Click += new System.EventHandler(this.updatePhone_Click);
            // 
            // addPhone
            // 
            this.addPhone.Location = new System.Drawing.Point(168, 772);
            this.addPhone.Name = "addPhone";
            this.addPhone.Size = new System.Drawing.Size(101, 23);
            this.addPhone.TabIndex = 63;
            this.addPhone.Text = "Add Phone";
            this.addPhone.UseVisualStyleBackColor = true;
            this.addPhone.Click += new System.EventHandler(this.addPhone_Click);
            // 
            // phoneNumBox
            // 
            this.phoneNumBox.Location = new System.Drawing.Point(25, 113);
            this.phoneNumBox.Name = "phoneNumBox";
            this.phoneNumBox.Size = new System.Drawing.Size(198, 23);
            this.phoneNumBox.TabIndex = 34;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(25, 80);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(114, 20);
            this.phoneLabel.TabIndex = 35;
            this.phoneLabel.Text = "Phone Number";
            // 
            // submitPhone
            // 
            this.submitPhone.Location = new System.Drawing.Point(23, 142);
            this.submitPhone.Name = "submitPhone";
            this.submitPhone.Size = new System.Drawing.Size(75, 23);
            this.submitPhone.TabIndex = 59;
            this.submitPhone.Text = "Submit";
            this.submitPhone.UseVisualStyleBackColor = true;
            this.submitPhone.Visible = false;
            this.submitPhone.Click += new System.EventHandler(this.submitPhone_Click);
            // 
            // phoneForm
            // 
            this.phoneForm.Controls.Add(this.oldNumber);
            this.phoneForm.Controls.Add(this.oldLabel);
            this.phoneForm.Controls.Add(this.submitPhone);
            this.phoneForm.Controls.Add(this.phoneLabel);
            this.phoneForm.Controls.Add(this.phoneNumBox);
            this.phoneForm.Location = new System.Drawing.Point(446, 583);
            this.phoneForm.Name = "phoneForm";
            this.phoneForm.Size = new System.Drawing.Size(452, 183);
            this.phoneForm.TabIndex = 64;
            this.phoneForm.TabStop = false;
            this.phoneForm.Visible = false;
            this.phoneForm.Enter += new System.EventHandler(this.phoneForm_Enter);
            // 
            // oldNumber
            // 
            this.oldNumber.AutoSize = true;
            this.oldNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oldNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.oldNumber.Location = new System.Drawing.Point(25, 49);
            this.oldNumber.Name = "oldNumber";
            this.oldNumber.Size = new System.Drawing.Size(89, 20);
            this.oldNumber.TabIndex = 61;
            this.oldNumber.Text = "0000000000";
            // 
            // oldLabel
            // 
            this.oldLabel.AutoSize = true;
            this.oldLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oldLabel.Location = new System.Drawing.Point(25, 19);
            this.oldLabel.Name = "oldLabel";
            this.oldLabel.Size = new System.Drawing.Size(94, 20);
            this.oldLabel.TabIndex = 60;
            this.oldLabel.Text = "Old Number";
            this.oldLabel.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(851, 772);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 65;
            this.backBtn.Text = "Go Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerRecordsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 797);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.phoneForm);
            this.Controls.Add(this.addPhone);
            this.Controls.Add(this.updatePhone);
            this.Controls.Add(this.phoneRecords);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.updateCus);
            this.Controls.Add(this.customerRecords);
            this.Controls.Add(this.customerForm);
            this.Name = "CustomerRecordsScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CustomerRecordsScreen_Load);
            this.customerForm.ResumeLayout(false);
            this.customerForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneRecords)).EndInit();
            this.phoneForm.ResumeLayout(false);
            this.phoneForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox customerForm;
        private System.Windows.Forms.DateTimePicker dateOfBirthBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.CheckBox goldCheck;
        private System.Windows.Forms.DataGridView customerRecords;
        private System.Windows.Forms.Button updateCus;
        private System.Windows.Forms.Label cusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn goldMemCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DobCol;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button submitForm;
        private System.Windows.Forms.Label cusText;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeNum;
        private System.Windows.Forms.DataGridView phoneRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNum;
        private System.Windows.Forms.Button updatePhone;
        private System.Windows.Forms.Button addPhone;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button submitPhone;
        private System.Windows.Forms.GroupBox phoneForm;
        private System.Windows.Forms.Label oldNumber;
        private System.Windows.Forms.Label oldLabel;
        private System.Windows.Forms.Button backBtn;
    }
}