namespace Merchant_Monetary_System
{
    partial class frmAddWarehouse
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
            this.lblRecordSignal = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbxState = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbxArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbxCity = new System.Windows.Forms.ComboBox();
            this.lblCapacityInVolumeSignal = new System.Windows.Forms.Label();
            this.txtbxCapacityInVolume = new System.Windows.Forms.TextBox();
            this.lblCapacityInVolume = new System.Windows.Forms.Label();
            this.lblNameSignal = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddWarehouse = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.gbx.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.tableLayoutPanel2);
            this.gbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx.Location = new System.Drawing.Point(3, 3);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(908, 495);
            this.gbx.TabIndex = 0;
            this.gbx.TabStop = false;
            this.gbx.Enter += new System.EventHandler(this.gbx_Enter);
            // 
            // lblRecordSignal
            // 
            this.lblRecordSignal.AutoSize = true;
            this.lblRecordSignal.Location = new System.Drawing.Point(256, 0);
            this.lblRecordSignal.Name = "lblRecordSignal";
            this.lblRecordSignal.Size = new System.Drawing.Size(13, 20);
            this.lblRecordSignal.TabIndex = 34;
            this.lblRecordSignal.Text = " ";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(555, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(200, 30);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(344, 3);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(200, 30);
            this.btnClearAll.TabIndex = 31;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(133, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(509, 95);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(56, 20);
            this.lblState.TabIndex = 29;
            this.lblState.Text = "State :";
            // 
            // cmbxState
            // 
            this.cmbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxState.FormattingEnabled = true;
            this.cmbxState.Items.AddRange(new object[] {
            "Punjab"});
            this.cmbxState.Location = new System.Drawing.Point(588, 98);
            this.cmbxState.Name = "cmbxState";
            this.cmbxState.Size = new System.Drawing.Size(203, 28);
            this.cmbxState.TabIndex = 28;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(509, 44);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 20);
            this.lblCity.TabIndex = 27;
            this.lblCity.Text = "City :";
            // 
            // cmbxArea
            // 
            this.cmbxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxArea.FormattingEnabled = true;
            this.cmbxArea.Items.AddRange(new object[] {
            "UET Lahore"});
            this.cmbxArea.Location = new System.Drawing.Point(247, 151);
            this.cmbxArea.Name = "cmbxArea";
            this.cmbxArea.Size = new System.Drawing.Size(203, 28);
            this.cmbxArea.TabIndex = 26;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(90, 148);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(51, 20);
            this.lblArea.TabIndex = 25;
            this.lblArea.Text = "Area :";
            // 
            // cmbxCity
            // 
            this.cmbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxCity.FormattingEnabled = true;
            this.cmbxCity.Items.AddRange(new object[] {
            "Lahore"});
            this.cmbxCity.Location = new System.Drawing.Point(588, 47);
            this.cmbxCity.Name = "cmbxCity";
            this.cmbxCity.Size = new System.Drawing.Size(203, 28);
            this.cmbxCity.TabIndex = 24;
            // 
            // lblCapacityInVolumeSignal
            // 
            this.lblCapacityInVolumeSignal.AutoSize = true;
            this.lblCapacityInVolumeSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblCapacityInVolumeSignal.Location = new System.Drawing.Point(247, 122);
            this.lblCapacityInVolumeSignal.Name = "lblCapacityInVolumeSignal";
            this.lblCapacityInVolumeSignal.Size = new System.Drawing.Size(13, 20);
            this.lblCapacityInVolumeSignal.TabIndex = 21;
            this.lblCapacityInVolumeSignal.Text = " ";
            // 
            // txtbxCapacityInVolume
            // 
            this.txtbxCapacityInVolume.Location = new System.Drawing.Point(247, 98);
            this.txtbxCapacityInVolume.Name = "txtbxCapacityInVolume";
            this.txtbxCapacityInVolume.Size = new System.Drawing.Size(203, 26);
            this.txtbxCapacityInVolume.TabIndex = 19;
            this.txtbxCapacityInVolume.TextChanged += new System.EventHandler(this.txtbxCapacityInVolume_TextChanged);
            // 
            // lblCapacityInVolume
            // 
            this.lblCapacityInVolume.AutoSize = true;
            this.lblCapacityInVolume.Location = new System.Drawing.Point(90, 95);
            this.lblCapacityInVolume.Name = "lblCapacityInVolume";
            this.lblCapacityInVolume.Size = new System.Drawing.Size(148, 27);
            this.lblCapacityInVolume.TabIndex = 20;
            this.lblCapacityInVolume.Text = "Capacity in Volume :";
            // 
            // lblNameSignal
            // 
            this.lblNameSignal.AutoSize = true;
            this.lblNameSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblNameSignal.Location = new System.Drawing.Point(247, 73);
            this.lblNameSignal.Name = "lblNameSignal";
            this.lblNameSignal.Size = new System.Drawing.Size(13, 20);
            this.lblNameSignal.TabIndex = 18;
            this.lblNameSignal.Text = " ";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(247, 47);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(203, 26);
            this.txtbxName.TabIndex = 5;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(90, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name :";
            // 
            // lblAddWarehouse
            // 
            this.lblAddWarehouse.AutoSize = true;
            this.lblAddWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWarehouse.Location = new System.Drawing.Point(301, 0);
            this.lblAddWarehouse.Name = "lblAddWarehouse";
            this.lblAddWarehouse.Size = new System.Drawing.Size(274, 39);
            this.lblAddWarehouse.TabIndex = 2;
            this.lblAddWarehouse.Text = "Add Warehouse";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbx, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 501);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.42553F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.34043F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.02128F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 470);
            this.tableLayoutPanel2.TabIndex = 35;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25893F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.74107F));
            this.tableLayoutPanel3.Controls.Add(this.lblAddWarehouse, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(896, 43);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.709822F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52232F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.24107F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.816964F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.70982F));
            this.tableLayoutPanel4.Controls.Add(this.txtbxName, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmbxCity, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblCity, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblArea, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.cmbxArea, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.lblState, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.cmbxState, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtbxCapacityInVolume, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblCapacityInVolume, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblCapacityInVolumeSignal, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblNameSignal, 2, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 52);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.79793F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.02591F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.39896F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98964F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.4715F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.31606F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(896, 193);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.73214F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 251);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(896, 216);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.42697F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.57304F));
            this.tableLayoutPanel6.Controls.Add(this.lblRecordSignal, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(890, 29);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60674F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.70786F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.70786F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.97753F));
            this.tableLayoutPanel7.Controls.Add(this.btnNext, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnClearAll, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(890, 175);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // frmAddWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWarehouse";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            this.gbx.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Label lblAddWarehouse;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCapacityInVolumeSignal;
        private System.Windows.Forms.TextBox txtbxCapacityInVolume;
        private System.Windows.Forms.Label lblCapacityInVolume;
        private System.Windows.Forms.Label lblNameSignal;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbxState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbxArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbxCity;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordSignal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    }
}