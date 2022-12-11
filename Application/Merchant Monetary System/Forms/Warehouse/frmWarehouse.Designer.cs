namespace Merchant_Monetary_System
{
    partial class frmWarehouse
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
            this.lblAddWarehouse = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameSignal = new System.Windows.Forms.Label();
            this.lblCapacityInVolumeSignal = new System.Windows.Forms.Label();
            this.txtbxCapacityInVolume = new System.Windows.Forms.TextBox();
            this.lblCapacityInVolume = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbxCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbxArea = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbxState = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.btnNext);
            this.gbx.Controls.Add(this.btnClearAll);
            this.gbx.Controls.Add(this.btnClose);
            this.gbx.Controls.Add(this.lblState);
            this.gbx.Controls.Add(this.cmbxState);
            this.gbx.Controls.Add(this.lblCity);
            this.gbx.Controls.Add(this.cmbxArea);
            this.gbx.Controls.Add(this.lblArea);
            this.gbx.Controls.Add(this.cmbxCity);
            this.gbx.Controls.Add(this.lblCapacityInVolumeSignal);
            this.gbx.Controls.Add(this.txtbxCapacityInVolume);
            this.gbx.Controls.Add(this.lblCapacityInVolume);
            this.gbx.Controls.Add(this.lblNameSignal);
            this.gbx.Controls.Add(this.txtbxName);
            this.gbx.Controls.Add(this.lblName);
            this.gbx.Controls.Add(this.lblAddWarehouse);
            this.gbx.Location = new System.Drawing.Point(12, 12);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(890, 477);
            this.gbx.TabIndex = 0;
            this.gbx.TabStop = false;
            // 
            // lblAddWarehouse
            // 
            this.lblAddWarehouse.AutoSize = true;
            this.lblAddWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWarehouse.Location = new System.Drawing.Point(309, 22);
            this.lblAddWarehouse.Name = "lblAddWarehouse";
            this.lblAddWarehouse.Size = new System.Drawing.Size(274, 39);
            this.lblAddWarehouse.TabIndex = 2;
            this.lblAddWarehouse.Text = "Add Warehouse";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(253, 118);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(203, 26);
            this.txtbxName.TabIndex = 5;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(95, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name :";
            // 
            // lblNameSignal
            // 
            this.lblNameSignal.AutoSize = true;
            this.lblNameSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblNameSignal.Location = new System.Drawing.Point(252, 147);
            this.lblNameSignal.Name = "lblNameSignal";
            this.lblNameSignal.Size = new System.Drawing.Size(13, 20);
            this.lblNameSignal.TabIndex = 18;
            this.lblNameSignal.Text = " ";
            // 
            // lblCapacityInVolumeSignal
            // 
            this.lblCapacityInVolumeSignal.AutoSize = true;
            this.lblCapacityInVolumeSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lblCapacityInVolumeSignal.Location = new System.Drawing.Point(253, 197);
            this.lblCapacityInVolumeSignal.Name = "lblCapacityInVolumeSignal";
            this.lblCapacityInVolumeSignal.Size = new System.Drawing.Size(13, 20);
            this.lblCapacityInVolumeSignal.TabIndex = 21;
            this.lblCapacityInVolumeSignal.Text = " ";
            // 
            // txtbxCapacityInVolume
            // 
            this.txtbxCapacityInVolume.Location = new System.Drawing.Point(253, 168);
            this.txtbxCapacityInVolume.Name = "txtbxCapacityInVolume";
            this.txtbxCapacityInVolume.Size = new System.Drawing.Size(203, 26);
            this.txtbxCapacityInVolume.TabIndex = 19;
            this.txtbxCapacityInVolume.TextChanged += new System.EventHandler(this.txtbxCapacityInVolume_TextChanged);
            // 
            // lblCapacityInVolume
            // 
            this.lblCapacityInVolume.AutoSize = true;
            this.lblCapacityInVolume.Location = new System.Drawing.Point(95, 171);
            this.lblCapacityInVolume.Name = "lblCapacityInVolume";
            this.lblCapacityInVolume.Size = new System.Drawing.Size(152, 20);
            this.lblCapacityInVolume.TabIndex = 20;
            this.lblCapacityInVolume.Text = "Capacity in Volume :";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(95, 218);
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
            this.cmbxCity.Location = new System.Drawing.Point(593, 116);
            this.cmbxCity.Name = "cmbxCity";
            this.cmbxCity.Size = new System.Drawing.Size(203, 28);
            this.cmbxCity.TabIndex = 24;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(514, 124);
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
            this.cmbxArea.Location = new System.Drawing.Point(253, 210);
            this.cmbxArea.Name = "cmbxArea";
            this.cmbxArea.Size = new System.Drawing.Size(203, 28);
            this.cmbxArea.TabIndex = 26;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(514, 171);
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
            this.cmbxState.Location = new System.Drawing.Point(593, 166);
            this.cmbxState.Name = "cmbxState";
            this.cmbxState.Size = new System.Drawing.Size(203, 28);
            this.cmbxState.TabIndex = 28;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(563, 311);
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
            this.btnClearAll.Location = new System.Drawing.Point(345, 311);
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
            this.btnClose.Location = new System.Drawing.Point(139, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 501);
            this.Controls.Add(this.gbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWarehouse";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
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
    }
}