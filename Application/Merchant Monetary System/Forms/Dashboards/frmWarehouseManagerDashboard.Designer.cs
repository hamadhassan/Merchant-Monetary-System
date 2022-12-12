﻿namespace Merchant_Monetary_System.Forms.Dashboards
{
    partial class frmWarehouseManagerDashboard
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStriplblDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStriplblAllRight = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStriplblTime = new System.Windows.Forms.ToolStripLabel();
            this.ptoolStrip = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddWarehouseManger = new System.Windows.Forms.Button();
            this.btnAddRider = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWarehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseMangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pParent = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.ptoolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStriplblDate
            // 
            this.toolStriplblDate.Name = "toolStriplblDate";
            this.toolStriplblDate.Size = new System.Drawing.Size(34, 22);
            this.toolStriplblDate.Text = "Date ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStriplblAllRight
            // 
            this.toolStriplblAllRight.Name = "toolStriplblAllRight";
            this.toolStriplblAllRight.Size = new System.Drawing.Size(271, 22);
            this.toolStriplblAllRight.Text = "All right reserved with Merchant Monetary System";
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriplblAllRight,
            this.toolStripSeparator1,
            this.toolStriplblDate,
            this.toolStripSeparator2,
            this.toolStriplblTime});
            this.toolStrip.Location = new System.Drawing.Point(0, 2);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(675, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStriplblTime
            // 
            this.toolStriplblTime.Name = "toolStriplblTime";
            this.toolStriplblTime.Size = new System.Drawing.Size(33, 22);
            this.toolStriplblTime.Text = "Time";
            // 
            // ptoolStrip
            // 
            this.ptoolStrip.Controls.Add(this.toolStrip);
            this.ptoolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ptoolStrip.Location = new System.Drawing.Point(213, 446);
            this.ptoolStrip.Name = "ptoolStrip";
            this.ptoolStrip.Size = new System.Drawing.Size(675, 27);
            this.ptoolStrip.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddEmployee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddWarehouseManger, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddRider, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddProduct, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnViewProduct, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnViewReport, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.76605F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.109731F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 444);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnAddWarehouseManger
            // 
            this.btnAddWarehouseManger.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWarehouseManger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddWarehouseManger.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddWarehouseManger.FlatAppearance.BorderSize = 0;
            this.btnAddWarehouseManger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWarehouseManger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWarehouseManger.ForeColor = System.Drawing.Color.Black;
            this.btnAddWarehouseManger.Location = new System.Drawing.Point(3, 82);
            this.btnAddWarehouseManger.Name = "btnAddWarehouseManger";
            this.btnAddWarehouseManger.Size = new System.Drawing.Size(207, 61);
            this.btnAddWarehouseManger.TabIndex = 59;
            this.btnAddWarehouseManger.Text = "Add Payment";
            this.btnAddWarehouseManger.UseVisualStyleBackColor = false;
            // 
            // btnAddRider
            // 
            this.btnAddRider.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRider.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddRider.FlatAppearance.BorderSize = 0;
            this.btnAddRider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRider.ForeColor = System.Drawing.Color.Black;
            this.btnAddRider.Location = new System.Drawing.Point(3, 149);
            this.btnAddRider.Name = "btnAddRider";
            this.btnAddRider.Size = new System.Drawing.Size(207, 68);
            this.btnAddRider.TabIndex = 61;
            this.btnAddRider.Text = "View Product";
            this.btnAddRider.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 223);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(207, 68);
            this.btnAddProduct.TabIndex = 62;
            this.btnAddProduct.Text = "Send Email";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewProduct.FlatAppearance.BorderSize = 0;
            this.btnViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProduct.ForeColor = System.Drawing.Color.Black;
            this.btnViewProduct.Location = new System.Drawing.Point(3, 297);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(207, 68);
            this.btnViewProduct.TabIndex = 63;
            this.btnViewProduct.Text = "Forgot Password";
            this.btnViewProduct.UseVisualStyleBackColor = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // viewWarehousesToolStripMenuItem
            // 
            this.viewWarehousesToolStripMenuItem.Name = "viewWarehousesToolStripMenuItem";
            this.viewWarehousesToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.viewWarehousesToolStripMenuItem.Text = "View Warehouses";
            // 
            // warehouseMangerToolStripMenuItem
            // 
            this.warehouseMangerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewWarehousesToolStripMenuItem});
            this.warehouseMangerToolStripMenuItem.Name = "warehouseMangerToolStripMenuItem";
            this.warehouseMangerToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.warehouseMangerToolStripMenuItem.Text = "Warehouse";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // pParent
            // 
            this.pParent.ColumnCount = 1;
            this.pParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pParent.Location = new System.Drawing.Point(0, 29);
            this.pParent.Name = "pParent";
            this.pParent.RowCount = 1;
            this.pParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pParent.Size = new System.Drawing.Size(888, 444);
            this.pParent.TabIndex = 9;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.riderToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.productToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.warehouseMangerToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(888, 29);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpToolStripMenuItem,
            this.viewAccountsToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.signUpToolStripMenuItem.Text = "SignUp";
            // 
            // viewAccountsToolStripMenuItem
            // 
            this.viewAccountsToolStripMenuItem.Name = "viewAccountsToolStripMenuItem";
            this.viewAccountsToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.viewAccountsToolStripMenuItem.Text = "Account Detail";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.signOutToolStripMenuItem.Text = "SignOut";
            // 
            // riderToolStripMenuItem
            // 
            this.riderToolStripMenuItem.Name = "riderToolStripMenuItem";
            this.riderToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.riderToolStripMenuItem.Text = "Rider";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAddToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addAddToolStripMenuItem
            // 
            this.addAddToolStripMenuItem.Name = "addAddToolStripMenuItem";
            this.addAddToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.addAddToolStripMenuItem.Text = "Add Add";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.Transparent;
            this.btnViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewReport.FlatAppearance.BorderSize = 0;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.ForeColor = System.Drawing.Color.Black;
            this.btnViewReport.Location = new System.Drawing.Point(3, 371);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(207, 70);
            this.btnViewReport.TabIndex = 60;
            this.btnViewReport.Text = "View Stock";
            this.btnViewReport.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Location = new System.Drawing.Point(3, 3);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(207, 73);
            this.btnAddEmployee.TabIndex = 58;
            this.btnAddEmployee.Text = "Order Details";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // frmWarehouseManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.ptoolStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pParent);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmWarehouseManagerDashboard";
            this.Text = "frmWarehouseManagerDashboard";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ptoolStrip.ResumeLayout(false);
            this.ptoolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStriplblDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStriplblAllRight;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStriplblTime;
        private System.Windows.Forms.Panel ptoolStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddWarehouseManger;
        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWarehousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseMangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel pParent;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}