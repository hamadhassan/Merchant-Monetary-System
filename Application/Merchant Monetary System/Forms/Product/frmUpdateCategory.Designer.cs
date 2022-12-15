namespace Merchant_Monetary_System.Forms.Product
{
    partial class frmUpdateCategory
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.lblCategoryValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(571, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 30);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(353, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 30);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(126, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(297, 193);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 19;
            this.lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(406, 190);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(203, 23);
            this.txtCategory.TabIndex = 18;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.AutoSize = true;
            this.lblCategoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryTitle.Location = new System.Drawing.Point(227, 63);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Size = new System.Drawing.Size(480, 39);
            this.lblCategoryTitle.TabIndex = 17;
            this.lblCategoryTitle.Text = "Update Category Information";
            // 
            // lblCategoryValid
            // 
            this.lblCategoryValid.AutoSize = true;
            this.lblCategoryValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryValid.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryValid.Location = new System.Drawing.Point(406, 220);
            this.lblCategoryValid.Name = "lblCategoryValid";
            this.lblCategoryValid.Size = new System.Drawing.Size(0, 20);
            this.lblCategoryValid.TabIndex = 23;
            // 
            // frmUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.lblCategoryValid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategoryTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateCategory";
            this.Text = "frmUpdateCategory";
            this.Load += new System.EventHandler(this.frmUpdateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.Label lblCategoryValid;
    }
}