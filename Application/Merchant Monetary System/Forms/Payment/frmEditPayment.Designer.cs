namespace Merchant_Monetary_System.Forms.Payment
{
    partial class frmEditPayment
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
            this.comboBoxPaymentByName = new System.Windows.Forms.ComboBox();
            this.lblPaymentByName = new System.Windows.Forms.Label();
            this.comboBoxPaymentReceivedByName = new System.Windows.Forms.ComboBox();
            this.lblPaymentRecievedByName = new System.Windows.Forms.Label();
            this.comboBoxPaymentBy = new System.Windows.Forms.ComboBox();
            this.lblPaymentDesignationBy = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbxPaymentReceived = new System.Windows.Forms.ComboBox();
            this.lblContactNumberSignal = new System.Windows.Forms.Label();
            this.lblGenderSignal = new System.Windows.Forms.Label();
            this.lblConfirmPasswordSignal = new System.Windows.Forms.Label();
            this.lblNewPasswordSignal = new System.Windows.Forms.Label();
            this.lblCNICSignal = new System.Windows.Forms.Label();
            this.lblDesignationSingal = new System.Windows.Forms.Label();
            this.rtxtbxDescription = new System.Windows.Forms.RichTextBox();
            this.rdbtnWithdraw = new System.Windows.Forms.RadioButton();
            this.rdbtnDeposit = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtbxConfirmAmount = new System.Windows.Forms.TextBox();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaymentReceivedBy = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.cmbxDesignation = new System.Windows.Forms.ComboBox();
            this.lblUpdatePayment = new System.Windows.Forms.Label();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPaymentByName
            // 
            this.comboBoxPaymentByName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentByName.FormattingEnabled = true;
            this.comboBoxPaymentByName.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider",
            "Warehouse Manager"});
            this.comboBoxPaymentByName.Location = new System.Drawing.Point(598, 298);
            this.comboBoxPaymentByName.Name = "comboBoxPaymentByName";
            this.comboBoxPaymentByName.Size = new System.Drawing.Size(203, 28);
            this.comboBoxPaymentByName.Sorted = true;
            this.comboBoxPaymentByName.TabIndex = 42;
            // 
            // lblPaymentByName
            // 
            this.lblPaymentByName.AutoSize = true;
            this.lblPaymentByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentByName.Location = new System.Drawing.Point(464, 296);
            this.lblPaymentByName.Name = "lblPaymentByName";
            this.lblPaymentByName.Size = new System.Drawing.Size(93, 20);
            this.lblPaymentByName.TabIndex = 41;
            this.lblPaymentByName.Text = "Payment By";
            // 
            // comboBoxPaymentReceivedByName
            // 
            this.comboBoxPaymentReceivedByName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentReceivedByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentReceivedByName.FormattingEnabled = true;
            this.comboBoxPaymentReceivedByName.Location = new System.Drawing.Point(647, 335);
            this.comboBoxPaymentReceivedByName.Name = "comboBoxPaymentReceivedByName";
            this.comboBoxPaymentReceivedByName.Size = new System.Drawing.Size(154, 28);
            this.comboBoxPaymentReceivedByName.Sorted = true;
            this.comboBoxPaymentReceivedByName.TabIndex = 40;
            // 
            // lblPaymentRecievedByName
            // 
            this.lblPaymentRecievedByName.AutoSize = true;
            this.lblPaymentRecievedByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentRecievedByName.Location = new System.Drawing.Point(463, 337);
            this.lblPaymentRecievedByName.Name = "lblPaymentRecievedByName";
            this.lblPaymentRecievedByName.Size = new System.Drawing.Size(163, 20);
            this.lblPaymentRecievedByName.TabIndex = 39;
            this.lblPaymentRecievedByName.Text = "Payment Recieved By";
            // 
            // comboBoxPaymentBy
            // 
            this.comboBoxPaymentBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentBy.FormattingEnabled = true;
            this.comboBoxPaymentBy.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider",
            "Warehouse Manager"});
            this.comboBoxPaymentBy.Location = new System.Drawing.Point(232, 298);
            this.comboBoxPaymentBy.Name = "comboBoxPaymentBy";
            this.comboBoxPaymentBy.Size = new System.Drawing.Size(203, 28);
            this.comboBoxPaymentBy.Sorted = true;
            this.comboBoxPaymentBy.TabIndex = 38;
            // 
            // lblPaymentDesignationBy
            // 
            this.lblPaymentDesignationBy.AutoSize = true;
            this.lblPaymentDesignationBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDesignationBy.Location = new System.Drawing.Point(98, 296);
            this.lblPaymentDesignationBy.Name = "lblPaymentDesignationBy";
            this.lblPaymentDesignationBy.Size = new System.Drawing.Size(93, 20);
            this.lblPaymentDesignationBy.TabIndex = 37;
            this.lblPaymentDesignationBy.Text = "Payment By";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(232, 169);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(203, 26);
            this.dateTimePicker.TabIndex = 36;
            // 
            // cmbxPaymentReceived
            // 
            this.cmbxPaymentReceived.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaymentReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxPaymentReceived.FormattingEnabled = true;
            this.cmbxPaymentReceived.Location = new System.Drawing.Point(281, 335);
            this.cmbxPaymentReceived.Name = "cmbxPaymentReceived";
            this.cmbxPaymentReceived.Size = new System.Drawing.Size(154, 28);
            this.cmbxPaymentReceived.Sorted = true;
            this.cmbxPaymentReceived.TabIndex = 34;
            // 
            // lblContactNumberSignal
            // 
            this.lblContactNumberSignal.AutoSize = true;
            this.lblContactNumberSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblContactNumberSignal.Location = new System.Drawing.Point(633, 266);
            this.lblContactNumberSignal.Name = "lblContactNumberSignal";
            this.lblContactNumberSignal.Size = new System.Drawing.Size(13, 20);
            this.lblContactNumberSignal.TabIndex = 24;
            this.lblContactNumberSignal.Text = " ";
            // 
            // lblGenderSignal
            // 
            this.lblGenderSignal.AutoSize = true;
            this.lblGenderSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblGenderSignal.Location = new System.Drawing.Point(632, 215);
            this.lblGenderSignal.Name = "lblGenderSignal";
            this.lblGenderSignal.Size = new System.Drawing.Size(13, 20);
            this.lblGenderSignal.TabIndex = 23;
            this.lblGenderSignal.Text = " ";
            // 
            // lblConfirmPasswordSignal
            // 
            this.lblConfirmPasswordSignal.AutoSize = true;
            this.lblConfirmPasswordSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblConfirmPasswordSignal.Location = new System.Drawing.Point(232, 364);
            this.lblConfirmPasswordSignal.Name = "lblConfirmPasswordSignal";
            this.lblConfirmPasswordSignal.Size = new System.Drawing.Size(13, 20);
            this.lblConfirmPasswordSignal.TabIndex = 22;
            this.lblConfirmPasswordSignal.Text = " ";
            // 
            // lblNewPasswordSignal
            // 
            this.lblNewPasswordSignal.AutoSize = true;
            this.lblNewPasswordSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblNewPasswordSignal.Location = new System.Drawing.Point(232, 315);
            this.lblNewPasswordSignal.Name = "lblNewPasswordSignal";
            this.lblNewPasswordSignal.Size = new System.Drawing.Size(13, 20);
            this.lblNewPasswordSignal.TabIndex = 21;
            this.lblNewPasswordSignal.Text = " ";
            // 
            // lblCNICSignal
            // 
            this.lblCNICSignal.AutoSize = true;
            this.lblCNICSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblCNICSignal.Location = new System.Drawing.Point(632, 164);
            this.lblCNICSignal.Name = "lblCNICSignal";
            this.lblCNICSignal.Size = new System.Drawing.Size(13, 20);
            this.lblCNICSignal.TabIndex = 18;
            this.lblCNICSignal.Text = " ";
            // 
            // lblDesignationSingal
            // 
            this.lblDesignationSingal.AutoSize = true;
            this.lblDesignationSingal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblDesignationSingal.Location = new System.Drawing.Point(232, 161);
            this.lblDesignationSingal.Name = "lblDesignationSingal";
            this.lblDesignationSingal.Size = new System.Drawing.Size(13, 20);
            this.lblDesignationSingal.TabIndex = 1;
            this.lblDesignationSingal.Text = " ";
            // 
            // rtxtbxDescription
            // 
            this.rtxtbxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtbxDescription.Location = new System.Drawing.Point(632, 167);
            this.rtxtbxDescription.Name = "rtxtbxDescription";
            this.rtxtbxDescription.Size = new System.Drawing.Size(169, 104);
            this.rtxtbxDescription.TabIndex = 10;
            this.rtxtbxDescription.Text = "";
            // 
            // rdbtnWithdraw
            // 
            this.rdbtnWithdraw.AutoSize = true;
            this.rdbtnWithdraw.Location = new System.Drawing.Point(710, 132);
            this.rdbtnWithdraw.Name = "rdbtnWithdraw";
            this.rdbtnWithdraw.Size = new System.Drawing.Size(93, 24);
            this.rdbtnWithdraw.TabIndex = 7;
            this.rdbtnWithdraw.TabStop = true;
            this.rdbtnWithdraw.Text = "Withdraw";
            this.rdbtnWithdraw.UseVisualStyleBackColor = true;
            // 
            // rdbtnDeposit
            // 
            this.rdbtnDeposit.AutoSize = true;
            this.rdbtnDeposit.Checked = true;
            this.rdbtnDeposit.Location = new System.Drawing.Point(631, 132);
            this.rdbtnDeposit.Name = "rdbtnDeposit";
            this.rdbtnDeposit.Size = new System.Drawing.Size(82, 24);
            this.rdbtnDeposit.TabIndex = 6;
            this.rdbtnDeposit.TabStop = true;
            this.rdbtnDeposit.Text = "Deposit";
            this.rdbtnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(571, 417);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(353, 417);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(147, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // txtbxConfirmAmount
            // 
            this.txtbxConfirmAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConfirmAmount.Location = new System.Drawing.Point(232, 249);
            this.txtbxConfirmAmount.Name = "txtbxConfirmAmount";
            this.txtbxConfirmAmount.Size = new System.Drawing.Size(203, 26);
            this.txtbxConfirmAmount.TabIndex = 3;
            this.txtbxConfirmAmount.UseSystemPasswordChar = true;
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAmount.Location = new System.Drawing.Point(232, 208);
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.Size = new System.Drawing.Size(203, 26);
            this.txtbxAmount.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(458, 171);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(123, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Home Address :";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(98, 251);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(124, 20);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "Confirm Amount";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(99, 208);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // lblPaymentReceivedBy
            // 
            this.lblPaymentReceivedBy.AutoSize = true;
            this.lblPaymentReceivedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentReceivedBy.Location = new System.Drawing.Point(97, 337);
            this.lblPaymentReceivedBy.Name = "lblPaymentReceivedBy";
            this.lblPaymentReceivedBy.Size = new System.Drawing.Size(163, 20);
            this.lblPaymentReceivedBy.TabIndex = 2;
            this.lblPaymentReceivedBy.Text = "Payment Recieved By";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(99, 169);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMode.Location = new System.Drawing.Point(458, 133);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(115, 20);
            this.lblPaymentMode.TabIndex = 2;
            this.lblPaymentMode.Text = "Payment Mode";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(97, 135);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(109, 20);
            this.lblPaymentType.TabIndex = 2;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // cmbxDesignation
            // 
            this.cmbxDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDesignation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxDesignation.FormattingEnabled = true;
            this.cmbxDesignation.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider",
            "Warehouse Manager"});
            this.cmbxDesignation.Location = new System.Drawing.Point(232, 133);
            this.cmbxDesignation.Name = "cmbxDesignation";
            this.cmbxDesignation.Size = new System.Drawing.Size(203, 28);
            this.cmbxDesignation.Sorted = true;
            this.cmbxDesignation.TabIndex = 0;
            // 
            // lblUpdatePayment
            // 
            this.lblUpdatePayment.AutoSize = true;
            this.lblUpdatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePayment.Location = new System.Drawing.Point(238, 67);
            this.lblUpdatePayment.Name = "lblUpdatePayment";
            this.lblUpdatePayment.Size = new System.Drawing.Size(475, 39);
            this.lblUpdatePayment.TabIndex = 0;
            this.lblUpdatePayment.Text = "Update Payment Information";
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.comboBoxPaymentByName);
            this.gbx.Controls.Add(this.lblPaymentByName);
            this.gbx.Controls.Add(this.comboBoxPaymentReceivedByName);
            this.gbx.Controls.Add(this.lblPaymentRecievedByName);
            this.gbx.Controls.Add(this.comboBoxPaymentBy);
            this.gbx.Controls.Add(this.lblPaymentDesignationBy);
            this.gbx.Controls.Add(this.dateTimePicker);
            this.gbx.Controls.Add(this.cmbxPaymentReceived);
            this.gbx.Controls.Add(this.lblContactNumberSignal);
            this.gbx.Controls.Add(this.lblGenderSignal);
            this.gbx.Controls.Add(this.lblConfirmPasswordSignal);
            this.gbx.Controls.Add(this.lblNewPasswordSignal);
            this.gbx.Controls.Add(this.lblCNICSignal);
            this.gbx.Controls.Add(this.lblDesignationSingal);
            this.gbx.Controls.Add(this.rtxtbxDescription);
            this.gbx.Controls.Add(this.rdbtnWithdraw);
            this.gbx.Controls.Add(this.rdbtnDeposit);
            this.gbx.Controls.Add(this.btnUpdate);
            this.gbx.Controls.Add(this.btnClear);
            this.gbx.Controls.Add(this.btnClose);
            this.gbx.Controls.Add(this.txtbxConfirmAmount);
            this.gbx.Controls.Add(this.txtbxAmount);
            this.gbx.Controls.Add(this.lblDescription);
            this.gbx.Controls.Add(this.lblNewPassword);
            this.gbx.Controls.Add(this.lblAmount);
            this.gbx.Controls.Add(this.lblPaymentReceivedBy);
            this.gbx.Controls.Add(this.lblDate);
            this.gbx.Controls.Add(this.lblPaymentMode);
            this.gbx.Controls.Add(this.lblPaymentType);
            this.gbx.Controls.Add(this.cmbxDesignation);
            this.gbx.Controls.Add(this.lblUpdatePayment);
            this.gbx.Location = new System.Drawing.Point(8, -5);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(930, 540);
            this.gbx.TabIndex = 2;
            this.gbx.TabStop = false;
            // 
            // frmEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.gbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditPayment";
            this.Text = "frmEditPayment";
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPaymentByName;
        private System.Windows.Forms.Label lblPaymentByName;
        private System.Windows.Forms.ComboBox comboBoxPaymentReceivedByName;
        private System.Windows.Forms.Label lblPaymentRecievedByName;
        private System.Windows.Forms.ComboBox comboBoxPaymentBy;
        private System.Windows.Forms.Label lblPaymentDesignationBy;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmbxPaymentReceived;
        private System.Windows.Forms.Label lblContactNumberSignal;
        private System.Windows.Forms.Label lblGenderSignal;
        private System.Windows.Forms.Label lblConfirmPasswordSignal;
        private System.Windows.Forms.Label lblNewPasswordSignal;
        private System.Windows.Forms.Label lblCNICSignal;
        private System.Windows.Forms.Label lblDesignationSingal;
        private System.Windows.Forms.RichTextBox rtxtbxDescription;
        private System.Windows.Forms.RadioButton rdbtnWithdraw;
        private System.Windows.Forms.RadioButton rdbtnDeposit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtbxConfirmAmount;
        private System.Windows.Forms.TextBox txtbxAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPaymentReceivedBy;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox cmbxDesignation;
        private System.Windows.Forms.Label lblUpdatePayment;
        private System.Windows.Forms.GroupBox gbx;
    }
}