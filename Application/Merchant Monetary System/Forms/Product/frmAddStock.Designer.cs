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
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.lblRowSignal = new System.Windows.Forms.Label();
            this.lblCostPriceValid = new System.Windows.Forms.Label();
            this.lblRetailPriceValid = new System.Windows.Forms.Label();
            this.lblQuantityValid = new System.Windows.Forms.Label();
            this.btnAddTStock = new System.Windows.Forms.Button();
            this.lblVendor = new System.Windows.Forms.Label();
            this.comboBoxVendor = new System.Windows.Forms.ComboBox();
            this.DateMFG = new System.Windows.Forms.DateTimePicker();
            this.lblDateMFG = new System.Windows.Forms.Label();
            this.DateReceived = new System.Windows.Forms.DateTimePicker();
            this.DateExpiry = new System.Windows.Forms.DateTimePicker();
            this.lblProuct = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.lblVolumeValid = new System.Windows.Forms.Label();
            this.lblWeightValid = new System.Windows.Forms.Label();
            this.lblSKUValid = new System.Windows.Forms.Label();
            this.lblNameValid = new System.Windows.Forms.Label();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lblS_Number = new System.Windows.Forms.Label();
            this.txtbxCostPrice = new System.Windows.Forms.TextBox();
            this.txtbxRetailPrice = new System.Windows.Forms.TextBox();
            this.txtbxQuantity = new System.Windows.Forms.TextBox();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.DGVStock);
            this.groupBox1.Controls.Add(this.lblRowSignal);
            this.groupBox1.Controls.Add(this.lblCostPriceValid);
            this.groupBox1.Controls.Add(this.lblRetailPriceValid);
            this.groupBox1.Controls.Add(this.lblQuantityValid);
            this.groupBox1.Controls.Add(this.btnAddTStock);
            this.groupBox1.Controls.Add(this.lblVendor);
            this.groupBox1.Controls.Add(this.comboBoxVendor);
            this.groupBox1.Controls.Add(this.DateMFG);
            this.groupBox1.Controls.Add(this.lblDateMFG);
            this.groupBox1.Controls.Add(this.DateReceived);
            this.groupBox1.Controls.Add(this.DateExpiry);
            this.groupBox1.Controls.Add(this.lblProuct);
            this.groupBox1.Controls.Add(this.comboBoxProduct);
            this.groupBox1.Controls.Add(this.lblVolumeValid);
            this.groupBox1.Controls.Add(this.lblWeightValid);
            this.groupBox1.Controls.Add(this.lblSKUValid);
            this.groupBox1.Controls.Add(this.lblNameValid);
            this.groupBox1.Controls.Add(this.lbl_Volume);
            this.groupBox1.Controls.Add(this.lblDateReceived);
            this.groupBox1.Controls.Add(this.lbl_Weight);
            this.groupBox1.Controls.Add(this.lblS_Number);
            this.groupBox1.Controls.Add(this.txtbxCostPrice);
            this.groupBox1.Controls.Add(this.txtbxRetailPrice);
            this.groupBox1.Controls.Add(this.txtbxQuantity);
            this.groupBox1.Controls.Add(this.lblRetailPrice);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblCostPrice);
            this.groupBox1.Controls.Add(this.lblExpiryDate);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblSignUp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 540);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(774, 388);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(18, 20);
            this.lblTotalAmount.TabIndex = 85;
            this.lblTotalAmount.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(774, 355);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 84;
            this.lblTotal.Text = "Total";
            // 
            // DGVStock
            // 
            this.DGVStock.AllowUserToAddRows = false;
            this.DGVStock.AllowUserToDeleteRows = false;
            this.DGVStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStock.Location = new System.Drawing.Point(86, 300);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.ReadOnly = true;
            this.DGVStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStock.Size = new System.Drawing.Size(668, 138);
            this.DGVStock.TabIndex = 83;
            this.DGVStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick_1);
            // 
            // lblRowSignal
            // 
            this.lblRowSignal.AutoSize = true;
            this.lblRowSignal.ForeColor = System.Drawing.Color.Red;
            this.lblRowSignal.Location = new System.Drawing.Point(83, 277);
            this.lblRowSignal.Name = "lblRowSignal";
            this.lblRowSignal.Size = new System.Drawing.Size(0, 20);
            this.lblRowSignal.TabIndex = 82;
            // 
            // lblCostPriceValid
            // 
            this.lblCostPriceValid.AutoSize = true;
            this.lblCostPriceValid.ForeColor = System.Drawing.Color.Red;
            this.lblCostPriceValid.Location = new System.Drawing.Point(231, 260);
            this.lblCostPriceValid.Name = "lblCostPriceValid";
            this.lblCostPriceValid.Size = new System.Drawing.Size(0, 20);
            this.lblCostPriceValid.TabIndex = 81;
            // 
            // lblRetailPriceValid
            // 
            this.lblRetailPriceValid.AutoSize = true;
            this.lblRetailPriceValid.ForeColor = System.Drawing.Color.Red;
            this.lblRetailPriceValid.Location = new System.Drawing.Point(231, 208);
            this.lblRetailPriceValid.Name = "lblRetailPriceValid";
            this.lblRetailPriceValid.Size = new System.Drawing.Size(0, 20);
            this.lblRetailPriceValid.TabIndex = 80;
            // 
            // lblQuantityValid
            // 
            this.lblQuantityValid.AutoSize = true;
            this.lblQuantityValid.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityValid.Location = new System.Drawing.Point(231, 161);
            this.lblQuantityValid.Name = "lblQuantityValid";
            this.lblQuantityValid.Size = new System.Drawing.Size(0, 20);
            this.lblQuantityValid.TabIndex = 79;
            // 
            // btnAddTStock
            // 
            this.btnAddTStock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTStock.ForeColor = System.Drawing.Color.White;
            this.btnAddTStock.Location = new System.Drawing.Point(760, 300);
            this.btnAddTStock.Name = "btnAddTStock";
            this.btnAddTStock.Size = new System.Drawing.Size(75, 28);
            this.btnAddTStock.TabIndex = 78;
            this.btnAddTStock.Text = "Add";
            this.btnAddTStock.UseVisualStyleBackColor = false;
            this.btnAddTStock.Click += new System.EventHandler(this.btnAddTStock_Click);
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVendor.Location = new System.Drawing.Point(477, 237);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(69, 20);
            this.lblVendor.TabIndex = 75;
            this.lblVendor.Text = "Vendor :";
            // 
            // comboBoxVendor
            // 
            this.comboBoxVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVendor.FormattingEnabled = true;
            this.comboBoxVendor.Location = new System.Drawing.Point(630, 232);
            this.comboBoxVendor.Name = "comboBoxVendor";
            this.comboBoxVendor.Size = new System.Drawing.Size(198, 28);
            this.comboBoxVendor.Sorted = true;
            this.comboBoxVendor.TabIndex = 76;
            // 
            // DateMFG
            // 
            this.DateMFG.Location = new System.Drawing.Point(630, 82);
            this.DateMFG.Name = "DateMFG";
            this.DateMFG.Size = new System.Drawing.Size(200, 26);
            this.DateMFG.TabIndex = 72;
            // 
            // lblDateMFG
            // 
            this.lblDateMFG.AutoSize = true;
            this.lblDateMFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateMFG.Location = new System.Drawing.Point(475, 86);
            this.lblDateMFG.Name = "lblDateMFG";
            this.lblDateMFG.Size = new System.Drawing.Size(158, 20);
            this.lblDateMFG.TabIndex = 56;
            this.lblDateMFG.Text = "Manufacturing Date :";
            // 
            // DateReceived
            // 
            this.DateReceived.Location = new System.Drawing.Point(630, 185);
            this.DateReceived.Name = "DateReceived";
            this.DateReceived.Size = new System.Drawing.Size(200, 26);
            this.DateReceived.TabIndex = 74;
            // 
            // DateExpiry
            // 
            this.DateExpiry.Location = new System.Drawing.Point(630, 135);
            this.DateExpiry.Name = "DateExpiry";
            this.DateExpiry.Size = new System.Drawing.Size(200, 26);
            this.DateExpiry.TabIndex = 73;
            // 
            // lblProuct
            // 
            this.lblProuct.AutoSize = true;
            this.lblProuct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProuct.Location = new System.Drawing.Point(83, 88);
            this.lblProuct.Name = "lblProuct";
            this.lblProuct.Size = new System.Drawing.Size(72, 20);
            this.lblProuct.TabIndex = 70;
            this.lblProuct.Text = "Product :";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider"});
            this.comboBoxProduct.Location = new System.Drawing.Point(231, 83);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(203, 28);
            this.comboBoxProduct.Sorted = true;
            this.comboBoxProduct.TabIndex = 71;
            // 
            // lblVolumeValid
            // 
            this.lblVolumeValid.AutoSize = true;
            this.lblVolumeValid.ForeColor = System.Drawing.Color.Red;
            this.lblVolumeValid.Location = new System.Drawing.Point(231, 260);
            this.lblVolumeValid.Name = "lblVolumeValid";
            this.lblVolumeValid.Size = new System.Drawing.Size(0, 20);
            this.lblVolumeValid.TabIndex = 69;
            // 
            // lblWeightValid
            // 
            this.lblWeightValid.AutoSize = true;
            this.lblWeightValid.ForeColor = System.Drawing.Color.Red;
            this.lblWeightValid.Location = new System.Drawing.Point(231, 208);
            this.lblWeightValid.Name = "lblWeightValid";
            this.lblWeightValid.Size = new System.Drawing.Size(0, 20);
            this.lblWeightValid.TabIndex = 68;
            // 
            // lblSKUValid
            // 
            this.lblSKUValid.AutoSize = true;
            this.lblSKUValid.ForeColor = System.Drawing.Color.Red;
            this.lblSKUValid.Location = new System.Drawing.Point(231, 159);
            this.lblSKUValid.Name = "lblSKUValid";
            this.lblSKUValid.Size = new System.Drawing.Size(0, 20);
            this.lblSKUValid.TabIndex = 67;
            // 
            // lblNameValid
            // 
            this.lblNameValid.AutoSize = true;
            this.lblNameValid.Location = new System.Drawing.Point(235, 109);
            this.lblNameValid.Name = "lblNameValid";
            this.lblNameValid.Size = new System.Drawing.Size(0, 20);
            this.lblNameValid.TabIndex = 66;
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lbl_Volume.Location = new System.Drawing.Point(231, 260);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(13, 20);
            this.lbl_Volume.TabIndex = 65;
            this.lbl_Volume.Text = " ";
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateReceived.Location = new System.Drawing.Point(477, 187);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(122, 20);
            this.lblDateReceived.TabIndex = 58;
            this.lblDateReceived.Text = "Received Date :";
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lbl_Weight.Location = new System.Drawing.Point(231, 208);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(13, 20);
            this.lbl_Weight.TabIndex = 54;
            this.lbl_Weight.Text = " ";
            // 
            // lblS_Number
            // 
            this.lblS_Number.AutoSize = true;
            this.lblS_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblS_Number.Location = new System.Drawing.Point(231, 161);
            this.lblS_Number.Name = "lblS_Number";
            this.lblS_Number.Size = new System.Drawing.Size(13, 20);
            this.lblS_Number.TabIndex = 52;
            this.lblS_Number.Text = " ";
            // 
            // txtbxCostPrice
            // 
            this.txtbxCostPrice.Location = new System.Drawing.Point(231, 231);
            this.txtbxCostPrice.Name = "txtbxCostPrice";
            this.txtbxCostPrice.Size = new System.Drawing.Size(203, 26);
            this.txtbxCostPrice.TabIndex = 55;
            this.txtbxCostPrice.TextChanged += new System.EventHandler(this.txtbxCostPrice_TextChanged);
            // 
            // txtbxRetailPrice
            // 
            this.txtbxRetailPrice.Location = new System.Drawing.Point(231, 182);
            this.txtbxRetailPrice.Name = "txtbxRetailPrice";
            this.txtbxRetailPrice.Size = new System.Drawing.Size(203, 26);
            this.txtbxRetailPrice.TabIndex = 53;
            this.txtbxRetailPrice.TextChanged += new System.EventHandler(this.txtbxRetailPrice_TextChanged);
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.Location = new System.Drawing.Point(231, 132);
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.Size = new System.Drawing.Size(203, 26);
            this.txtbxQuantity.TabIndex = 51;
            this.txtbxQuantity.TextChanged += new System.EventHandler(this.txtbxQuantity_TextChanged);
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRetailPrice.Location = new System.Drawing.Point(81, 184);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(97, 20);
            this.lblRetailPrice.TabIndex = 47;
            this.lblRetailPrice.Text = "Retail Price :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantity.Location = new System.Drawing.Point(81, 135);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 20);
            this.lblQuantity.TabIndex = 46;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCostPrice.Location = new System.Drawing.Point(81, 233);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(89, 20);
            this.lblCostPrice.TabIndex = 48;
            this.lblCostPrice.Text = "Cost Price :";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExpiryDate.Location = new System.Drawing.Point(475, 138);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(98, 20);
            this.lblExpiryDate.TabIndex = 57;
            this.lblExpiryDate.Text = "Expiry Date :";
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
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(358, 17);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStock";
            this.Load += new System.EventHandler(this.frmAddStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCostPriceValid;
        private System.Windows.Forms.Label lblRetailPriceValid;
        private System.Windows.Forms.Label lblQuantityValid;
        private System.Windows.Forms.Button btnAddTStock;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.ComboBox comboBoxVendor;
        private System.Windows.Forms.DateTimePicker DateMFG;
        private System.Windows.Forms.Label lblDateMFG;
        private System.Windows.Forms.DateTimePicker DateReceived;
        private System.Windows.Forms.DateTimePicker DateExpiry;
        private System.Windows.Forms.Label lblProuct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label lblVolumeValid;
        private System.Windows.Forms.Label lblWeightValid;
        private System.Windows.Forms.Label lblSKUValid;
        private System.Windows.Forms.Label lblNameValid;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lblS_Number;
        private System.Windows.Forms.TextBox txtbxCostPrice;
        private System.Windows.Forms.TextBox txtbxRetailPrice;
        private System.Windows.Forms.TextBox txtbxQuantity;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblRowSignal;
        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}