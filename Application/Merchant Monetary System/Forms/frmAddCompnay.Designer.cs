namespace Merchant_Monetary_System
{
    partial class frmAddCompnay
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
            this.lblAddCompany = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.rtxtbxAddress = new System.Windows.Forms.RichTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContactNumberSignal = new System.Windows.Forms.Label();
            this.lblNameSignal = new System.Windows.Forms.Label();
            this.lblAddressSignal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddCompany
            // 
            this.lblAddCompany.AutoSize = true;
            this.lblAddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCompany.Location = new System.Drawing.Point(331, 22);
            this.lblAddCompany.Name = "lblAddCompany";
            this.lblAddCompany.Size = new System.Drawing.Size(244, 39);
            this.lblAddCompany.TabIndex = 1;
            this.lblAddCompany.Text = "Add Company";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(223, 137);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(203, 26);
            this.txtbxName.TabIndex = 0;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(82, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name :";
            // 
            // txtbxContactNumber
            // 
            this.txtbxContactNumber.Location = new System.Drawing.Point(622, 137);
            this.txtbxContactNumber.Name = "txtbxContactNumber";
            this.txtbxContactNumber.Size = new System.Drawing.Size(203, 26);
            this.txtbxContactNumber.TabIndex = 1;
            this.txtbxContactNumber.Text = " ";
            this.txtbxContactNumber.TextChanged += new System.EventHandler(this.txtbxContactNumber_TextChanged);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(459, 131);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(133, 20);
            this.lblContactNumber.TabIndex = 9;
            this.lblContactNumber.Text = "Conatct Number :";
            // 
            // rtxtbxAddress
            // 
            this.rtxtbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtbxAddress.Location = new System.Drawing.Point(223, 184);
            this.rtxtbxAddress.Name = "rtxtbxAddress";
            this.rtxtbxAddress.Size = new System.Drawing.Size(602, 78);
            this.rtxtbxAddress.TabIndex = 2;
            this.rtxtbxAddress.Text = "";
            this.rtxtbxAddress.TextChanged += new System.EventHandler(this.rtxtbxAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(82, 184);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address :";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(566, 308);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(200, 30);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Next";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(356, 308);
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
            this.btnClose.Location = new System.Drawing.Point(140, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAddressSignal);
            this.groupBox1.Controls.Add(this.lblContactNumberSignal);
            this.groupBox1.Controls.Add(this.lblNameSignal);
            this.groupBox1.Controls.Add(this.btnCreateAccount);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblContactNumber);
            this.groupBox1.Controls.Add(this.lblAddCompany);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 516);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // lblContactNumberSignal
            // 
            this.lblContactNumberSignal.AutoSize = true;
            this.lblContactNumberSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblContactNumberSignal.Location = new System.Drawing.Point(610, 153);
            this.lblContactNumberSignal.Name = "lblContactNumberSignal";
            this.lblContactNumberSignal.Size = new System.Drawing.Size(13, 20);
            this.lblContactNumberSignal.TabIndex = 18;
            this.lblContactNumberSignal.Text = " ";
            // 
            // lblNameSignal
            // 
            this.lblNameSignal.AutoSize = true;
            this.lblNameSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblNameSignal.Location = new System.Drawing.Point(211, 152);
            this.lblNameSignal.Name = "lblNameSignal";
            this.lblNameSignal.Size = new System.Drawing.Size(13, 20);
            this.lblNameSignal.TabIndex = 17;
            this.lblNameSignal.Text = " ";
            // 
            // lblAddressSignal
            // 
            this.lblAddressSignal.AutoSize = true;
            this.lblAddressSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblAddressSignal.Location = new System.Drawing.Point(211, 253);
            this.lblAddressSignal.Name = "lblAddressSignal";
            this.lblAddressSignal.Size = new System.Drawing.Size(13, 20);
            this.lblAddressSignal.TabIndex = 20;
            this.lblAddressSignal.Text = " ";
            // 
            // frmAddCompnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.rtxtbxAddress);
            this.Controls.Add(this.txtbxContactNumber);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddCompnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCompnay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCompany;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbxContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.RichTextBox rtxtbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContactNumberSignal;
        private System.Windows.Forms.Label lblNameSignal;
        private System.Windows.Forms.Label lblAddressSignal;
    }
}