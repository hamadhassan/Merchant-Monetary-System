namespace Merchant_Monetary_System.Forms.Product
{
    partial class frmUpdateProduct
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
            this.lblupdate_ = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.lblupdate_);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lbl_Volume.Location = new System.Drawing.Point(221, 313);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(13, 20);
            this.lbl_Volume.TabIndex = 65;
            this.lbl_Volume.Text = " ";
            this.lbl_Volume.Click += new System.EventHandler(this.lbl_Volume_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategory.Location = new System.Drawing.Point(480, 240);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 58;
            this.lblCategory.Text = "Category :";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(633, 237);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(203, 28);
            this.comboCategory.Sorted = true;
            this.comboCategory.TabIndex = 61;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // lblManufacture
            // 
            this.lblManufacture.AutoSize = true;
            this.lblManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblManufacture.Location = new System.Drawing.Point(480, 139);
            this.lblManufacture.Name = "lblManufacture";
            this.lblManufacture.Size = new System.Drawing.Size(107, 20);
            this.lblManufacture.TabIndex = 56;
            this.lblManufacture.Text = "Manufacture :";
            this.lblManufacture.Click += new System.EventHandler(this.lblManufacture_Click);
            // 
            // cmbxSenstivity
            // 
            this.cmbxSenstivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSenstivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxSenstivity.FormattingEnabled = true;
            this.cmbxSenstivity.Items.AddRange(new object[] {
            "Fragile Product",
            "Non Fraglie Product"});
            this.cmbxSenstivity.Location = new System.Drawing.Point(636, 188);
            this.cmbxSenstivity.Name = "cmbxSenstivity";
            this.cmbxSenstivity.Size = new System.Drawing.Size(203, 28);
            this.cmbxSenstivity.Sorted = true;
            this.cmbxSenstivity.TabIndex = 60;
            this.cmbxSenstivity.SelectedIndexChanged += new System.EventHandler(this.cmbxSenstivity_SelectedIndexChanged);
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lbl_Weight.Location = new System.Drawing.Point(221, 261);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(13, 20);
            this.lbl_Weight.TabIndex = 54;
            this.lbl_Weight.Text = " ";
            this.lbl_Weight.Click += new System.EventHandler(this.lbl_Weight_Click);
            // 
            // lblS_Number
            // 
            this.lblS_Number.AutoSize = true;
            this.lblS_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblS_Number.Location = new System.Drawing.Point(221, 214);
            this.lblS_Number.Name = "lblS_Number";
            this.lblS_Number.Size = new System.Drawing.Size(13, 20);
            this.lblS_Number.TabIndex = 52;
            this.lblS_Number.Text = " ";
            this.lblS_Number.Click += new System.EventHandler(this.lblS_Number_Click);
            // 
            // lblNameSignal
            // 
            this.lblNameSignal.AutoSize = true;
            this.lblNameSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblNameSignal.Location = new System.Drawing.Point(221, 162);
            this.lblNameSignal.Name = "lblNameSignal";
            this.lblNameSignal.Size = new System.Drawing.Size(13, 20);
            this.lblNameSignal.TabIndex = 50;
            this.lblNameSignal.Text = " ";
            this.lblNameSignal.Click += new System.EventHandler(this.lblNameSignal_Click);
            // 
            // txtbxVolume
            // 
            this.txtbxVolume.Location = new System.Drawing.Point(221, 284);
            this.txtbxVolume.Name = "txtbxVolume";
            this.txtbxVolume.Size = new System.Drawing.Size(203, 26);
            this.txtbxVolume.TabIndex = 55;
            this.txtbxVolume.TextChanged += new System.EventHandler(this.txtbxVolume_TextChanged);
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Location = new System.Drawing.Point(221, 235);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.Size = new System.Drawing.Size(203, 26);
            this.txtbxWeight.TabIndex = 53;
            this.txtbxWeight.TextChanged += new System.EventHandler(this.txtbxWeight_TextChanged);
            // 
            // txtbxSKU_ID
            // 
            this.txtbxSKU_ID.Location = new System.Drawing.Point(221, 185);
            this.txtbxSKU_ID.Name = "txtbxSKU_ID";
            this.txtbxSKU_ID.Size = new System.Drawing.Size(203, 26);
            this.txtbxSKU_ID.TabIndex = 51;
            this.txtbxSKU_ID.TextChanged += new System.EventHandler(this.txtbxSKU_ID_TextChanged);
            // 
            // txtbxName
            // 
            this.txtbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbxName.Location = new System.Drawing.Point(221, 133);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(203, 26);
            this.txtbxName.TabIndex = 49;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWeight.Location = new System.Drawing.Point(71, 237);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(67, 20);
            this.lblWeight.TabIndex = 47;
            this.lblWeight.Text = "Weight :";
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // lblSKU_Number
            // 
            this.lblSKU_Number.AutoSize = true;
            this.lblSKU_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSKU_Number.Location = new System.Drawing.Point(71, 188);
            this.lblSKU_Number.Name = "lblSKU_Number";
            this.lblSKU_Number.Size = new System.Drawing.Size(102, 20);
            this.lblSKU_Number.TabIndex = 46;
            this.lblSKU_Number.Text = "SKU Number";
            this.lblSKU_Number.Click += new System.EventHandler(this.lblSKU_Number_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVolume.Location = new System.Drawing.Point(71, 286);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(67, 20);
            this.lblVolume.TabIndex = 48;
            this.lblVolume.Text = "Volume:";
            this.lblVolume.Click += new System.EventHandler(this.lblVolume_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(71, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name :";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblSensitivity_Type
            // 
            this.lblSensitivity_Type.AutoSize = true;
            this.lblSensitivity_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSensitivity_Type.Location = new System.Drawing.Point(480, 191);
            this.lblSensitivity_Type.Name = "lblSensitivity_Type";
            this.lblSensitivity_Type.Size = new System.Drawing.Size(121, 20);
            this.lblSensitivity_Type.TabIndex = 57;
            this.lblSensitivity_Type.Text = "Sensitivity Type:";
            this.lblSensitivity_Type.Click += new System.EventHandler(this.lblSensitivity_Type_Click);
            // 
            // cmbxManufacture
            // 
            this.cmbxManufacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxManufacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxManufacture.FormattingEnabled = true;
            this.cmbxManufacture.Items.AddRange(new object[] {
            ""});
            this.cmbxManufacture.Location = new System.Drawing.Point(633, 136);
            this.cmbxManufacture.Name = "cmbxManufacture";
            this.cmbxManufacture.Size = new System.Drawing.Size(203, 28);
            this.cmbxManufacture.Sorted = true;
            this.cmbxManufacture.TabIndex = 59;
            this.cmbxManufacture.SelectedIndexChanged += new System.EventHandler(this.cmbxManufacture_SelectedIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(601, 427);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(200, 30);
            this.btnAddProduct.TabIndex = 64;
            this.btnAddProduct.Text = "Update Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(355, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 30);
            this.btnClear.TabIndex = 63;
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
            this.btnClose.Location = new System.Drawing.Point(109, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblupdate_
            // 
            this.lblupdate_.AutoSize = true;
            this.lblupdate_.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdate_.Location = new System.Drawing.Point(348, 43);
            this.lblupdate_.Name = "lblupdate_";
            this.lblupdate_.Size = new System.Drawing.Size(267, 39);
            this.lblupdate_.TabIndex = 44;
            this.lblupdate_.Text = "Update Product";
            this.lblupdate_.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 501);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateProduct";
            this.Load += new System.EventHandler(this.frmUpdateProduct_Load);
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
        private System.Windows.Forms.Label lblupdate_;
    }
}