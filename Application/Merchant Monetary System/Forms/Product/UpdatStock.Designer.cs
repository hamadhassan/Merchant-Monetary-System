namespace Merchant_Monetary_System.Forms.Product
{
    partial class UpdatStock
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
            this.lblVendor = new System.Windows.Forms.Label();
            this.comboBoxVendor = new System.Windows.Forms.ComboBox();
            this.DateMFG = new System.Windows.Forms.DateTimePicker();
            this.lblDateMFG = new System.Windows.Forms.Label();
            this.DateReceived = new System.Windows.Forms.DateTimePicker();
            this.DateExpiry = new System.Windows.Forms.DateTimePicker();
            this.lblProuct = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.txtbxCostPrice = new System.Windows.Forms.TextBox();
            this.txtbxRetailPrice = new System.Windows.Forms.TextBox();
            this.txtbxQuantity = new System.Windows.Forms.TextBox();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblUpdateStockInfo = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCostPriceValid = new System.Windows.Forms.Label();
            this.lblRetailPriceValid = new System.Windows.Forms.Label();
            this.lblQuantityValid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCostPriceValid);
            this.groupBox1.Controls.Add(this.lblRetailPriceValid);
            this.groupBox1.Controls.Add(this.lblQuantityValid);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblVendor);
            this.groupBox1.Controls.Add(this.comboBoxVendor);
            this.groupBox1.Controls.Add(this.DateMFG);
            this.groupBox1.Controls.Add(this.lblDateMFG);
            this.groupBox1.Controls.Add(this.DateReceived);
            this.groupBox1.Controls.Add(this.DateExpiry);
            this.groupBox1.Controls.Add(this.lblProuct);
            this.groupBox1.Controls.Add(this.comboBoxProduct);
            this.groupBox1.Controls.Add(this.lblDateReceived);
            this.groupBox1.Controls.Add(this.txtbxCostPrice);
            this.groupBox1.Controls.Add(this.txtbxRetailPrice);
            this.groupBox1.Controls.Add(this.txtbxQuantity);
            this.groupBox1.Controls.Add(this.lblRetailPrice);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblCostPrice);
            this.groupBox1.Controls.Add(this.lblExpiryDate);
            this.groupBox1.Controls.Add(this.lblUpdateStockInfo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVendor.Location = new System.Drawing.Point(470, 266);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(69, 20);
            this.lblVendor.TabIndex = 92;
            this.lblVendor.Text = "Vendor :";
            // 
            // comboBoxVendor
            // 
            this.comboBoxVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVendor.FormattingEnabled = true;
            this.comboBoxVendor.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider"});
            this.comboBoxVendor.Location = new System.Drawing.Point(623, 261);
            this.comboBoxVendor.Name = "comboBoxVendor";
            this.comboBoxVendor.Size = new System.Drawing.Size(198, 28);
            this.comboBoxVendor.Sorted = true;
            this.comboBoxVendor.TabIndex = 93;
            // 
            // DateMFG
            // 
            this.DateMFG.Location = new System.Drawing.Point(623, 111);
            this.DateMFG.Name = "DateMFG";
            this.DateMFG.Size = new System.Drawing.Size(200, 26);
            this.DateMFG.TabIndex = 89;
            // 
            // lblDateMFG
            // 
            this.lblDateMFG.AutoSize = true;
            this.lblDateMFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateMFG.Location = new System.Drawing.Point(468, 115);
            this.lblDateMFG.Name = "lblDateMFG";
            this.lblDateMFG.Size = new System.Drawing.Size(158, 20);
            this.lblDateMFG.TabIndex = 84;
            this.lblDateMFG.Text = "Manufacturing Date :";
            // 
            // DateReceived
            // 
            this.DateReceived.Location = new System.Drawing.Point(623, 214);
            this.DateReceived.Name = "DateReceived";
            this.DateReceived.Size = new System.Drawing.Size(200, 26);
            this.DateReceived.TabIndex = 91;
            // 
            // DateExpiry
            // 
            this.DateExpiry.Location = new System.Drawing.Point(623, 164);
            this.DateExpiry.Name = "DateExpiry";
            this.DateExpiry.Size = new System.Drawing.Size(200, 26);
            this.DateExpiry.TabIndex = 90;
            // 
            // lblProuct
            // 
            this.lblProuct.AutoSize = true;
            this.lblProuct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProuct.Location = new System.Drawing.Point(76, 117);
            this.lblProuct.Name = "lblProuct";
            this.lblProuct.Size = new System.Drawing.Size(72, 20);
            this.lblProuct.TabIndex = 87;
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
            this.comboBoxProduct.Location = new System.Drawing.Point(224, 112);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(203, 28);
            this.comboBoxProduct.Sorted = true;
            this.comboBoxProduct.TabIndex = 88;
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateReceived.Location = new System.Drawing.Point(470, 216);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(122, 20);
            this.lblDateReceived.TabIndex = 86;
            this.lblDateReceived.Text = "Received Date :";
            // 
            // txtbxCostPrice
            // 
            this.txtbxCostPrice.Location = new System.Drawing.Point(224, 260);
            this.txtbxCostPrice.Name = "txtbxCostPrice";
            this.txtbxCostPrice.Size = new System.Drawing.Size(203, 26);
            this.txtbxCostPrice.TabIndex = 83;
            this.txtbxCostPrice.TextChanged += new System.EventHandler(this.txtbxCostPrice_TextChanged);
            // 
            // txtbxRetailPrice
            // 
            this.txtbxRetailPrice.Location = new System.Drawing.Point(224, 211);
            this.txtbxRetailPrice.Name = "txtbxRetailPrice";
            this.txtbxRetailPrice.Size = new System.Drawing.Size(203, 26);
            this.txtbxRetailPrice.TabIndex = 82;
            this.txtbxRetailPrice.TextChanged += new System.EventHandler(this.txtbxRetailPrice_TextChanged);
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.Location = new System.Drawing.Point(224, 161);
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.Size = new System.Drawing.Size(203, 26);
            this.txtbxQuantity.TabIndex = 81;
            this.txtbxQuantity.TextChanged += new System.EventHandler(this.txtbxQuantity_TextChanged);
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRetailPrice.Location = new System.Drawing.Point(74, 213);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(97, 20);
            this.lblRetailPrice.TabIndex = 79;
            this.lblRetailPrice.Text = "Retail Price :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantity.Location = new System.Drawing.Point(74, 164);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 20);
            this.lblQuantity.TabIndex = 78;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCostPrice.Location = new System.Drawing.Point(74, 262);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(89, 20);
            this.lblCostPrice.TabIndex = 80;
            this.lblCostPrice.Text = "Cost Price :";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExpiryDate.Location = new System.Drawing.Point(468, 167);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(98, 20);
            this.lblExpiryDate.TabIndex = 85;
            this.lblExpiryDate.Text = "Expiry Date :";
            // 
            // lblUpdateStockInfo
            // 
            this.lblUpdateStockInfo.AutoSize = true;
            this.lblUpdateStockInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStockInfo.Location = new System.Drawing.Point(231, 40);
            this.lblUpdateStockInfo.Name = "lblUpdateStockInfo";
            this.lblUpdateStockInfo.Size = new System.Drawing.Size(424, 39);
            this.lblUpdateStockInfo.TabIndex = 77;
            this.lblUpdateStockInfo.Text = "Update Stock Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(566, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 30);
            this.btnUpdate.TabIndex = 96;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(356, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 30);
            this.btnClear.TabIndex = 95;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(140, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblCostPriceValid
            // 
            this.lblCostPriceValid.AutoSize = true;
            this.lblCostPriceValid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblCostPriceValid.Location = new System.Drawing.Point(226, 289);
            this.lblCostPriceValid.Name = "lblCostPriceValid";
            this.lblCostPriceValid.Size = new System.Drawing.Size(13, 20);
            this.lblCostPriceValid.TabIndex = 99;
            this.lblCostPriceValid.Text = " ";
            // 
            // lblRetailPriceValid
            // 
            this.lblRetailPriceValid.AutoSize = true;
            this.lblRetailPriceValid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblRetailPriceValid.Location = new System.Drawing.Point(226, 237);
            this.lblRetailPriceValid.Name = "lblRetailPriceValid";
            this.lblRetailPriceValid.Size = new System.Drawing.Size(13, 20);
            this.lblRetailPriceValid.TabIndex = 98;
            this.lblRetailPriceValid.Text = " ";
            // 
            // lblQuantityValid
            // 
            this.lblQuantityValid.AutoSize = true;
            this.lblQuantityValid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblQuantityValid.Location = new System.Drawing.Point(226, 190);
            this.lblQuantityValid.Name = "lblQuantityValid";
            this.lblQuantityValid.Size = new System.Drawing.Size(13, 20);
            this.lblQuantityValid.TabIndex = 97;
            this.lblQuantityValid.Text = " ";
            // 
            // UpdatStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatStock";
            this.Text = "UpdatStock";
            this.Load += new System.EventHandler(this.UpdatStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.ComboBox comboBoxVendor;
        private System.Windows.Forms.DateTimePicker DateMFG;
        private System.Windows.Forms.Label lblDateMFG;
        private System.Windows.Forms.DateTimePicker DateReceived;
        private System.Windows.Forms.DateTimePicker DateExpiry;
        private System.Windows.Forms.Label lblProuct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.TextBox txtbxCostPrice;
        private System.Windows.Forms.TextBox txtbxRetailPrice;
        private System.Windows.Forms.TextBox txtbxQuantity;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblUpdateStockInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCostPriceValid;
        private System.Windows.Forms.Label lblRetailPriceValid;
        private System.Windows.Forms.Label lblQuantityValid;
    }
}