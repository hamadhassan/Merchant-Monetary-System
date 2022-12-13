namespace Merchant_Monetary_System.Forms.Emails
{
    partial class frmEmail
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
            this.gbx = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cmbxSenstivity = new System.Windows.Forms.ComboBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lblS_Number = new System.Windows.Forms.Label();
            this.lblNameSignal = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cmbxManufacture = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.richTextBox1);
            this.gbx.Controls.Add(this.lblTo);
            this.gbx.Controls.Add(this.cmbxSenstivity);
            this.gbx.Controls.Add(this.lbl_Weight);
            this.gbx.Controls.Add(this.lblS_Number);
            this.gbx.Controls.Add(this.lblNameSignal);
            this.gbx.Controls.Add(this.txtbxName);
            this.gbx.Controls.Add(this.lblSubject);
            this.gbx.Controls.Add(this.lblFrom);
            this.gbx.Controls.Add(this.cmbxManufacture);
            this.gbx.Controls.Add(this.btnSend);
            this.gbx.Controls.Add(this.btnClear);
            this.gbx.Controls.Add(this.btnClose);
            this.gbx.Controls.Add(this.lblEmail);
            this.gbx.Location = new System.Drawing.Point(0, 0);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(868, 483);
            this.gbx.TabIndex = 2;
            this.gbx.TabStop = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTo.Location = new System.Drawing.Point(94, 66);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 20);
            this.lblTo.TabIndex = 34;
            this.lblTo.Text = "To :";
            // 
            // cmbxSenstivity
            // 
            this.cmbxSenstivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSenstivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxSenstivity.FormattingEnabled = true;
            this.cmbxSenstivity.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider"});
            this.cmbxSenstivity.Location = new System.Drawing.Point(531, 62);
            this.cmbxSenstivity.Name = "cmbxSenstivity";
            this.cmbxSenstivity.Size = new System.Drawing.Size(275, 21);
            this.cmbxSenstivity.Sorted = true;
            this.cmbxSenstivity.TabIndex = 38;
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lbl_Weight.Location = new System.Drawing.Point(219, 269);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(10, 13);
            this.lbl_Weight.TabIndex = 32;
            this.lbl_Weight.Text = " ";
            // 
            // lblS_Number
            // 
            this.lblS_Number.AutoSize = true;
            this.lblS_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblS_Number.Location = new System.Drawing.Point(219, 222);
            this.lblS_Number.Name = "lblS_Number";
            this.lblS_Number.Size = new System.Drawing.Size(10, 13);
            this.lblS_Number.TabIndex = 30;
            this.lblS_Number.Text = " ";
            // 
            // lblNameSignal
            // 
            this.lblNameSignal.AutoSize = true;
            this.lblNameSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblNameSignal.Location = new System.Drawing.Point(219, 170);
            this.lblNameSignal.Name = "lblNameSignal";
            this.lblNameSignal.Size = new System.Drawing.Size(10, 13);
            this.lblNameSignal.TabIndex = 28;
            this.lblNameSignal.Text = " ";
            // 
            // txtbxName
            // 
            this.txtbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbxName.Location = new System.Drawing.Point(135, 98);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(671, 26);
            this.txtbxName.TabIndex = 27;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubject.Location = new System.Drawing.Point(62, 98);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(67, 20);
            this.lblSubject.TabIndex = 23;
            this.lblSubject.Text = "Subject:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFrom.Location = new System.Drawing.Point(459, 63);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(50, 20);
            this.lblFrom.TabIndex = 35;
            this.lblFrom.Text = "From:";
            // 
            // cmbxManufacture
            // 
            this.cmbxManufacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxManufacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxManufacture.FormattingEnabled = true;
            this.cmbxManufacture.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider"});
            this.cmbxManufacture.Location = new System.Drawing.Point(135, 65);
            this.cmbxManufacture.Name = "cmbxManufacture";
            this.cmbxManufacture.Size = new System.Drawing.Size(287, 21);
            this.cmbxManufacture.Sorted = true;
            this.cmbxManufacture.TabIndex = 37;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(750, 421);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 30);
            this.btnSend.TabIndex = 42;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(632, 421);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 30);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(508, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 30);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(400, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 39);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(135, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(671, 285);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.gbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmail";
            this.Text = "frmEmail";
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cmbxSenstivity;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lblS_Number;
        private System.Windows.Forms.Label lblNameSignal;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cmbxManufacture;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}