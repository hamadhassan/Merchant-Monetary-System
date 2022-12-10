namespace Merchant_Monetary_System
{
    partial class frmAccountDetails
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
            this.gbx = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.datagvAccountDetails = new System.Windows.Forms.DataGridView();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.cmbxFiliter = new System.Windows.Forms.ComboBox();
            this.lblFiliter = new System.Windows.Forms.Label();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbxAttributes = new System.Windows.Forms.ComboBox();
            this.lblAttributes = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.cmbxDesignation = new System.Windows.Forms.ComboBox();
            this.lblAccountDetails = new System.Windows.Forms.Label();
            this.btnLoadRecords = new System.Windows.Forms.Button();
            this.lblDatagvSignal = new System.Windows.Forms.Label();
            this.gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvAccountDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.lblDatagvSignal);
            this.gbx.Controls.Add(this.btnLoadRecords);
            this.gbx.Controls.Add(this.btnEdit);
            this.gbx.Controls.Add(this.btnClose);
            this.gbx.Controls.Add(this.btnDelete);
            this.gbx.Controls.Add(this.datagvAccountDetails);
            this.gbx.Controls.Add(this.btnGo);
            this.gbx.Controls.Add(this.btnClearAll);
            this.gbx.Controls.Add(this.cmbxFiliter);
            this.gbx.Controls.Add(this.lblFiliter);
            this.gbx.Controls.Add(this.txtbxSearch);
            this.gbx.Controls.Add(this.lblSearch);
            this.gbx.Controls.Add(this.cmbxAttributes);
            this.gbx.Controls.Add(this.lblAttributes);
            this.gbx.Controls.Add(this.lblDesignation);
            this.gbx.Controls.Add(this.cmbxDesignation);
            this.gbx.Controls.Add(this.lblAccountDetails);
            this.gbx.Location = new System.Drawing.Point(12, 12);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(906, 516);
            this.gbx.TabIndex = 0;
            this.gbx.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(806, 480);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(614, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(231)))), ((int)(((byte)(100)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(710, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // datagvAccountDetails
            // 
            this.datagvAccountDetails.AllowUserToAddRows = false;
            this.datagvAccountDetails.AllowUserToDeleteRows = false;
            this.datagvAccountDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagvAccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvAccountDetails.Location = new System.Drawing.Point(15, 123);
            this.datagvAccountDetails.Name = "datagvAccountDetails";
            this.datagvAccountDetails.ReadOnly = true;
            this.datagvAccountDetails.Size = new System.Drawing.Size(881, 351);
            this.datagvAccountDetails.TabIndex = 52;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(806, 87);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(90, 30);
            this.btnGo.TabIndex = 51;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(710, 87);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 30);
            this.btnClearAll.TabIndex = 50;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // cmbxFiliter
            // 
            this.cmbxFiliter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFiliter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxFiliter.FormattingEnabled = true;
            this.cmbxFiliter.Items.AddRange(new object[] {
            "End With",
            "Ascending Order",
            "Decending Order",
            "Start With",
            "Contain"});
            this.cmbxFiliter.Location = new System.Drawing.Point(754, 52);
            this.cmbxFiliter.Name = "cmbxFiliter";
            this.cmbxFiliter.Size = new System.Drawing.Size(142, 28);
            this.cmbxFiliter.TabIndex = 49;
            // 
            // lblFiliter
            // 
            this.lblFiliter.AutoSize = true;
            this.lblFiliter.Location = new System.Drawing.Point(706, 56);
            this.lblFiliter.Name = "lblFiliter";
            this.lblFiliter.Size = new System.Drawing.Size(51, 20);
            this.lblFiliter.TabIndex = 48;
            this.lblFiliter.Text = "Filiter:";
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(554, 53);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(142, 26);
            this.txtbxSearch.TabIndex = 47;
            this.txtbxSearch.UseSystemPasswordChar = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(490, 56);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 46;
            this.lblSearch.Text = "Search:";
            // 
            // cmbxAttributes
            // 
            this.cmbxAttributes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAttributes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxAttributes.FormattingEnabled = true;
            this.cmbxAttributes.Items.AddRange(new object[] {
            "Name",
            "Username",
            "CNIC Number",
            "Gender",
            "Email",
            "Contact Number",
            "Home Address"});
            this.cmbxAttributes.Location = new System.Drawing.Point(337, 52);
            this.cmbxAttributes.Name = "cmbxAttributes";
            this.cmbxAttributes.Size = new System.Drawing.Size(142, 28);
            this.cmbxAttributes.TabIndex = 45;
            // 
            // lblAttributes
            // 
            this.lblAttributes.AutoSize = true;
            this.lblAttributes.Location = new System.Drawing.Point(264, 56);
            this.lblAttributes.Name = "lblAttributes";
            this.lblAttributes.Size = new System.Drawing.Size(74, 20);
            this.lblAttributes.TabIndex = 44;
            this.lblAttributes.Text = "Attribute:";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(11, 56);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(98, 20);
            this.lblDesignation.TabIndex = 43;
            this.lblDesignation.Text = "Designation:";
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
            this.cmbxDesignation.Location = new System.Drawing.Point(111, 52);
            this.cmbxDesignation.Name = "cmbxDesignation";
            this.cmbxDesignation.Size = new System.Drawing.Size(142, 28);
            this.cmbxDesignation.TabIndex = 42;
            // 
            // lblAccountDetails
            // 
            this.lblAccountDetails.AutoSize = true;
            this.lblAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountDetails.Location = new System.Drawing.Point(311, 10);
            this.lblAccountDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountDetails.Name = "lblAccountDetails";
            this.lblAccountDetails.Size = new System.Drawing.Size(269, 39);
            this.lblAccountDetails.TabIndex = 40;
            this.lblAccountDetails.Text = "Account Details";
            // 
            // btnLoadRecords
            // 
            this.btnLoadRecords.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRecords.Location = new System.Drawing.Point(386, 276);
            this.btnLoadRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadRecords.Name = "btnLoadRecords";
            this.btnLoadRecords.Size = new System.Drawing.Size(134, 26);
            this.btnLoadRecords.TabIndex = 56;
            this.btnLoadRecords.Text = "Load Records";
            this.btnLoadRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadRecords.UseVisualStyleBackColor = false;
            this.btnLoadRecords.Click += new System.EventHandler(this.btnLoadRecords_Click);
            // 
            // lblDatagvSignal
            // 
            this.lblDatagvSignal.AutoSize = true;
            this.lblDatagvSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblDatagvSignal.Location = new System.Drawing.Point(18, 490);
            this.lblDatagvSignal.Name = "lblDatagvSignal";
            this.lblDatagvSignal.Size = new System.Drawing.Size(13, 20);
            this.lblDatagvSignal.TabIndex = 57;
            this.lblDatagvSignal.Text = " ";
            // 
            // frmAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.gbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAccountDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAccountDetails";
            this.Load += new System.EventHandler(this.frmAccountDetails_Load);
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvAccountDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Label lblAccountDetails;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbxAttributes;
        private System.Windows.Forms.Label lblAttributes;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.ComboBox cmbxDesignation;
        private System.Windows.Forms.ComboBox cmbxFiliter;
        private System.Windows.Forms.Label lblFiliter;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView datagvAccountDetails;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLoadRecords;
        private System.Windows.Forms.Label lblDatagvSignal;
    }
}