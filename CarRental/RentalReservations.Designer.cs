
namespace CarRental
{
    partial class RentalReservations
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
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedCarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(29, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalID,
            this.customer,
            this.pickUpDate,
            this.expectedDate,
            this.returnDate,
            this.carDetails,
            this.carClass,
            this.expectedCarType,
            this.pickUpBranch,
            this.returnBranch,
            this.mileageUsed,
            this.estimatedCost,
            this.totalFee,
            this.employee});
            this.dataGridView1.Location = new System.Drawing.Point(29, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(998, 424);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // rentalID
            // 
            this.rentalID.HeaderText = "Rental ID";
            this.rentalID.Name = "rentalID";
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            // 
            // pickUpDate
            // 
            this.pickUpDate.HeaderText = "Pick-Up Date";
            this.pickUpDate.Name = "pickUpDate";
            // 
            // expectedDate
            // 
            this.expectedDate.HeaderText = "Expected Return Date";
            this.expectedDate.Name = "expectedDate";
            // 
            // returnDate
            // 
            this.returnDate.HeaderText = "Actual Return Date";
            this.returnDate.Name = "returnDate";
            // 
            // carDetails
            // 
            this.carDetails.HeaderText = "Car Details";
            this.carDetails.Name = "carDetails";
            // 
            // carClass
            // 
            this.carClass.HeaderText = "Car Type";
            this.carClass.Name = "carClass";
            // 
            // expectedCarType
            // 
            this.expectedCarType.HeaderText = "Expected Car Type";
            this.expectedCarType.Name = "expectedCarType";
            // 
            // pickUpBranch
            // 
            this.pickUpBranch.HeaderText = "Pick-Up Branch";
            this.pickUpBranch.Name = "pickUpBranch";
            // 
            // returnBranch
            // 
            this.returnBranch.HeaderText = "Return Branch";
            this.returnBranch.Name = "returnBranch";
            // 
            // mileageUsed
            // 
            this.mileageUsed.HeaderText = "Mileage Used";
            this.mileageUsed.Name = "mileageUsed";
            // 
            // estimatedCost
            // 
            this.estimatedCost.HeaderText = "Estimated Cost";
            this.estimatedCost.Name = "estimatedCost";
            // 
            // totalFee
            // 
            this.totalFee.HeaderText = "Total Fee";
            this.totalFee.Name = "totalFee";
            // 
            // employee
            // 
            this.employee.HeaderText = "Employee";
            this.employee.Name = "employee";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(172, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load Rental Reservations";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear Filters";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RentalReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Name = "RentalReservations";
            this.Text = "RentalReservations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn carDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn carClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedCarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}