namespace Merchant_Monetary_System
{
    partial class frmAddProduct
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
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbxManufacture = new System.Windows.Forms.ComboBox();
            this.lblSensitivity_Type = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblSKU_Number = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxSKU_ID = new System.Windows.Forms.TextBox();
            this.txtbxWeight = new System.Windows.Forms.TextBox();
            this.txtbxVolume = new System.Windows.Forms.TextBox();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbxCategory = new System.Windows.Forms.ComboBox();
            this.lblManufacture = new System.Windows.Forms.Label();
            this.cmbxSenstivity = new System.Windows.Forms.ComboBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lblS_Number = new System.Windows.Forms.Label();
            this.lblNameSignal = new System.Windows.Forms.Label();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(346, 51);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(215, 39);
            this.lblSignUp.TabIndex = 21;
            this.lblSignUp.Text = "Add Product";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(107, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(353, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 30);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(599, 435);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(200, 30);
            this.btnAddProduct.TabIndex = 42;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
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
            this.cmbxManufacture.Location = new System.Drawing.Point(631, 144);
            this.cmbxManufacture.Name = "cmbxManufacture";
            this.cmbxManufacture.Size = new System.Drawing.Size(203, 28);
            this.cmbxManufacture.Sorted = true;
            this.cmbxManufacture.TabIndex = 37;
            // 
            // lblSensitivity_Type
            // 
            this.lblSensitivity_Type.AutoSize = true;
            this.lblSensitivity_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSensitivity_Type.Location = new System.Drawing.Point(478, 199);
            this.lblSensitivity_Type.Name = "lblSensitivity_Type";
            this.lblSensitivity_Type.Size = new System.Drawing.Size(121, 20);
            this.lblSensitivity_Type.TabIndex = 35;
            this.lblSensitivity_Type.Text = "Sensitivity Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(69, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name :";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVolume.Location = new System.Drawing.Point(69, 294);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(67, 20);
            this.lblVolume.TabIndex = 26;
            this.lblVolume.Text = "Volume:";
            // 
            // lblSKU_Number
            // 
            this.lblSKU_Number.AutoSize = true;
            this.lblSKU_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSKU_Number.Location = new System.Drawing.Point(69, 196);
            this.lblSKU_Number.Name = "lblSKU_Number";
            this.lblSKU_Number.Size = new System.Drawing.Size(102, 20);
            this.lblSKU_Number.TabIndex = 24;
            this.lblSKU_Number.Text = "SKU Number";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWeight.Location = new System.Drawing.Point(69, 245);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(67, 20);
            this.lblWeight.TabIndex = 25;
            this.lblWeight.Text = "Weight :";
            // 
            // txtbxName
            // 
            this.txtbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbxName.Location = new System.Drawing.Point(219, 141);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(203, 26);
            this.txtbxName.TabIndex = 27;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged_1);
            // 
            // txtbxSKU_ID
            // 
            this.txtbxSKU_ID.Location = new System.Drawing.Point(219, 193);
            this.txtbxSKU_ID.Name = "txtbxSKU_ID";
            this.txtbxSKU_ID.Size = new System.Drawing.Size(203, 26);
            this.txtbxSKU_ID.TabIndex = 29;
            this.txtbxSKU_ID.TextChanged += new System.EventHandler(this.txtbxSKU_ID_TextChanged);
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Location = new System.Drawing.Point(219, 243);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.Size = new System.Drawing.Size(203, 26);
            this.txtbxWeight.TabIndex = 31;
            this.txtbxWeight.TextChanged += new System.EventHandler(this.txtbxWeight_TextChanged);
            // 
            // txtbxVolume
            // 
            this.txtbxVolume.Location = new System.Drawing.Point(219, 292);
            this.txtbxVolume.Name = "txtbxVolume";
            this.txtbxVolume.Size = new System.Drawing.Size(203, 26);
            this.txtbxVolume.TabIndex = 33;
            this.txtbxVolume.TextChanged += new System.EventHandler(this.txtbxVolume_TextChanged);
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lbl_Volume.Location = new System.Drawing.Point(219, 321);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(13, 20);
            this.lbl_Volume.TabIndex = 43;
            this.lbl_Volume.Text = " ";
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.lbl_Volume);
            this.gbx.Controls.Add(this.lblCategory);
            this.gbx.Controls.Add(this.cmbxCategory);
            this.gbx.Controls.Add(this.lblManufacture);
            this.gbx.Controls.Add(this.cmbxSenstivity);
            this.gbx.Controls.Add(this.lbl_Weight);
            this.gbx.Controls.Add(this.lblS_Number);
            this.gbx.Controls.Add(this.lblNameSignal);
            this.gbx.Controls.Add(this.txtbxVolume);
            this.gbx.Controls.Add(this.txtbxWeight);
            this.gbx.Controls.Add(this.txtbxSKU_ID);
            this.gbx.Controls.Add(this.txtbxName);
            this.gbx.Controls.Add(this.lblWeight);
            this.gbx.Controls.Add(this.lblSKU_Number);
            this.gbx.Controls.Add(this.lblVolume);
            this.gbx.Controls.Add(this.lblName);
            this.gbx.Controls.Add(this.lblSensitivity_Type);
            this.gbx.Controls.Add(this.cmbxManufacture);
            this.gbx.Controls.Add(this.btnAddProduct);
            this.gbx.Controls.Add(this.btnClear);
            this.gbx.Controls.Add(this.btnClose);
            this.gbx.Controls.Add(this.lblSignUp);
            this.gbx.Location = new System.Drawing.Point(12, 12);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(906, 516);
            this.gbx.TabIndex = 1;
            this.gbx.TabStop = false;
            this.gbx.TextChanged += new System.EventHandler(this.gbx_TextChanged);
            this.gbx.Enter += new System.EventHandler(this.gbx_Enter);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategory.Location = new System.Drawing.Point(478, 248);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 36;
            this.lblCategory.Text = "Category :";
            // 
            // cmbxCategory
            // 
            this.cmbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxCategory.FormattingEnabled = true;
            this.cmbxCategory.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider"});
            this.cmbxCategory.Location = new System.Drawing.Point(631, 245);
            this.cmbxCategory.Name = "cmbxCategory";
            this.cmbxCategory.Size = new System.Drawing.Size(203, 28);
            this.cmbxCategory.Sorted = true;
            this.cmbxCategory.TabIndex = 39;
            // 
            // lblManufacture
            // 
            this.lblManufacture.AutoSize = true;
            this.lblManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblManufacture.Location = new System.Drawing.Point(478, 147);
            this.lblManufacture.Name = "lblManufacture";
            this.lblManufacture.Size = new System.Drawing.Size(107, 20);
            this.lblManufacture.TabIndex = 34;
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
            this.cmbxSenstivity.Location = new System.Drawing.Point(634, 196);
            this.cmbxSenstivity.Name = "cmbxSenstivity";
            this.cmbxSenstivity.Size = new System.Drawing.Size(203, 28);
            this.cmbxSenstivity.Sorted = true;
            this.cmbxSenstivity.TabIndex = 38;
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lbl_Weight.Location = new System.Drawing.Point(219, 269);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(13, 20);
            this.lbl_Weight.TabIndex = 32;
            this.lbl_Weight.Text = " ";
            // 
            // lblS_Number
            // 
            this.lblS_Number.AutoSize = true;
            this.lblS_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblS_Number.Location = new System.Drawing.Point(219, 222);
            this.lblS_Number.Name = "lblS_Number";
            this.lblS_Number.Size = new System.Drawing.Size(13, 20);
            this.lblS_Number.TabIndex = 30;
            this.lblS_Number.Text = " ";
            // 
            // lblNameSignal
            // 
            this.lblNameSignal.AutoSize = true;
            this.lblNameSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblNameSignal.Location = new System.Drawing.Point(219, 170);
            this.lblNameSignal.Name = "lblNameSignal";
            this.lblNameSignal.Size = new System.Drawing.Size(13, 20);
            this.lblNameSignal.TabIndex = 28;
            this.lblNameSignal.Text = " ";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.gbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTest";
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cmbxManufacture;
        private System.Windows.Forms.Label lblSensitivity_Type;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblSKU_Number;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxSKU_ID;
        private System.Windows.Forms.TextBox txtbxWeight;
        private System.Windows.Forms.TextBox txtbxVolume;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbxCategory;
        private System.Windows.Forms.Label lblManufacture;
        private System.Windows.Forms.ComboBox cmbxSenstivity;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lblS_Number;
        private System.Windows.Forms.Label lblNameSignal;
    }
}