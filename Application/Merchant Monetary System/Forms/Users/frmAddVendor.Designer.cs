﻿namespace Merchant_Monetary_System.Forms.Users
{
    partial class frmAddVendor
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
            this.lblAddressSignal = new System.Windows.Forms.Label();
            this.lblContactNumberSignal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblAddVendor = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxContactNumber = new System.Windows.Forms.TextBox();
            this.rtxtbxAddress = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblConcernedPerson = new System.Windows.Forms.Label();
            this.lblLandline = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.lblConcernedPerson);
            this.groupBox1.Controls.Add(this.lblLandline);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblAddressSignal);
            this.groupBox1.Controls.Add(this.lblContactNumberSignal);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblVendorName);
            this.groupBox1.Controls.Add(this.lblContactNumber);
            this.groupBox1.Controls.Add(this.lblAddVendor);
            this.groupBox1.Location = new System.Drawing.Point(-9, -22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 516);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lblAddressSignal
            // 
            this.lblAddressSignal.AutoSize = true;
            this.lblAddressSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblAddressSignal.Location = new System.Drawing.Point(211, 253);
            this.lblAddressSignal.Name = "lblAddressSignal";
            this.lblAddressSignal.Size = new System.Drawing.Size(10, 13);
            this.lblAddressSignal.TabIndex = 20;
            this.lblAddressSignal.Text = " ";
            // 
            // lblContactNumberSignal
            // 
            this.lblContactNumberSignal.AutoSize = true;
            this.lblContactNumberSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblContactNumberSignal.Location = new System.Drawing.Point(610, 153);
            this.lblContactNumberSignal.Name = "lblContactNumberSignal";
            this.lblContactNumberSignal.Size = new System.Drawing.Size(10, 13);
            this.lblContactNumberSignal.TabIndex = 18;
            this.lblContactNumberSignal.Text = " ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(574, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(364, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(148, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorName.Location = new System.Drawing.Point(128, 170);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(111, 20);
            this.lblVendorName.TabIndex = 4;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(464, 239);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(129, 20);
            this.lblContactNumber.TabIndex = 9;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblAddVendor
            // 
            this.lblAddVendor.AutoSize = true;
            this.lblAddVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVendor.Location = new System.Drawing.Point(345, 56);
            this.lblAddVendor.Name = "lblAddVendor";
            this.lblAddVendor.Size = new System.Drawing.Size(207, 39);
            this.lblAddVendor.TabIndex = 1;
            this.lblAddVendor.Text = "Add Vendor";
            this.lblAddVendor.Click += new System.EventHandler(this.lblAddCompany_Click);
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(202, 103);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(203, 20);
            this.txtbxName.TabIndex = 18;
            // 
            // txtbxContactNumber
            // 
            this.txtbxContactNumber.Location = new System.Drawing.Point(601, 103);
            this.txtbxContactNumber.Name = "txtbxContactNumber";
            this.txtbxContactNumber.Size = new System.Drawing.Size(203, 20);
            this.txtbxContactNumber.TabIndex = 19;
            this.txtbxContactNumber.Text = " ";
            // 
            // rtxtbxAddress
            // 
            this.rtxtbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtbxAddress.Location = new System.Drawing.Point(202, 150);
            this.rtxtbxAddress.Name = "rtxtbxAddress";
            this.rtxtbxAddress.Size = new System.Drawing.Size(602, 78);
            this.rtxtbxAddress.TabIndex = 20;
            this.rtxtbxAddress.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(603, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = " ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(246, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 26);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(603, 236);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 26);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = " ";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(246, 235);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 26);
            this.textBox4.TabIndex = 25;
            // 
            // lblConcernedPerson
            // 
            this.lblConcernedPerson.AutoSize = true;
            this.lblConcernedPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcernedPerson.Location = new System.Drawing.Point(95, 237);
            this.lblConcernedPerson.Name = "lblConcernedPerson";
            this.lblConcernedPerson.Size = new System.Drawing.Size(145, 20);
            this.lblConcernedPerson.TabIndex = 23;
            this.lblConcernedPerson.Text = "Concerned Person:";
            // 
            // lblLandline
            // 
            this.lblLandline.AutoSize = true;
            this.lblLandline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandline.Location = new System.Drawing.Point(462, 170);
            this.lblLandline.Name = "lblLandline";
            this.lblLandline.Size = new System.Drawing.Size(137, 20);
            this.lblLandline.TabIndex = 24;
            this.lblLandline.Text = "Landline Number: ";
            // 
            // frmAddVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.txtbxContactNumber);
            this.Controls.Add(this.rtxtbxAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddVendor";
            this.Text = "frmAddVendor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddressSignal;
        private System.Windows.Forms.Label lblContactNumberSignal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblAddVendor;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxContactNumber;
        private System.Windows.Forms.RichTextBox rtxtbxAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblConcernedPerson;
        private System.Windows.Forms.Label lblLandline;
    }
}