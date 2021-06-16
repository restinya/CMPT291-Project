
namespace CarRental
{
    partial class Reports
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.getReport = new System.Windows.Forms.Button();
            this.selectReport = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.queryData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.getReport);
            this.groupBox1.Controls.Add(this.selectReport);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(694, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // getReport
            // 
            this.getReport.Location = new System.Drawing.Point(6, 51);
            this.getReport.Name = "getReport";
            this.getReport.Size = new System.Drawing.Size(75, 23);
            this.getReport.TabIndex = 4;
            this.getReport.Text = "Get Report";
            this.getReport.UseVisualStyleBackColor = true;
            this.getReport.Click += new System.EventHandler(this.getReport_Click);
            // 
            // selectReport
            // 
            this.selectReport.FormattingEnabled = true;
            this.selectReport.Location = new System.Drawing.Point(6, 22);
            this.selectReport.Name = "selectReport";
            this.selectReport.Size = new System.Drawing.Size(385, 23);
            this.selectReport.TabIndex = 1;
            this.selectReport.Text = "Select Report";
            this.selectReport.SelectedIndexChanged += new System.EventHandler(this.selectReport_SelectedIndexChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // queryData
            // 
            this.queryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.queryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryData.Location = new System.Drawing.Point(13, 105);
            this.queryData.Name = "queryData";
            this.queryData.ReadOnly = true;
            this.queryData.RowTemplate.Height = 25;
            this.queryData.Size = new System.Drawing.Size(769, 333);
            this.queryData.TabIndex = 1;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reports";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getReport;
        private System.Windows.Forms.ComboBox selectReport;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView queryData;
    }
}