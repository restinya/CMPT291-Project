
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AvailabilityCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CarTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AvailabilityCol,
            this.CarTypeCol,
            this.MakeCol,
            this.ModelCol,
            this.YearCol,
            this.DailyPriceCol,
            this.MonthlyPriceCol});
            this.dataGridView1.Location = new System.Drawing.Point(26, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(743, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AvailabilityCol
            // 
            this.AvailabilityCol.HeaderText = "Availability";
            this.AvailabilityCol.Name = "AvailabilityCol";
            // 
            // CarTypeCol
            // 
            this.CarTypeCol.HeaderText = "Car Type";
            this.CarTypeCol.Name = "CarTypeCol";
            // 
            // MakeCol
            // 
            this.MakeCol.HeaderText = "Make";
            this.MakeCol.Name = "MakeCol";
            // 
            // ModelCol
            // 
            this.ModelCol.HeaderText = "Model";
            this.ModelCol.Name = "ModelCol";
            // 
            // YearCol
            // 
            this.YearCol.HeaderText = "Year";
            this.YearCol.Name = "YearCol";
            // 
            // DailyPriceCol
            // 
            this.DailyPriceCol.HeaderText = "Daily Price";
            this.DailyPriceCol.Name = "DailyPriceCol";
            // 
            // MonthlyPriceCol
            // 
            this.MonthlyPriceCol.HeaderText = "Monthly Price";
            this.MonthlyPriceCol.Name = "MonthlyPriceCol";
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
            this.pickupLocation.Size = new System.Drawing.Size(38, 15);
            this.pickupLocation.TabIndex = 4;
            this.pickupLocation.Text = "label1";
            // 
            // returnLocation
            // 
            this.returnLocation.AutoSize = true;
            this.returnLocation.Location = new System.Drawing.Point(134, 86);
            this.returnLocation.Name = "returnLocation";
            this.returnLocation.Size = new System.Drawing.Size(38, 15);
            this.returnLocation.TabIndex = 5;
            this.returnLocation.Text = "label2";
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
            this.pickupDate.Size = new System.Drawing.Size(38, 15);
            this.pickupDate.TabIndex = 8;
            this.pickupDate.Text = "label5";
            // 
            // returnDate
            // 
            this.returnDate.AutoSize = true;
            this.returnDate.Location = new System.Drawing.Point(360, 85);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(38, 15);
            this.returnDate.TabIndex = 9;
            this.returnDate.Text = "label6";
            // 
            // classType
            // 
            this.classType.AutoSize = true;
            this.classType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classType.Location = new System.Drawing.Point(26, 114);
            this.classType.Name = "classType";
            this.classType.Size = new System.Drawing.Size(71, 20);
            this.classType.TabIndex = 10;
            this.classType.Text = "classType";
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
            this.submitButton.Location = new System.Drawing.Point(26, 536);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(92, 32);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 599);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "CarList";
            this.Text = "CarList";
            this.Load += new System.EventHandler(this.CarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AvailabilityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyPriceCol;
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
    }
}