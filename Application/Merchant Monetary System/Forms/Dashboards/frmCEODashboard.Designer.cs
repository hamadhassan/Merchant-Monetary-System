namespace Merchant_Monetary_System
{
    partial class frmCEODashboard
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseMangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWarehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnAddShopkeeper = new System.Windows.Forms.Button();
            this.btnAddWarehouseManger = new System.Windows.Forms.Button();
            this.btnAddRider = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.ptoolStrip = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStriplblAllRight = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStriplblDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStriplblTime = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pParent = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ptoolStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1144, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewAccountsToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.signUpToolStripMenuItem.Text = "SignUp";
            this.signUpToolStripMenuItem.Click += new System.EventHandler(this.signUpToolStripMenuItem_Click);
            // 
            // viewAccountsToolStripMenuItem
            // 
            this.viewAccountsToolStripMenuItem.Name = "viewAccountsToolStripMenuItem";
            this.viewAccountsToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.viewAccountsToolStripMenuItem.Text = "Account Detail";
            this.viewAccountsToolStripMenuItem.Click += new System.EventHandler(this.viewAccountsToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.signOutToolStripMenuItem.Text = "SignOut";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
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
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // warehouseMangerToolStripMenuItem
            // 
            this.warehouseMangerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewWarehousesToolStripMenuItem});
            this.warehouseMangerToolStripMenuItem.Name = "warehouseMangerToolStripMenuItem";
            this.warehouseMangerToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.warehouseMangerToolStripMenuItem.Text = "Warehouse";
            // 
            // viewWarehousesToolStripMenuItem
            // 
            this.viewWarehousesToolStripMenuItem.Name = "viewWarehousesToolStripMenuItem";
            this.viewWarehousesToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.viewWarehousesToolStripMenuItem.Text = "View Warehouses";
            this.viewWarehousesToolStripMenuItem.Click += new System.EventHandler(this.viewWarehousesToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVendorToolStripMenuItem,
            this.updateVendorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.helpToolStripMenuItem.Text = "Vendor";
            // 
            // addVendorToolStripMenuItem
            // 
            this.addVendorToolStripMenuItem.Name = "addVendorToolStripMenuItem";
            this.addVendorToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.addVendorToolStripMenuItem.Text = "Add Vendor";
            this.addVendorToolStripMenuItem.Click += new System.EventHandler(this.addVendorToolStripMenuItem_Click);
            // 
            // updateVendorToolStripMenuItem
            // 
            this.updateVendorToolStripMenuItem.Name = "updateVendorToolStripMenuItem";
            this.updateVendorToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.updateVendorToolStripMenuItem.Text = "Update Vendor";
            this.updateVendorToolStripMenuItem.Click += new System.EventHandler(this.updateVendorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Location = new System.Drawing.Point(3, 3);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(207, 44);
            this.btnAddEmployee.TabIndex = 58;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddWarehouseManager_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSignOut, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnForgotPassword, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnAddShopkeeper, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnAddEmployee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddWarehouseManger, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddRider, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddProduct, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnViewProduct, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnViewReport, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnViewOrder, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAddStock, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnSendEmail, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.76605F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.109731F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00007F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 572);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.Color.Black;
            this.btnSignOut.Location = new System.Drawing.Point(3, 521);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(207, 48);
            this.btnSignOut.TabIndex = 69;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnForgotPassword.FlatAppearance.BorderSize = 0;
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.ForeColor = System.Drawing.Color.Black;
            this.btnForgotPassword.Location = new System.Drawing.Point(3, 463);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(207, 52);
            this.btnForgotPassword.TabIndex = 68;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click_1);
            // 
            // btnAddShopkeeper
            // 
            this.btnAddShopkeeper.BackColor = System.Drawing.Color.Transparent;
            this.btnAddShopkeeper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddShopkeeper.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddShopkeeper.FlatAppearance.BorderSize = 0;
            this.btnAddShopkeeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShopkeeper.ForeColor = System.Drawing.Color.Black;
            this.btnAddShopkeeper.Location = new System.Drawing.Point(3, 417);
            this.btnAddShopkeeper.Name = "btnAddShopkeeper";
            this.btnAddShopkeeper.Size = new System.Drawing.Size(207, 40);
            this.btnAddShopkeeper.TabIndex = 64;
            this.btnAddShopkeeper.Text = "Add Shopkeeper";
            this.btnAddShopkeeper.UseVisualStyleBackColor = false;
            this.btnAddShopkeeper.Click += new System.EventHandler(this.btnAddShopkeeper_Click);
            // 
            // btnAddWarehouseManger
            // 
            this.btnAddWarehouseManger.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWarehouseManger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddWarehouseManger.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddWarehouseManger.FlatAppearance.BorderSize = 0;
            this.btnAddWarehouseManger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWarehouseManger.ForeColor = System.Drawing.Color.Black;
            this.btnAddWarehouseManger.Location = new System.Drawing.Point(3, 53);
            this.btnAddWarehouseManger.Name = "btnAddWarehouseManger";
            this.btnAddWarehouseManger.Size = new System.Drawing.Size(207, 36);
            this.btnAddWarehouseManger.TabIndex = 59;
            this.btnAddWarehouseManger.Text = "Add Warehouse Manager";
            this.btnAddWarehouseManger.UseVisualStyleBackColor = false;
            this.btnAddWarehouseManger.Click += new System.EventHandler(this.btnAddWarehouseManger_Click);
            // 
            // btnAddRider
            // 
            this.btnAddRider.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRider.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddRider.FlatAppearance.BorderSize = 0;
            this.btnAddRider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRider.ForeColor = System.Drawing.Color.Black;
            this.btnAddRider.Location = new System.Drawing.Point(3, 95);
            this.btnAddRider.Name = "btnAddRider";
            this.btnAddRider.Size = new System.Drawing.Size(207, 40);
            this.btnAddRider.TabIndex = 61;
            this.btnAddRider.Text = "Add Rider";
            this.btnAddRider.UseVisualStyleBackColor = false;
            this.btnAddRider.Click += new System.EventHandler(this.btnAddRider_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 141);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(207, 40);
            this.btnAddProduct.TabIndex = 62;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewProduct.FlatAppearance.BorderSize = 0;
            this.btnViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProduct.ForeColor = System.Drawing.Color.Black;
            this.btnViewProduct.Location = new System.Drawing.Point(3, 187);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(207, 40);
            this.btnViewProduct.TabIndex = 63;
            this.btnViewProduct.Text = "View Product";
            this.btnViewProduct.UseVisualStyleBackColor = false;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.Transparent;
            this.btnViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewReport.FlatAppearance.BorderSize = 0;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.ForeColor = System.Drawing.Color.Black;
            this.btnViewReport.Location = new System.Drawing.Point(3, 233);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(207, 40);
            this.btnViewReport.TabIndex = 60;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewOrder.FlatAppearance.BorderSize = 0;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.ForeColor = System.Drawing.Color.Black;
            this.btnViewOrder.Location = new System.Drawing.Point(3, 279);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(207, 40);
            this.btnViewOrder.TabIndex = 65;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddStock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.ForeColor = System.Drawing.Color.Black;
            this.btnAddStock.Location = new System.Drawing.Point(3, 325);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(207, 40);
            this.btnAddStock.TabIndex = 66;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnSendEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSendEmail.FlatAppearance.BorderSize = 0;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.ForeColor = System.Drawing.Color.Black;
            this.btnSendEmail.Location = new System.Drawing.Point(3, 371);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(207, 40);
            this.btnSendEmail.TabIndex = 67;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // ptoolStrip
            // 
            this.ptoolStrip.Controls.Add(this.toolStrip);
            this.ptoolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ptoolStrip.Location = new System.Drawing.Point(213, 574);
            this.ptoolStrip.Name = "ptoolStrip";
            this.ptoolStrip.Size = new System.Drawing.Size(931, 27);
            this.ptoolStrip.TabIndex = 4;
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
            this.toolStrip.Size = new System.Drawing.Size(931, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStriplblAllRight
            // 
            this.toolStriplblAllRight.Name = "toolStriplblAllRight";
            this.toolStriplblAllRight.Size = new System.Drawing.Size(271, 22);
            this.toolStriplblAllRight.Text = "All right reserved with Merchant Monetary System";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStriplblDate
            // 
            this.toolStriplblDate.Name = "toolStriplblDate";
            this.toolStriplblDate.Size = new System.Drawing.Size(34, 22);
            this.toolStriplblDate.Text = "Date ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStriplblTime
            // 
            this.toolStriplblTime.Name = "toolStriplblTime";
            this.toolStriplblTime.Size = new System.Drawing.Size(33, 22);
            this.toolStriplblTime.Text = "Time";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pParent
            // 
            this.pParent.ColumnCount = 1;
            this.pParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pParent.Location = new System.Drawing.Point(213, 29);
            this.pParent.Name = "pParent";
            this.pParent.RowCount = 1;
            this.pParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pParent.Size = new System.Drawing.Size(931, 545);
            this.pParent.TabIndex = 5;
            this.pParent.Paint += new System.Windows.Forms.PaintEventHandler(this.pParent_Paint);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 24);
            this.toolStripMenuItem1.Text = "Update Companay ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frmCEODashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.pParent);
            this.Controls.Add(this.ptoolStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCEODashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEO Dashboard";
            this.Load += new System.EventHandler(this.frmCEODashboard_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ptoolStrip.ResumeLayout(false);
            this.ptoolStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseMangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddWarehouseManger;
        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnAddShopkeeper;
        private System.Windows.Forms.Panel ptoolStrip;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStriplblAllRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStriplblDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStriplblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel pParent;
        private System.Windows.Forms.ToolStripMenuItem addAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWarehousesToolStripMenuItem;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.ToolStripMenuItem addVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}