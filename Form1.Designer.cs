namespace Q5_Ran_Uram_Daniel_Geron
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnproductseller = new System.Windows.Forms.Button();
            this.btnproductbuyer = new System.Windows.Forms.Button();
            this.btnshowsellers = new System.Windows.Forms.Button();
            this.btnallbuyers = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblnames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(218, 88);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(169, 34);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnproductseller
            // 
            this.btnproductseller.Location = new System.Drawing.Point(218, 127);
            this.btnproductseller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnproductseller.Name = "btnproductseller";
            this.btnproductseller.Size = new System.Drawing.Size(169, 34);
            this.btnproductseller.TabIndex = 1;
            this.btnproductseller.Text = "Add Product To Seller";
            this.btnproductseller.UseVisualStyleBackColor = true;
            this.btnproductseller.Click += new System.EventHandler(this.btnproductseller_Click);
            // 
            // btnproductbuyer
            // 
            this.btnproductbuyer.Location = new System.Drawing.Point(218, 166);
            this.btnproductbuyer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnproductbuyer.Name = "btnproductbuyer";
            this.btnproductbuyer.Size = new System.Drawing.Size(169, 34);
            this.btnproductbuyer.TabIndex = 2;
            this.btnproductbuyer.Text = "Add Product To Buyer";
            this.btnproductbuyer.UseVisualStyleBackColor = true;
            this.btnproductbuyer.Click += new System.EventHandler(this.btnproductbuyer_Click);
            // 
            // btnshowsellers
            // 
            this.btnshowsellers.Location = new System.Drawing.Point(218, 205);
            this.btnshowsellers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnshowsellers.Name = "btnshowsellers";
            this.btnshowsellers.Size = new System.Drawing.Size(169, 34);
            this.btnshowsellers.TabIndex = 3;
            this.btnshowsellers.Text = "Show All Sellers";
            this.btnshowsellers.UseVisualStyleBackColor = true;
            this.btnshowsellers.Click += new System.EventHandler(this.btnshowsellers_Click);
            // 
            // btnallbuyers
            // 
            this.btnallbuyers.Location = new System.Drawing.Point(218, 244);
            this.btnallbuyers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnallbuyers.Name = "btnallbuyers";
            this.btnallbuyers.Size = new System.Drawing.Size(169, 34);
            this.btnallbuyers.TabIndex = 4;
            this.btnallbuyers.Text = "Show All Buyers";
            this.btnallbuyers.UseVisualStyleBackColor = true;
            this.btnallbuyers.Click += new System.EventHandler(this.btnallbuyers_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(218, 283);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(169, 34);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Save and Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblnames
            // 
            this.lblnames.AutoSize = true;
            this.lblnames.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblnames.Location = new System.Drawing.Point(9, 324);
            this.lblnames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnames.Name = "lblnames";
            this.lblnames.Size = new System.Drawing.Size(126, 26);
            this.lblnames.TabIndex = 6;
            this.lblnames.Text = "Ran Uram 206661886\nDaniel Geron 212515522";
            this.lblnames.Click += new System.EventHandler(this.lblnames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblnames);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnallbuyers);
            this.Controls.Add(this.btnshowsellers);
            this.Controls.Add(this.btnproductbuyer);
            this.Controls.Add(this.btnproductseller);
            this.Controls.Add(this.btnAddUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Eshop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnproductseller;
        private System.Windows.Forms.Button btnproductbuyer;
        private System.Windows.Forms.Button btnshowsellers;
        private System.Windows.Forms.Button btnallbuyers;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblnames;
    }
}

