﻿
namespace CarRental
{
    partial class Selection
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
            this.step1Label = new System.Windows.Forms.Label();
            this.pickupLocLabel = new System.Windows.Forms.Label();
            this.pickupDateLabel = new System.Windows.Forms.Label();
            this.findARentalLabel = new System.Windows.Forms.Label();
            this.step2Label = new System.Windows.Forms.Label();
            this.step3Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pickupLocation = new System.Windows.Forms.ComboBox();
            this.returnCheckbox = new System.Windows.Forms.CheckBox();
            this.returnLocation = new System.Windows.Forms.ComboBox();
            this.returnLocLabel = new System.Windows.Forms.Label();
            this.pickupDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.vehicleClass = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // step1Label
            // 
            this.step1Label.AutoSize = true;
            this.step1Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step1Label.Location = new System.Drawing.Point(37, 80);
            this.step1Label.Name = "step1Label";
            this.step1Label.Size = new System.Drawing.Size(54, 21);
            this.step1Label.TabIndex = 0;
            this.step1Label.Text = "Step 1";
            // 
            // pickupLocLabel
            // 
            this.pickupLocLabel.AutoSize = true;
            this.pickupLocLabel.Location = new System.Drawing.Point(52, 108);
            this.pickupLocLabel.Name = "pickupLocLabel";
            this.pickupLocLabel.Size = new System.Drawing.Size(144, 15);
            this.pickupLocLabel.TabIndex = 1;
            this.pickupLocLabel.Text = "Pick-Up / Return Location";
            // 
            // pickupDateLabel
            // 
            this.pickupDateLabel.AutoSize = true;
            this.pickupDateLabel.Location = new System.Drawing.Point(52, 224);
            this.pickupDateLabel.Name = "pickupDateLabel";
            this.pickupDateLabel.Size = new System.Drawing.Size(76, 15);
            this.pickupDateLabel.TabIndex = 2;
            this.pickupDateLabel.Text = "Pick-Up Date";
            this.pickupDateLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // findARentalLabel
            // 
            this.findARentalLabel.AutoSize = true;
            this.findARentalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findARentalLabel.Location = new System.Drawing.Point(30, 29);
            this.findARentalLabel.Name = "findARentalLabel";
            this.findARentalLabel.Size = new System.Drawing.Size(127, 25);
            this.findARentalLabel.TabIndex = 3;
            this.findARentalLabel.Text = "Find a Rental";
            // 
            // step2Label
            // 
            this.step2Label.AutoSize = true;
            this.step2Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step2Label.Location = new System.Drawing.Point(37, 194);
            this.step2Label.Name = "step2Label";
            this.step2Label.Size = new System.Drawing.Size(57, 21);
            this.step2Label.TabIndex = 4;
            this.step2Label.Text = "Step 2";
            this.step2Label.Click += new System.EventHandler(this.label5_Click);
            // 
            // step3Label
            // 
            this.step3Label.AutoSize = true;
            this.step3Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step3Label.Location = new System.Drawing.Point(37, 295);
            this.step3Label.Name = "step3Label";
            this.step3Label.Size = new System.Drawing.Size(57, 21);
            this.step3Label.TabIndex = 6;
            this.step3Label.Text = "Step 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Vehicle Class";
            // 
            // pickupLocation
            // 
            this.pickupLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.pickupLocation.FormattingEnabled = true;
            this.pickupLocation.Items.AddRange(new object[] {
            "Edmonton",
            "Calgary",
            "Saskatoon",
            "Vancouver"});
            this.pickupLocation.Location = new System.Drawing.Point(54, 126);
            this.pickupLocation.Name = "pickupLocation";
            this.pickupLocation.Size = new System.Drawing.Size(121, 23);
            this.pickupLocation.TabIndex = 7;
            // 
            // returnCheckbox
            // 
            this.returnCheckbox.AutoSize = true;
            this.returnCheckbox.Location = new System.Drawing.Point(54, 155);
            this.returnCheckbox.Name = "returnCheckbox";
            this.returnCheckbox.Size = new System.Drawing.Size(178, 19);
            this.returnCheckbox.TabIndex = 8;
            this.returnCheckbox.Text = "Return to a different location";
            this.returnCheckbox.UseVisualStyleBackColor = true;
            this.returnCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // returnLocation
            // 
            this.returnLocation.FormattingEnabled = true;
            this.returnLocation.Items.AddRange(new object[] {
            "Edmonton",
            "Calgary",
            "Saskatoon",
            "Vancouver"});
            this.returnLocation.Location = new System.Drawing.Point(257, 126);
            this.returnLocation.Name = "returnLocation";
            this.returnLocation.Size = new System.Drawing.Size(121, 23);
            this.returnLocation.TabIndex = 9;
            this.returnLocation.Visible = false;
            // 
            // returnLocLabel
            // 
            this.returnLocLabel.AutoSize = true;
            this.returnLocLabel.Location = new System.Drawing.Point(255, 108);
            this.returnLocLabel.Name = "returnLocLabel";
            this.returnLocLabel.Size = new System.Drawing.Size(91, 15);
            this.returnLocLabel.TabIndex = 10;
            this.returnLocLabel.Text = "Return Location";
            this.returnLocLabel.Visible = false;
            // 
            // pickupDate
            // 
            this.pickupDate.Location = new System.Drawing.Point(54, 242);
            this.pickupDate.Name = "pickupDate";
            this.pickupDate.Size = new System.Drawing.Size(121, 23);
            this.pickupDate.TabIndex = 11;
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(257, 242);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(121, 23);
            this.returnDate.TabIndex = 13;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Location = new System.Drawing.Point(255, 224);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(69, 15);
            this.returnDateLabel.TabIndex = 12;
            this.returnDateLabel.Text = "Return Date";
            // 
            // vehicleClass
            // 
            this.vehicleClass.FormattingEnabled = true;
            this.vehicleClass.Items.AddRange(new object[] {
            "Cars",
            "SUVs",
            "Vans",
            "Pickups"});
            this.vehicleClass.Location = new System.Drawing.Point(54, 345);
            this.vehicleClass.Name = "vehicleClass";
            this.vehicleClass.Size = new System.Drawing.Size(121, 23);
            this.vehicleClass.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Check Availability";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vehicleClass);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.pickupDate);
            this.Controls.Add(this.returnLocLabel);
            this.Controls.Add(this.returnLocation);
            this.Controls.Add(this.returnCheckbox);
            this.Controls.Add(this.pickupLocation);
            this.Controls.Add(this.step3Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.step2Label);
            this.Controls.Add(this.findARentalLabel);
            this.Controls.Add(this.pickupDateLabel);
            this.Controls.Add(this.pickupLocLabel);
            this.Controls.Add(this.step1Label);
            this.Name = "Selection";
            this.Text = "Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label step1Label;
        private System.Windows.Forms.Label pickupLocLabel;
        private System.Windows.Forms.Label pickupDateLabel;
        private System.Windows.Forms.Label findARentalLabel;
        private System.Windows.Forms.Label step2Label;
        private System.Windows.Forms.Label step3Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox pickupLocation;
        private System.Windows.Forms.CheckBox returnCheckbox;
        private System.Windows.Forms.ComboBox returnLocation;
        private System.Windows.Forms.Label returnLocLabel;
        private System.Windows.Forms.DateTimePicker pickupDate;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.ComboBox vehicleClass;
        private System.Windows.Forms.Button button1;
    }
}