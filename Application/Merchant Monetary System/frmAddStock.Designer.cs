namespace Merchant_Monetary_System
{
    partial class frmAddStock
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
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.lblManufacture = new System.Windows.Forms.Label();
            this.cmbxSenstivity = new System.Windows.Forms.ComboBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lblS_Number = new System.Windows.Forms.Label();
            this.lblNameSignal = new System.Windows.Forms.Label();
            this.txtbxVolume = new System.Windows.Forms.TextBox();
            this.txtbxWeight = new System.Windows.Forms.TextBox();
            this.txtbxSKU_ID = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSKU_Number = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSensitivity_Type = new System.Windows.Forms.Label();
            this.cmbxManufacture = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Volume);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.comboCategory);
            this.groupBox1.Controls.Add(this.lblManufacture);
            this.groupBox1.Controls.Add(this.cmbxSenstivity);
            this.groupBox1.Controls.Add(this.lbl_Weight);
            this.groupBox1.Controls.Add(this.lblS_Number);
            this.groupBox1.Controls.Add(this.lblNameSignal);
            this.groupBox1.Controls.Add(this.txtbxVolume);
            this.groupBox1.Controls.Add(this.txtbxWeight);
            this.groupBox1.Controls.Add(this.txtbxSKU_ID);
            this.groupBox1.Controls.Add(this.txtbxName);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblSKU_Number);
            this.groupBox1.Controls.Add(this.lblVolume);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblSensitivity_Type);
            this.groupBox1.Controls.Add(this.cmbxManufacture);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblSignUp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lbl_Volume.Location = new System.Drawing.Point(231, 333);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(13, 20);
            this.lbl_Volume.TabIndex = 65;
            this.lbl_Volume.Text = " ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategory.Location = new System.Drawing.Point(490, 260);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 58;
            this.lblCategory.Text = "Category :";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider"});
            this.comboCategory.Location = new System.Drawing.Point(643, 257);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(203, 28);
            this.comboCategory.Sorted = true;
            this.comboCategory.TabIndex = 61;
            // 
            // lblManufacture
            // 
            this.lblManufacture.AutoSize = true;
            this.lblManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblManufacture.Location = new System.Drawing.Point(490, 159);
            this.lblManufacture.Name = "lblManufacture";
            this.lblManufacture.Size = new System.Drawing.Size(107, 20);
            this.lblManufacture.TabIndex = 56;
            this.lblManufacture.Text = "Manufacture :";
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
            this.cmbxSenstivity.Location = new System.Drawing.Point(646, 208);
            this.cmbxSenstivity.Name = "cmbxSenstivity";
            this.cmbxSenstivity.Size = new System.Drawing.Size(203, 28);
            this.cmbxSenstivity.Sorted = true;
            this.cmbxSenstivity.TabIndex = 60;
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lbl_Weight.Location = new System.Drawing.Point(231, 281);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(13, 20);
            this.lbl_Weight.TabIndex = 54;
            this.lbl_Weight.Text = " ";
            // 
            // lblS_Number
            // 
            this.lblS_Number.AutoSize = true;
            this.lblS_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblS_Number.Location = new System.Drawing.Point(231, 234);
            this.lblS_Number.Name = "lblS_Number";
            this.lblS_Number.Size = new System.Drawing.Size(13, 20);
            this.lblS_Number.TabIndex = 52;
            this.lblS_Number.Text = " ";
            // 
            // lblNameSignal
            // 
            this.lblNameSignal.AutoSize = true;
            this.lblNameSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblNameSignal.Location = new System.Drawing.Point(231, 182);
            this.lblNameSignal.Name = "lblNameSignal";
            this.lblNameSignal.Size = new System.Drawing.Size(13, 20);
            this.lblNameSignal.TabIndex = 50;
            this.lblNameSignal.Text = " ";
            // 
            // txtbxVolume
            // 
            this.txtbxVolume.Location = new System.Drawing.Point(231, 304);
            this.txtbxVolume.Name = "txtbxVolume";
            this.txtbxVolume.Size = new System.Drawing.Size(203, 26);
            this.txtbxVolume.TabIndex = 55;
            this.txtbxVolume.UseSystemPasswordChar = true;
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Location = new System.Drawing.Point(231, 255);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.Size = new System.Drawing.Size(203, 26);
            this.txtbxWeight.TabIndex = 53;
            this.txtbxWeight.UseSystemPasswordChar = true;
            // 
            // txtbxSKU_ID
            // 
            this.txtbxSKU_ID.Location = new System.Drawing.Point(231, 205);
            this.txtbxSKU_ID.Name = "txtbxSKU_ID";
            this.txtbxSKU_ID.Size = new System.Drawing.Size(203, 26);
            this.txtbxSKU_ID.TabIndex = 51;
            // 
            // txtbxName
            // 
            this.txtbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbxName.Location = new System.Drawing.Point(231, 153);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(203, 26);
            this.txtbxName.TabIndex = 49;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWeight.Location = new System.Drawing.Point(81, 257);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(67, 20);
            this.lblWeight.TabIndex = 47;
            this.lblWeight.Text = "Weight :";
            // 
            // lblSKU_Number
            // 
            this.lblSKU_Number.AutoSize = true;
            this.lblSKU_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSKU_Number.Location = new System.Drawing.Point(81, 208);
            this.lblSKU_Number.Name = "lblSKU_Number";
            this.lblSKU_Number.Size = new System.Drawing.Size(102, 20);
            this.lblSKU_Number.TabIndex = 46;
            this.lblSKU_Number.Text = "SKU Number";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVolume.Location = new System.Drawing.Point(81, 306);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(67, 20);
            this.lblVolume.TabIndex = 48;
            this.lblVolume.Text = "Volume:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(81, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name :";
            // 
            // lblSensitivity_Type
            // 
            this.lblSensitivity_Type.AutoSize = true;
            this.lblSensitivity_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSensitivity_Type.Location = new System.Drawing.Point(490, 211);
            this.lblSensitivity_Type.Name = "lblSensitivity_Type";
            this.lblSensitivity_Type.Size = new System.Drawing.Size(121, 20);
            this.lblSensitivity_Type.TabIndex = 57;
            this.lblSensitivity_Type.Text = "Sensitivity Type:";
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
            this.cmbxManufacture.Location = new System.Drawing.Point(643, 156);
            this.cmbxManufacture.Name = "cmbxManufacture";
            this.cmbxManufacture.Size = new System.Drawing.Size(203, 28);
            this.cmbxManufacture.Sorted = true;
            this.cmbxManufacture.TabIndex = 59;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(611, 447);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(200, 30);
            this.btnAddProduct.TabIndex = 64;
            this.btnAddProduct.Text = "Add Stock";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(365, 447);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 30);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(119, 447);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(358, 63);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(181, 39);
            this.lblSignUp.TabIndex = 44;
            this.lblSignUp.Text = "Add Stock";
            // 
            // frmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 501);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label lblManufacture;
        private System.Windows.Forms.ComboBox cmbxSenstivity;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lblS_Number;
        private System.Windows.Forms.Label lblNameSignal;
        private System.Windows.Forms.TextBox txtbxVolume;
        private System.Windows.Forms.TextBox txtbxWeight;
        private System.Windows.Forms.TextBox txtbxSKU_ID;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSKU_Number;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSensitivity_Type;
        private System.Windows.Forms.ComboBox cmbxManufacture;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSignUp;
    }
}