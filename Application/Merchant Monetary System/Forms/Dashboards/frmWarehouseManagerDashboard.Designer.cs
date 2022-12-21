namespace Merchant_Monetary_System.Forms.Dashboards
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
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pParent = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tblForm = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forgotPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDeatislToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.ptoolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pParent.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.toolStrip.Size = new System.Drawing.Size(931, 25);
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
            this.ptoolStrip.Location = new System.Drawing.Point(213, 574);
            this.ptoolStrip.Name = "ptoolStrip";
            this.ptoolStrip.Size = new System.Drawing.Size(931, 27);
            this.ptoolStrip.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnOrderDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddPayment, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnViewProducts, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSendEmail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnForgotPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnViewStock, 0, 5);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 572);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrderDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrderDetails.FlatAppearance.BorderSize = 0;
            this.btnOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDetails.ForeColor = System.Drawing.Color.Black;
            this.btnOrderDetails.Location = new System.Drawing.Point(3, 3);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(207, 96);
            this.btnOrderDetails.TabIndex = 58;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = false;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPayment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddPayment.FlatAppearance.BorderSize = 0;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayment.ForeColor = System.Drawing.Color.Black;
            this.btnAddPayment.Location = new System.Drawing.Point(3, 105);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(207, 81);
            this.btnAddPayment.TabIndex = 59;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewProducts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewProducts.FlatAppearance.BorderSize = 0;
            this.btnViewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.ForeColor = System.Drawing.Color.Black;
            this.btnViewProducts.Location = new System.Drawing.Point(3, 192);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(207, 89);
            this.btnViewProducts.TabIndex = 61;
            this.btnViewProducts.Text = "View Product";
            this.btnViewProducts.UseVisualStyleBackColor = false;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnSendEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSendEmail.FlatAppearance.BorderSize = 0;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.Black;
            this.btnSendEmail.Location = new System.Drawing.Point(3, 287);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(207, 89);
            this.btnSendEmail.TabIndex = 62;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnForgotPassword.FlatAppearance.BorderSize = 0;
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassword.ForeColor = System.Drawing.Color.Black;
            this.btnForgotPassword.Location = new System.Drawing.Point(3, 382);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(207, 89);
            this.btnForgotPassword.TabIndex = 63;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.BackColor = System.Drawing.Color.Transparent;
            this.btnViewStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewStock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewStock.FlatAppearance.BorderSize = 0;
            this.btnViewStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStock.ForeColor = System.Drawing.Color.Black;
            this.btnViewStock.Location = new System.Drawing.Point(3, 477);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(207, 92);
            this.btnViewStock.TabIndex = 60;
            this.btnViewStock.Text = "View Stock";
            this.btnViewStock.UseVisualStyleBackColor = false;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pParent
            // 
            this.pParent.ColumnCount = 1;
            this.pParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pParent.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.pParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pParent.Location = new System.Drawing.Point(0, 29);
            this.pParent.Name = "pParent";
            this.pParent.RowCount = 1;
            this.pParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pParent.Size = new System.Drawing.Size(1144, 572);
            this.pParent.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tblForm, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1138, 566);
            this.tableLayoutPanel2.TabIndex = 6;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tblForm
            // 
            this.tblForm.ColumnCount = 1;
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.tblForm.Location = new System.Drawing.Point(210, 3);
            this.tblForm.Name = "tblForm";
            this.tblForm.RowCount = 1;
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblForm.Size = new System.Drawing.Size(925, 560);
            this.tblForm.TabIndex = 6;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.productToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1144, 29);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendEmailToolStripMenuItem,
            this.forgotPasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // forgotPasswordToolStripMenuItem
            // 
            this.forgotPasswordToolStripMenuItem.Name = "forgotPasswordToolStripMenuItem";
            this.forgotPasswordToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.forgotPasswordToolStripMenuItem.Text = "Forgot Password ";
            this.forgotPasswordToolStripMenuItem.Click += new System.EventHandler(this.forgotPasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.signOutToolStripMenuItem.Text = "SignOut";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderDeatislToolStripMenuItem,
            this.viewProductsToolStripMenuItem,
            this.viewStockToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // orderDeatislToolStripMenuItem
            // 
            this.orderDeatislToolStripMenuItem.Name = "orderDeatislToolStripMenuItem";
            this.orderDeatislToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.orderDeatislToolStripMenuItem.Text = "Order Deatails";
            this.orderDeatislToolStripMenuItem.Click += new System.EventHandler(this.orderDeatislToolStripMenuItem_Click);
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.viewProductsToolStripMenuItem.Text = "View Products ";
            this.viewProductsToolStripMenuItem.Click += new System.EventHandler(this.viewProductsToolStripMenuItem_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.viewStockToolStripMenuItem.Text = "View Stock";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // frmWarehouseManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.ptoolStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pParent);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmWarehouseManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Manager Dashboard";
            this.Load += new System.EventHandler(this.frmWarehouseManagerDashboard_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ptoolStrip.ResumeLayout(false);
            this.ptoolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pParent.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel pParent;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tblForm;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forgotPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDeatislToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
    }
}