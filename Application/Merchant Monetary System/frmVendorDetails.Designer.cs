namespace Merchant_Monetary_System
{
    partial class frmVendorDetails
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.datagvProductDetails = new System.Windows.Forms.DataGridView();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.cmbxFiliter = new System.Windows.Forms.ComboBox();
            this.lblFiliter = new System.Windows.Forms.Label();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbxAttributes = new System.Windows.Forms.ComboBox();
            this.lblAttributes = new System.Windows.Forms.Label();
            this.lblVendorDetails = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDatagvSignal);
            this.groupBox1.Controls.Add(this.btnLoadRecords);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.datagvProductDetails);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.cmbxFiliter);
            this.groupBox1.Controls.Add(this.lblFiliter);
            this.groupBox1.Controls.Add(this.txtbxSearch);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.cmbxAttributes);
            this.groupBox1.Controls.Add(this.lblAttributes);
            this.groupBox1.Controls.Add(this.lblVendorDetails);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblDatagvSignal
            // 
            this.lblDatagvSignal.AutoSize = true;
            this.lblDatagvSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblDatagvSignal.Location = new System.Drawing.Point(28, 500);
            this.lblDatagvSignal.Name = "lblDatagvSignal";
            this.lblDatagvSignal.Size = new System.Drawing.Size(13, 20);
            this.lblDatagvSignal.TabIndex = 89;
            this.lblDatagvSignal.Text = " ";
            // 
            // btnLoadRecords
            // 
            this.btnLoadRecords.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRecords.Location = new System.Drawing.Point(396, 286);
            this.btnLoadRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadRecords.Name = "btnLoadRecords";
            this.btnLoadRecords.Size = new System.Drawing.Size(114, 26);
            this.btnLoadRecords.TabIndex = 88;
            this.btnLoadRecords.Text = "Load Records";
            this.btnLoadRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadRecords.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(816, 490);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 87;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(624, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 86;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(231)))), ((int)(((byte)(100)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(720, 490);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // datagvProductDetails
            // 
            this.datagvProductDetails.AllowUserToAddRows = false;
            this.datagvProductDetails.AllowUserToDeleteRows = false;
            this.datagvProductDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvProductDetails.Location = new System.Drawing.Point(25, 133);
            this.datagvProductDetails.Name = "datagvProductDetails";
            this.datagvProductDetails.ReadOnly = true;
            this.datagvProductDetails.Size = new System.Drawing.Size(881, 351);
            this.datagvProductDetails.TabIndex = 84;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(784, 84);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(90, 30);
            this.btnGo.TabIndex = 83;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(688, 84);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 30);
            this.btnClearAll.TabIndex = 82;
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
            this.cmbxFiliter.Location = new System.Drawing.Point(517, 84);
            this.cmbxFiliter.Name = "cmbxFiliter";
            this.cmbxFiliter.Size = new System.Drawing.Size(142, 28);
            this.cmbxFiliter.TabIndex = 81;
            // 
            // lblFiliter
            // 
            this.lblFiliter.AutoSize = true;
            this.lblFiliter.Location = new System.Drawing.Point(469, 88);
            this.lblFiliter.Name = "lblFiliter";
            this.lblFiliter.Size = new System.Drawing.Size(51, 20);
            this.lblFiliter.TabIndex = 80;
            this.lblFiliter.Text = "Filiter:";
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(317, 85);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(142, 26);
            this.txtbxSearch.TabIndex = 79;
            this.txtbxSearch.UseSystemPasswordChar = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(253, 88);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 78;
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
            this.cmbxAttributes.Location = new System.Drawing.Point(100, 84);
            this.cmbxAttributes.Name = "cmbxAttributes";
            this.cmbxAttributes.Size = new System.Drawing.Size(142, 28);
            this.cmbxAttributes.TabIndex = 77;
            // 
            // lblAttributes
            // 
            this.lblAttributes.AutoSize = true;
            this.lblAttributes.Location = new System.Drawing.Point(27, 88);
            this.lblAttributes.Name = "lblAttributes";
            this.lblAttributes.Size = new System.Drawing.Size(74, 20);
            this.lblAttributes.TabIndex = 76;
            this.lblAttributes.Text = "Attribute:";
            // 
            // lblVendorDetails
            // 
            this.lblVendorDetails.AutoSize = true;
            this.lblVendorDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorDetails.Location = new System.Drawing.Point(321, 20);
            this.lblVendorDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendorDetails.Name = "lblVendorDetails";
            this.lblVendorDetails.Size = new System.Drawing.Size(255, 39);
            this.lblVendorDetails.TabIndex = 75;
            this.lblVendorDetails.Text = "Vendor Details";
            // 
            // frmVendorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVendorDetails";
            this.Text = "frmVendorDetails";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvProductDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDatagvSignal;
        private System.Windows.Forms.Button btnLoadRecords;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView datagvProductDetails;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ComboBox cmbxFiliter;
        private System.Windows.Forms.Label lblFiliter;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbxAttributes;
        private System.Windows.Forms.Label lblAttributes;
        private System.Windows.Forms.Label lblVendorDetails;
    }
}