namespace Merchant_Monetary_System
{
    partial class frmTakeOrder
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
            this.lblDatagvSignal = new System.Windows.Forms.Label();
            this.btnLoadRecords = new System.Windows.Forms.Button();
            this.datagvProductDetails = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.checkbxStock = new System.Windows.Forms.CheckBox();
            this.lblAvalibility = new System.Windows.Forms.Label();
            this.txtPriceMax = new System.Windows.Forms.TextBox();
            this.txtbxPRICEmin = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWareenty = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.cmbxRatings = new System.Windows.Forms.ComboBox();
            this.lblSortedBy = new System.Windows.Forms.Label();
            this.cmboxSortedBy = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbxCategory = new System.Windows.Forms.ComboBox();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDatagvSignal);
            this.groupBox1.Controls.Add(this.btnLoadRecords);
            this.groupBox1.Controls.Add(this.datagvProductDetails);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.checkbxStock);
            this.groupBox1.Controls.Add(this.lblAvalibility);
            this.groupBox1.Controls.Add(this.txtPriceMax);
            this.groupBox1.Controls.Add(this.txtbxPRICEmin);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblWareenty);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblRating);
            this.groupBox1.Controls.Add(this.cmbxRatings);
            this.groupBox1.Controls.Add(this.lblSortedBy);
            this.groupBox1.Controls.Add(this.cmboxSortedBy);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.cmbxCategory);
            this.groupBox1.Controls.Add(this.lblProductDetails);
            this.groupBox1.Controls.Add(this.txtbxSearch);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Location = new System.Drawing.Point(2, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDatagvSignal
            // 
            this.lblDatagvSignal.AutoSize = true;
            this.lblDatagvSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblDatagvSignal.Location = new System.Drawing.Point(21, 498);
            this.lblDatagvSignal.Name = "lblDatagvSignal";
            this.lblDatagvSignal.Size = new System.Drawing.Size(13, 20);
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
            this.btnLoadRecords.Click += new System.EventHandler(this.btnLoadRecords_Click);
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
            this.datagvProductDetails.Size = new System.Drawing.Size(881, 355);
            this.datagvProductDetails.TabIndex = 81;
            this.datagvProductDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvProductDetails_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(798, 488);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 34);
            this.btnEdit.TabIndex = 75;
            this.btnEdit.Text = "Veiw Cart";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(606, 488);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // 
            // checkbxStock
            // 
            this.checkbxStock.AutoSize = true;
            this.checkbxStock.Location = new System.Drawing.Point(841, 95);
            this.checkbxStock.Name = "checkbxStock";
            this.checkbxStock.Size = new System.Drawing.Size(83, 24);
            this.checkbxStock.TabIndex = 80;
            this.checkbxStock.Text = "InStock";
            this.checkbxStock.UseVisualStyleBackColor = true;
            // 
            // lblAvalibility
            // 
            this.lblAvalibility.AutoSize = true;
            this.lblAvalibility.Location = new System.Drawing.Point(760, 96);
            this.lblAvalibility.Name = "lblAvalibility";
            this.lblAvalibility.Size = new System.Drawing.Size(75, 20);
            this.lblAvalibility.TabIndex = 79;
            this.lblAvalibility.Text = "Availibility";
            // 
            // txtPriceMax
            // 
            this.txtPriceMax.Location = new System.Drawing.Point(711, 93);
            this.txtPriceMax.Name = "txtPriceMax";
            this.txtPriceMax.Size = new System.Drawing.Size(43, 26);
            this.txtPriceMax.TabIndex = 78;
            this.txtPriceMax.Text = "Max";
            // 
            // txtbxPRICEmin
            // 
            this.txtbxPRICEmin.Location = new System.Drawing.Point(662, 93);
            this.txtbxPRICEmin.Name = "txtbxPRICEmin";
            this.txtbxPRICEmin.Size = new System.Drawing.Size(43, 26);
            this.txtbxPRICEmin.TabIndex = 77;
            this.txtbxPRICEmin.Text = "Min";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(614, 96);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 76;
            this.lblPrice.Text = "Price :";
            // 
            // lblWareenty
            // 
            this.lblWareenty.AutoSize = true;
            this.lblWareenty.Location = new System.Drawing.Point(385, 95);
            this.lblWareenty.Name = "lblWareenty";
            this.lblWareenty.Size = new System.Drawing.Size(119, 20);
            this.lblWareenty.TabIndex = 75;
            this.lblWareenty.Text = "Warranty Type :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider",
            "Warehouse Manager"});
            this.comboBox1.Location = new System.Drawing.Point(507, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 28);
            this.comboBox1.TabIndex = 74;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(229, 95);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(72, 20);
            this.lblRating.TabIndex = 73;
            this.lblRating.Text = "Ratings :";
            // 
            // cmbxRatings
            // 
            this.cmbxRatings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxRatings.FormattingEnabled = true;
            this.cmbxRatings.Items.AddRange(new object[] {
            "CEO",
            "Employee",
            "Rider",
            "Warehouse Manager"});
            this.cmbxRatings.Location = new System.Drawing.Point(319, 92);
            this.cmbxRatings.Name = "cmbxRatings";
            this.cmbxRatings.Size = new System.Drawing.Size(60, 28);
            this.cmbxRatings.TabIndex = 72;
            this.cmbxRatings.SelectedIndexChanged += new System.EventHandler(this.cmbxRatings_SelectedIndexChanged);
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
            this.lblProductDetails.Size = new System.Drawing.Size(198, 39);
            this.lblProductDetails.TabIndex = 67;
            this.lblProductDetails.Text = "Take Order";
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(429, 39);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(476, 26);
            this.txtbxSearch.TabIndex = 66;
            this.txtbxSearch.UseSystemPasswordChar = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(360, 42);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 65;
            this.lblSearch.Text = "Search:";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // frmTakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTakeOrder";
            this.Text = "frmTakeOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvProductDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Label lblWareenty;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cmbxRatings;
        private System.Windows.Forms.Label lblSortedBy;
        private System.Windows.Forms.ComboBox cmboxSortedBy;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbxCategory;
        private System.Windows.Forms.TextBox txtbxPRICEmin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox checkbxStock;
        private System.Windows.Forms.Label lblAvalibility;
        private System.Windows.Forms.TextBox txtPriceMax;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnLoadRecords;
        private System.Windows.Forms.DataGridView datagvProductDetails;
        private System.Windows.Forms.Label lblDatagvSignal;
    }
}