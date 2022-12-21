namespace Merchant_Monetary_System.Reports
{
    partial class frmViewReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewReports));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblViewReports = new System.Windows.Forms.Label();
            this.btnGenrate = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cmbxChoose = new System.Windows.Forms.ComboBox();
            this.cmbxRelatedtoChoose = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmbxRelatedtoChoose);
            this.groupBox1.Controls.Add(this.cmbxChoose);
            this.groupBox1.Controls.Add(this.btnGenrate);
            this.groupBox1.Controls.Add(this.lblViewReports);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblViewReports
            // 
            this.lblViewReports.AutoSize = true;
            this.lblViewReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewReports.Location = new System.Drawing.Point(359, 67);
            this.lblViewReports.Name = "lblViewReports";
            this.lblViewReports.Size = new System.Drawing.Size(232, 39);
            this.lblViewReports.TabIndex = 22;
            this.lblViewReports.Text = "View Reports";
            // 
            // btnGenrate
            // 
            this.btnGenrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnGenrate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenrate.ForeColor = System.Drawing.Color.White;
            this.btnGenrate.Location = new System.Drawing.Point(377, 364);
            this.btnGenrate.Name = "btnGenrate";
            this.btnGenrate.Size = new System.Drawing.Size(200, 30);
            this.btnGenrate.TabIndex = 42;
            this.btnGenrate.Text = "Generate";
            this.btnGenrate.UseVisualStyleBackColor = false;
            this.btnGenrate.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cmbxChoose
            // 
            this.cmbxChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxChoose.FormattingEnabled = true;
            this.cmbxChoose.Location = new System.Drawing.Point(339, 208);
            this.cmbxChoose.Name = "cmbxChoose";
            this.cmbxChoose.Size = new System.Drawing.Size(271, 28);
            this.cmbxChoose.Sorted = true;
            this.cmbxChoose.TabIndex = 44;
            this.cmbxChoose.SelectedIndexChanged += new System.EventHandler(this.cmbxChoose_SelectedIndexChanged);
            // 
            // cmbxRelatedtoChoose
            // 
            this.cmbxRelatedtoChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRelatedtoChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxRelatedtoChoose.FormattingEnabled = true;
            this.cmbxRelatedtoChoose.Location = new System.Drawing.Point(339, 256);
            this.cmbxRelatedtoChoose.Name = "cmbxRelatedtoChoose";
            this.cmbxRelatedtoChoose.Size = new System.Drawing.Size(271, 28);
            this.cmbxRelatedtoChoose.Sorted = true;
            this.cmbxRelatedtoChoose.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(339, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 26);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Select";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ledger",
            "Stock"});
            this.comboBox1.Location = new System.Drawing.Point(339, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewReport";
            this.Text = "ViewReport";
            this.Load += new System.EventHandler(this.ViewReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblViewReports;
        private System.Windows.Forms.Button btnGenrate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox cmbxRelatedtoChoose;
        private System.Windows.Forms.ComboBox cmbxChoose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}