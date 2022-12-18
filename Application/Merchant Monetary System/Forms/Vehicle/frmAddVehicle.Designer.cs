namespace Merchant_Monetary_System.Forms.Vehicle
{
    partial class frmAddVehicle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.lblVolumeSignal = new System.Windows.Forms.Label();
            this.lblRegNOSignal = new System.Windows.Forms.Label();
            this.lblWeightSignal = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDesignationSingal = new System.Windows.Forms.Label();
            this.lblAddvehicle = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDesignationSingal);
            this.groupBox1.Controls.Add(this.lblAddvehicle);
            this.groupBox1.Controls.Add(this.btnAddVehicle);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 477);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbxType);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.txtVolume);
            this.groupBox2.Controls.Add(this.lblVolume);
            this.groupBox2.Controls.Add(this.txtRegistrationNo);
            this.groupBox2.Controls.Add(this.lblRegistrationNo);
            this.groupBox2.Controls.Add(this.lblVolumeSignal);
            this.groupBox2.Controls.Add(this.lblRegNOSignal);
            this.groupBox2.Controls.Add(this.lblWeightSignal);
            this.groupBox2.Controls.Add(this.txtWeight);
            this.groupBox2.Controls.Add(this.lblWeight);
            this.groupBox2.Location = new System.Drawing.Point(65, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 141);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(8, 32);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 84;
            this.lblType.Text = "Type:";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(182, 79);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(203, 26);
            this.txtVolume.TabIndex = 38;
            this.txtVolume.TextChanged += new System.EventHandler(this.txtVolume_TextChanged);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(8, 81);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(154, 20);
            this.lblVolume.TabIndex = 42;
            this.lblVolume.Text = "Capacity In Volume: ";
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(567, 22);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(203, 26);
            this.txtRegistrationNo.TabIndex = 81;
            this.txtRegistrationNo.TextChanged += new System.EventHandler(this.txtRegistrationNo_TextChanged);
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Location = new System.Drawing.Point(393, 25);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(131, 20);
            this.lblRegistrationNo.TabIndex = 82;
            this.lblRegistrationNo.Text = "Registration No. :";
            // 
            // lblVolumeSignal
            // 
            this.lblVolumeSignal.AutoSize = true;
            this.lblVolumeSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblVolumeSignal.Location = new System.Drawing.Point(183, 108);
            this.lblVolumeSignal.Name = "lblVolumeSignal";
            this.lblVolumeSignal.Size = new System.Drawing.Size(13, 20);
            this.lblVolumeSignal.TabIndex = 64;
            this.lblVolumeSignal.Text = " ";
            // 
            // lblRegNOSignal
            // 
            this.lblRegNOSignal.AutoSize = true;
            this.lblRegNOSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblRegNOSignal.Location = new System.Drawing.Point(568, 51);
            this.lblRegNOSignal.Name = "lblRegNOSignal";
            this.lblRegNOSignal.Size = new System.Drawing.Size(13, 20);
            this.lblRegNOSignal.TabIndex = 65;
            this.lblRegNOSignal.Text = " ";
            // 
            // lblWeightSignal
            // 
            this.lblWeightSignal.AutoSize = true;
            this.lblWeightSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblWeightSignal.Location = new System.Drawing.Point(568, 105);
            this.lblWeightSignal.Name = "lblWeightSignal";
            this.lblWeightSignal.Size = new System.Drawing.Size(13, 20);
            this.lblWeightSignal.TabIndex = 72;
            this.lblWeightSignal.Text = " ";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(567, 76);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(203, 26);
            this.txtWeight.TabIndex = 71;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(393, 82);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(144, 20);
            this.lblWeight.TabIndex = 70;
            this.lblWeight.Text = "Capacity in Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(651, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(627, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = " ";
            // 
            // lblDesignationSingal
            // 
            this.lblDesignationSingal.AutoSize = true;
            this.lblDesignationSingal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblDesignationSingal.Location = new System.Drawing.Point(624, 227);
            this.lblDesignationSingal.Name = "lblDesignationSingal";
            this.lblDesignationSingal.Size = new System.Drawing.Size(13, 20);
            this.lblDesignationSingal.TabIndex = 39;
            this.lblDesignationSingal.Text = " ";
            // 
            // lblAddvehicle
            // 
            this.lblAddvehicle.AutoSize = true;
            this.lblAddvehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddvehicle.Location = new System.Drawing.Point(349, 45);
            this.lblAddvehicle.Name = "lblAddvehicle";
            this.lblAddvehicle.Size = new System.Drawing.Size(211, 39);
            this.lblAddvehicle.TabIndex = 36;
            this.lblAddvehicle.Text = "Add Vehicle";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnAddVehicle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAddVehicle.Location = new System.Drawing.Point(563, 399);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(200, 30);
            this.btnAddVehicle.TabIndex = 61;
            this.btnAddVehicle.Text = "Add";
            this.btnAddVehicle.UseVisualStyleBackColor = false;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(351, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 30);
            this.btnClear.TabIndex = 60;
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
            this.btnClose.Location = new System.Drawing.Point(139, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbxType
            // 
            this.cmbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Items.AddRange(new object[] {
            "Bike",
            "Car"});
            this.cmbxType.Location = new System.Drawing.Point(182, 20);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(203, 28);
            this.cmbxType.Sorted = true;
            this.cmbxType.TabIndex = 85;
            // 
            // frmAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddVehicle";
            this.Text = "frmAddVehicle";
            this.Load += new System.EventHandler(this.frmAddVehicle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.Label lblVolumeSignal;
        private System.Windows.Forms.Label lblRegNOSignal;
        private System.Windows.Forms.Label lblWeightSignal;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDesignationSingal;
        private System.Windows.Forms.Label lblAddvehicle;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbxType;
    }
}