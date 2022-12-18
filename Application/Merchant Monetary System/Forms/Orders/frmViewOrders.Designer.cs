namespace Merchant_Monetary_System
{
    partial class frmViewOrders
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
            this.lblDatagvSignal = new System.Windows.Forms.Label();
            this.btnLoadRecords = new System.Windows.Forms.Button();
            this.datagvProductDetails = new System.Windows.Forms.DataGridView();
            this.btnonfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtPriceMax = new System.Windows.Forms.TextBox();
            this.txtbxPRICEmin = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSortedBy = new System.Windows.Forms.Label();
            this.cmboxSortedBy = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbxCategory = new System.Windows.Forms.ComboBox();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagvProductDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatagvSignal
            // 
            this.lblDatagvSignal.AutoSize = true;
            this.lblDatagvSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDatagvSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblDatagvSignal.Location = new System.Drawing.Point(21, 498);
            this.lblDatagvSignal.Name = "lblDatagvSignal";
            this.lblDatagvSignal.Size = new System.Drawing.Size(10, 13);
            this.lblDatagvSignal.TabIndex = 83;
            this.lblDatagvSignal.Text = " ";
            // 
            // btnLoadRecords
            // 
            this.btnLoadRecords.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRecords.Location = new System.Drawing.Point(396, 248);
            this.btnLoadRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadRecords.Name = "btnLoadRecords";
            this.btnLoadRecords.Size = new System.Drawing.Size(114, 36);
            this.btnLoadRecords.TabIndex = 82;
            this.btnLoadRecords.Text = "Load Records";
            this.btnLoadRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadRecords.UseVisualStyleBackColor = false;
            this.btnLoadRecords.Click += new System.EventHandler(this.btnLoadRecords_Click_1);
            // 
            // datagvProductDetails
            // 
            this.datagvProductDetails.AllowUserToAddRows = false;
            this.datagvProductDetails.AllowUserToDeleteRows = false;
            this.datagvProductDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvProductDetails.Location = new System.Drawing.Point(25, 126);
            this.datagvProductDetails.Name = "datagvProductDetails";
            this.datagvProductDetails.ReadOnly = true;
            this.datagvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagvProductDetails.Size = new System.Drawing.Size(881, 355);
            this.datagvProductDetails.TabIndex = 81;
            this.datagvProductDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvProductDetails_CellContentClick);
            // 
            // btnonfirm
            // 
            this.btnonfirm.BackColor = System.Drawing.Color.DarkGreen;
            this.btnonfirm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnonfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnonfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnonfirm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnonfirm.Location = new System.Drawing.Point(798, 488);
            this.btnonfirm.Name = "btnonfirm";
            this.btnonfirm.Size = new System.Drawing.Size(90, 34);
            this.btnonfirm.TabIndex = 75;
            this.btnonfirm.Text = "Confirm Order";
            this.btnonfirm.UseVisualStyleBackColor = false;
            this.btnonfirm.Click += new System.EventHandler(this.btnonfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(606, 488);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 34);
            this.btnBack.TabIndex = 74;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(231)))), ((int)(((byte)(100)))));
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.ForeColor = System.Drawing.Color.Black;
            this.btnClearAll.Location = new System.Drawing.Point(702, 488);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 34);
            this.btnClearAll.TabIndex = 73;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // txtPriceMax
            // 
            this.txtPriceMax.Location = new System.Drawing.Point(862, 95);
            this.txtPriceMax.Name = "txtPriceMax";
            this.txtPriceMax.Size = new System.Drawing.Size(43, 26);
            this.txtPriceMax.TabIndex = 78;
            this.txtPriceMax.Text = "Max";
            // 
            // txtbxPRICEmin
            // 
            this.txtbxPRICEmin.Location = new System.Drawing.Point(813, 95);
            this.txtbxPRICEmin.Name = "txtbxPRICEmin";
            this.txtbxPRICEmin.Size = new System.Drawing.Size(43, 26);
            this.txtbxPRICEmin.TabIndex = 77;
            this.txtbxPRICEmin.Text = "Min";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(765, 98);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 76;
            this.lblPrice.Text = "Price :";
            // 
            // lblSortedBy
            // 
            this.lblSortedBy.AutoSize = true;
            this.lblSortedBy.Location = new System.Drawing.Point(12, 95);
            this.lblSortedBy.Name = "lblSortedBy";
            this.lblSortedBy.Size = new System.Drawing.Size(91, 20);
            this.lblSortedBy.TabIndex = 71;
            this.lblSortedBy.Text = " Sorted By :";
            // 
            // cmboxSortedBy
            // 
            this.cmboxSortedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxSortedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmboxSortedBy.FormattingEnabled = true;
            this.cmboxSortedBy.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider",
            "Warehouse Manager"});
            this.cmboxSortedBy.Location = new System.Drawing.Point(109, 92);
            this.cmboxSortedBy.Name = "cmboxSortedBy";
            this.cmboxSortedBy.Size = new System.Drawing.Size(107, 28);
            this.cmboxSortedBy.TabIndex = 70;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 37);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 69;
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
            "Rider",
            "Warehouse Manager"});
            this.cmbxCategory.Location = new System.Drawing.Point(115, 34);
            this.cmbxCategory.Name = "cmbxCategory";
            this.cmbxCategory.Size = new System.Drawing.Size(159, 28);
            this.cmbxCategory.TabIndex = 68;
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.Location = new System.Drawing.Point(375, 0);
            this.lblProductDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(240, 39);
            this.lblProductDetails.TabIndex = 67;
            this.lblProductDetails.Text = " Order Details";
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(429, 39);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(476, 26);
            this.txtbxSearch.TabIndex = 66;
            this.txtbxSearch.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDatagvSignal);
            this.groupBox1.Controls.Add(this.btnLoadRecords);
            this.groupBox1.Controls.Add(this.datagvProductDetails);
            this.groupBox1.Controls.Add(this.btnonfirm);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.txtPriceMax);
            this.groupBox1.Controls.Add(this.txtbxPRICEmin);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblSortedBy);
            this.groupBox1.Controls.Add(this.cmboxSortedBy);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.cmbxCategory);
            this.groupBox1.Controls.Add(this.lblProductDetails);
            this.groupBox1.Controls.Add(this.txtbxSearch);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 540);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(360, 42);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 65;
            this.lblSearch.Text = "Search:";
            // 
            // frmViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmViewOrders";
            this.Text = "frmViewOrders";
            ((System.ComponentModel.ISupportInitialize)(this.datagvProductDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDatagvSignal;
        private System.Windows.Forms.Button btnLoadRecords;
        private System.Windows.Forms.DataGridView datagvProductDetails;
        private System.Windows.Forms.Button btnonfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtPriceMax;
        private System.Windows.Forms.TextBox txtbxPRICEmin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSortedBy;
        private System.Windows.Forms.ComboBox cmboxSortedBy;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbxCategory;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSearch;
    }
}