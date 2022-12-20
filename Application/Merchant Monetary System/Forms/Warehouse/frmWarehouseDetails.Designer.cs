namespace Merchant_Monetary_System
{
    partial class frmWarehouseDetails
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
            this.btnLoadRecords = new System.Windows.Forms.Button();
            this.lblAccountDetails = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAttributes = new System.Windows.Forms.Label();
            this.cmbxAttributes = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.lblFiliter = new System.Windows.Forms.Label();
            this.cmbxFiliter = new System.Windows.Forms.ComboBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.datagvWarehouseDetails = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDatagvSignal = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbx.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvWarehouseDetails)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.btnLoadRecords);
            this.gbx.Controls.Add(this.lblAccountDetails);
            this.gbx.Controls.Add(this.tableLayoutPanel1);
            this.gbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx.Location = new System.Drawing.Point(3, 3);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(924, 534);
            this.gbx.TabIndex = 1;
            this.gbx.TabStop = false;
            // 
            // btnLoadRecords
            // 
            this.btnLoadRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadRecords.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRecords.Location = new System.Drawing.Point(386, 276);
            this.btnLoadRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadRecords.Name = "btnLoadRecords";
            this.btnLoadRecords.Size = new System.Drawing.Size(155, 55);
            this.btnLoadRecords.TabIndex = 56;
            this.btnLoadRecords.Text = "Load Records";
            this.btnLoadRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadRecords.UseVisualStyleBackColor = false;
            this.btnLoadRecords.Click += new System.EventHandler(this.btnLoadRecords_Click);
            // 
            // lblAccountDetails
            // 
            this.lblAccountDetails.AutoSize = true;
            this.lblAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountDetails.Location = new System.Drawing.Point(292, 28);
            this.lblAccountDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountDetails.Name = "lblAccountDetails";
            this.lblAccountDetails.Size = new System.Drawing.Size(322, 39);
            this.lblAccountDetails.TabIndex = 40;
            this.lblAccountDetails.Text = "Warehouse Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.datagvWarehouseDetails, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.21611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.858546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.10216F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.072691F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 509);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.8421F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.32456F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.223684F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.88597F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.236842F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.43421F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.74561F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.19737F));
            this.tableLayoutPanel3.Controls.Add(this.lblAttributes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbxAttributes, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSearch, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtbxSearch, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblFiliter, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbxFiliter, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClearAll, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGo, 7, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(912, 35);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblAttributes
            // 
            this.lblAttributes.AutoSize = true;
            this.lblAttributes.Location = new System.Drawing.Point(3, 0);
            this.lblAttributes.Name = "lblAttributes";
            this.lblAttributes.Size = new System.Drawing.Size(74, 20);
            this.lblAttributes.TabIndex = 44;
            this.lblAttributes.Text = "Attribute:";
            // 
            // cmbxAttributes
            // 
            this.cmbxAttributes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAttributes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxAttributes.FormattingEnabled = true;
            this.cmbxAttributes.Items.AddRange(new object[] {
            "Name"});
            this.cmbxAttributes.Location = new System.Drawing.Point(111, 3);
            this.cmbxAttributes.Name = "cmbxAttributes";
            this.cmbxAttributes.Size = new System.Drawing.Size(142, 28);
            this.cmbxAttributes.TabIndex = 45;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(269, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 46;
            this.lblSearch.Text = "Search:";
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(344, 3);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(142, 26);
            this.txtbxSearch.TabIndex = 47;
            this.txtbxSearch.UseSystemPasswordChar = true;
            // 
            // lblFiliter
            // 
            this.lblFiliter.AutoSize = true;
            this.lblFiliter.Location = new System.Drawing.Point(498, 0);
            this.lblFiliter.Name = "lblFiliter";
            this.lblFiliter.Size = new System.Drawing.Size(51, 20);
            this.lblFiliter.TabIndex = 48;
            this.lblFiliter.Text = "Filiter:";
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
            this.cmbxFiliter.Location = new System.Drawing.Point(564, 3);
            this.cmbxFiliter.Name = "cmbxFiliter";
            this.cmbxFiliter.Size = new System.Drawing.Size(142, 28);
            this.cmbxFiliter.TabIndex = 49;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(723, 3);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 29);
            this.btnClearAll.TabIndex = 50;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(821, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(88, 29);
            this.btnGo.TabIndex = 51;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            // 
            // datagvWarehouseDetails
            // 
            this.datagvWarehouseDetails.AllowUserToAddRows = false;
            this.datagvWarehouseDetails.AllowUserToDeleteRows = false;
            this.datagvWarehouseDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagvWarehouseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvWarehouseDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvWarehouseDetails.Location = new System.Drawing.Point(3, 97);
            this.datagvWarehouseDetails.Name = "datagvWarehouseDetails";
            this.datagvWarehouseDetails.ReadOnly = true;
            this.datagvWarehouseDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagvWarehouseDetails.Size = new System.Drawing.Size(912, 371);
            this.datagvWarehouseDetails.TabIndex = 52;
            this.datagvWarehouseDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvWarehouseDetails_CellContentClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.95614F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.320175F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.63597F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.97807F));
            this.tableLayoutPanel4.Controls.Add(this.lblDatagvSignal, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEdit, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 474);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(912, 32);
            this.tableLayoutPanel4.TabIndex = 58;
            // 
            // lblDatagvSignal
            // 
            this.lblDatagvSignal.AutoSize = true;
            this.lblDatagvSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblDatagvSignal.Location = new System.Drawing.Point(3, 0);
            this.lblDatagvSignal.Name = "lblDatagvSignal";
            this.lblDatagvSignal.Size = new System.Drawing.Size(13, 20);
            this.lblDatagvSignal.TabIndex = 57;
            this.lblDatagvSignal.Text = " ";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(823, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 26);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(231)))), ((int)(((byte)(100)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(726, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 26);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(641, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 26);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbx, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(930, 540);
            this.tableLayoutPanel2.TabIndex = 59;
            // 
            // frmWarehouseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmWarehouseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouses Detail";
            this.Load += new System.EventHandler(this.frmViewWarehouses_Load);
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvWarehouseDetails)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Label lblDatagvSignal;
        private System.Windows.Forms.Button btnLoadRecords;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView datagvWarehouseDetails;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ComboBox cmbxFiliter;
        private System.Windows.Forms.Label lblFiliter;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbxAttributes;
        private System.Windows.Forms.Label lblAttributes;
        private System.Windows.Forms.Label lblAccountDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}