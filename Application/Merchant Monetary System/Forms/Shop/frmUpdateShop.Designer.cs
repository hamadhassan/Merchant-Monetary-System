namespace Merchant_Monetary_System
{
    partial class frmUpdateShop
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
            this.Shop = new System.Windows.Forms.GroupBox();
            this.lblShopSignal = new System.Windows.Forms.Label();
            this.lblShopName = new System.Windows.Forms.Label();
            this.txtbxShopName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbxCity = new System.Windows.Forms.ComboBox();
            this.cmbxState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.comboboxArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDesignationSingal = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnUpdateShop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Shop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Shop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDesignationSingal);
            this.groupBox1.Controls.Add(this.lblSignUp);
            this.groupBox1.Controls.Add(this.btnUpdateShop);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 477);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Shop
            // 
            this.Shop.BackColor = System.Drawing.Color.Transparent;
            this.Shop.Controls.Add(this.lblShopSignal);
            this.Shop.Controls.Add(this.lblShopName);
            this.Shop.Controls.Add(this.txtbxShopName);
            this.Shop.Controls.Add(this.lblCity);
            this.Shop.Controls.Add(this.cmbxCity);
            this.Shop.Controls.Add(this.cmbxState);
            this.Shop.Controls.Add(this.lblState);
            this.Shop.Controls.Add(this.lblArea);
            this.Shop.Controls.Add(this.comboboxArea);
            this.Shop.Location = new System.Drawing.Point(261, 122);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(394, 248);
            this.Shop.TabIndex = 85;
            this.Shop.TabStop = false;
            this.Shop.Text = "Shop";
            // 
            // lblShopSignal
            // 
            this.lblShopSignal.AutoSize = true;
            this.lblShopSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblShopSignal.Location = new System.Drawing.Point(182, 55);
            this.lblShopSignal.Name = "lblShopSignal";
            this.lblShopSignal.Size = new System.Drawing.Size(13, 20);
            this.lblShopSignal.TabIndex = 86;
            this.lblShopSignal.Text = " ";
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Location = new System.Drawing.Point(14, 29);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(99, 20);
            this.lblShopName.TabIndex = 45;
            this.lblShopName.Text = "Shop name :";
            // 
            // txtbxShopName
            // 
            this.txtbxShopName.Location = new System.Drawing.Point(180, 26);
            this.txtbxShopName.Name = "txtbxShopName";
            this.txtbxShopName.Size = new System.Drawing.Size(203, 26);
            this.txtbxShopName.TabIndex = 50;
            this.txtbxShopName.TextChanged += new System.EventHandler(this.txtbxShopName_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(10, 82);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 20);
            this.lblCity.TabIndex = 40;
            this.lblCity.Text = " City :";
            // 
            // cmbxCity
            // 
            this.cmbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxCity.FormattingEnabled = true;
            this.cmbxCity.Items.AddRange(new object[] {
            "Lahore"});
            this.cmbxCity.Location = new System.Drawing.Point(180, 77);
            this.cmbxCity.Name = "cmbxCity";
            this.cmbxCity.Size = new System.Drawing.Size(203, 28);
            this.cmbxCity.Sorted = true;
            this.cmbxCity.TabIndex = 37;
            // 
            // cmbxState
            // 
            this.cmbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxState.FormattingEnabled = true;
            this.cmbxState.Items.AddRange(new object[] {
            "Punjab"});
            this.cmbxState.Location = new System.Drawing.Point(180, 180);
            this.cmbxState.Name = "cmbxState";
            this.cmbxState.Size = new System.Drawing.Size(203, 28);
            this.cmbxState.Sorted = true;
            this.cmbxState.TabIndex = 62;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(13, 187);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(56, 20);
            this.lblState.TabIndex = 77;
            this.lblState.Text = "State :";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(14, 133);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(51, 20);
            this.lblArea.TabIndex = 80;
            this.lblArea.Text = "Area :";
            // 
            // comboboxArea
            // 
            this.comboboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxArea.FormattingEnabled = true;
            this.comboboxArea.Items.AddRange(new object[] {
            "Model Town"});
            this.comboboxArea.Location = new System.Drawing.Point(180, 128);
            this.comboboxArea.Name = "comboboxArea";
            this.comboboxArea.Size = new System.Drawing.Size(203, 28);
            this.comboboxArea.Sorted = true;
            this.comboboxArea.TabIndex = 78;
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
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(348, 52);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(227, 39);
            this.lblSignUp.TabIndex = 36;
            this.lblSignUp.Text = "Update Shop";
            // 
            // btnUpdateShop
            // 
            this.btnUpdateShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnUpdateShop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateShop.ForeColor = System.Drawing.Color.White;
            this.btnUpdateShop.Location = new System.Drawing.Point(577, 399);
            this.btnUpdateShop.Name = "btnUpdateShop";
            this.btnUpdateShop.Size = new System.Drawing.Size(200, 30);
            this.btnUpdateShop.TabIndex = 61;
            this.btnUpdateShop.Text = "Update Shop";
            this.btnUpdateShop.UseVisualStyleBackColor = false;
            this.btnUpdateShop.Click += new System.EventHandler(this.btnUpdateShop_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(364, 399);
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
            this.btnClose.Location = new System.Drawing.Point(153, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUpdateShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdateShop";
            this.Text = "frmUpdateShop";
            this.Load += new System.EventHandler(this.frmUpdateShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Shop.ResumeLayout(false);
            this.Shop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Shop;
        private System.Windows.Forms.Label lblShopSignal;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.TextBox txtbxShopName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbxCity;
        private System.Windows.Forms.ComboBox cmbxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox comboboxArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDesignationSingal;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnUpdateShop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}