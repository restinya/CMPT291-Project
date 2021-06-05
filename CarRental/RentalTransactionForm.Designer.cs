
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
            this.PickUpDate2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpectedDate2 = new System.Windows.Forms.ComboBox();
            this.RequestedClass2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Membership2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PickUpDate = new System.Windows.Forms.TextBox();
            this.ExpectedDate = new System.Windows.Forms.TextBox();
            this.RequestedClass = new System.Windows.Forms.TextBox();
            this.Membership = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick Up Date";
            // 
            // PickUpDate2
            // 
            this.PickUpDate2.FormattingEnabled = true;
            this.PickUpDate2.Location = new System.Drawing.Point(191, 38);
            this.PickUpDate2.Name = "PickUpDate2";
            this.PickUpDate2.Size = new System.Drawing.Size(121, 23);
            this.PickUpDate2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estimated Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expected Return Date";
            // 
            // ExpectedDate2
            // 
            this.ExpectedDate2.FormattingEnabled = true;
            this.ExpectedDate2.Location = new System.Drawing.Point(191, 91);
            this.ExpectedDate2.Name = "ExpectedDate2";
            this.ExpectedDate2.Size = new System.Drawing.Size(121, 23);
            this.ExpectedDate2.TabIndex = 4;
            // 
            // RequestedClass2
            // 
            this.RequestedClass2.FormattingEnabled = true;
            this.RequestedClass2.Location = new System.Drawing.Point(191, 147);
            this.RequestedClass2.Name = "RequestedClass2";
            this.RequestedClass2.Size = new System.Drawing.Size(121, 23);
            this.RequestedClass2.TabIndex = 6;
            this.RequestedClass2.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Requested Vehicle Class";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Membership2
            // 
            this.Membership2.FormattingEnabled = true;
            this.Membership2.Location = new System.Drawing.Point(191, 211);
            this.Membership2.Name = "Membership2";
            this.Membership2.Size = new System.Drawing.Size(121, 23);
            this.Membership2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Membership";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PickUpDate
            // 
            this.PickUpDate.Location = new System.Drawing.Point(13, 38);
            this.PickUpDate.Name = "PickUpDate";
            this.PickUpDate.Size = new System.Drawing.Size(119, 23);
            this.PickUpDate.TabIndex = 10;
            // 
            // ExpectedDate
            // 
            this.ExpectedDate.Location = new System.Drawing.Point(13, 92);
            this.ExpectedDate.Name = "ExpectedDate";
            this.ExpectedDate.Size = new System.Drawing.Size(119, 23);
            this.ExpectedDate.TabIndex = 11;
            // 
            // RequestedClass
            // 
            this.RequestedClass.Location = new System.Drawing.Point(13, 147);
            this.RequestedClass.Name = "RequestedClass";
            this.RequestedClass.Size = new System.Drawing.Size(119, 23);
            this.RequestedClass.TabIndex = 12;
            // 
            // Membership
            // 
            this.Membership.Location = new System.Drawing.Point(13, 211);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(119, 23);
            this.Membership.TabIndex = 13;
            // 
            // RentalTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 377);
            this.Controls.Add(this.Membership);
            this.Controls.Add(this.RequestedClass);
            this.Controls.Add(this.ExpectedDate);
            this.Controls.Add(this.PickUpDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Membership2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RequestedClass2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExpectedDate2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PickUpDate2);
            this.Controls.Add(this.label1);
            this.Name = "RentalTransactionForm";
            this.Text = "RentalTransactionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PickUpDate2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ExpectedDate2;
        private System.Windows.Forms.ComboBox RequestedClass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Membership2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PickUpDate;
        private System.Windows.Forms.TextBox ExpectedDate;
        private System.Windows.Forms.TextBox RequestedClass;
        private System.Windows.Forms.TextBox Membership;
    }
}