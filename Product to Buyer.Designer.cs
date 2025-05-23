using System.Windows.Forms;

namespace Q5_Ran_Uram_Daniel_Geron
{
    partial class Product_to_Buyer
    {
        public ListBox Lstproductbyname
        {
            get { return lstproductbyname; }
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_to_Buyer));
            this.lstproductbyname = new System.Windows.Forms.ListBox();
            this.lstallbuyers = new System.Windows.Forms.ListBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnsearchbuyer = new System.Windows.Forms.Button();
            this.lblsearchbuyer = new System.Windows.Forms.Label();
            this.txtbuyerbyname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstproductbyname
            // 
            this.lstproductbyname.FormattingEnabled = true;
            this.lstproductbyname.ItemHeight = 16;
            this.lstproductbyname.Location = new System.Drawing.Point(56, 238);
            this.lstproductbyname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstproductbyname.Name = "lstproductbyname";
            this.lstproductbyname.Size = new System.Drawing.Size(687, 164);
            this.lstproductbyname.TabIndex = 3;
            this.lstproductbyname.SelectedIndexChanged += new System.EventHandler(this.lstproductbyname_SelectedIndexChanged);
            this.lstproductbyname.DoubleClick += new System.EventHandler(this.lstproductbyname_DoubleClick);
            // 
            // lstallbuyers
            // 
            this.lstallbuyers.FormattingEnabled = true;
            this.lstallbuyers.ItemHeight = 16;
            this.lstallbuyers.Location = new System.Drawing.Point(59, 30);
            this.lstallbuyers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstallbuyers.Name = "lstallbuyers";
            this.lstallbuyers.Size = new System.Drawing.Size(687, 148);
            this.lstallbuyers.TabIndex = 4;
            this.lstallbuyers.SelectedIndexChanged += new System.EventHandler(this.lstallbuyers_SelectedIndexChanged);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(349, 407);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(136, 31);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Enabled = false;
            this.txtsearch.Location = new System.Drawing.Point(173, 210);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(129, 22);
            this.txtsearch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Enabled = false;
            this.btnsearch.Location = new System.Drawing.Point(309, 210);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(35, 23);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "🔍";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnshow
            // 
            this.btnshow.Enabled = false;
            this.btnshow.Location = new System.Drawing.Point(361, 210);
            this.btnshow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 9;
            this.btnshow.Text = "Show All";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose Buyer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.Enabled = false;
            this.btnshowall.Location = new System.Drawing.Point(477, 4);
            this.btnshowall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 14;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnsearchbuyer
            // 
            this.btnsearchbuyer.Location = new System.Drawing.Point(427, 4);
            this.btnsearchbuyer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearchbuyer.Name = "btnsearchbuyer";
            this.btnsearchbuyer.Size = new System.Drawing.Size(35, 23);
            this.btnsearchbuyer.TabIndex = 13;
            this.btnsearchbuyer.Text = "🔍";
            this.btnsearchbuyer.UseVisualStyleBackColor = true;
            this.btnsearchbuyer.Click += new System.EventHandler(this.btnsearchseller_Click);
            // 
            // lblsearchbuyer
            // 
            this.lblsearchbuyer.AutoSize = true;
            this.lblsearchbuyer.Location = new System.Drawing.Point(169, 7);
            this.lblsearchbuyer.Name = "lblsearchbuyer";
            this.lblsearchbuyer.Size = new System.Drawing.Size(108, 16);
            this.lblsearchbuyer.TabIndex = 12;
            this.lblsearchbuyer.Text = "Search by name:";
            // 
            // txtbuyerbyname
            // 
            this.txtbuyerbyname.Location = new System.Drawing.Point(291, 4);
            this.txtbuyerbyname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuyerbyname.Name = "txtbuyerbyname";
            this.txtbuyerbyname.Size = new System.Drawing.Size(129, 22);
            this.txtbuyerbyname.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(52, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "double-click to add product";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Product_to_Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsearchbuyer);
            this.Controls.Add(this.lblsearchbuyer);
            this.Controls.Add(this.txtbuyerbyname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lstallbuyers);
            this.Controls.Add(this.lstproductbyname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product_to_Buyer";
            this.Text = "Product_to_Buyer";
            this.Load += new System.EventHandler(this.Product_to_Buyer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstproductbyname;
        private ListBox lstallbuyers;
        private Button btnexit;
        private TextBox txtsearch;
        private Label label1;
        private Button btnsearch;
        private Button btnshow;
        private Label label2;
        private Button btnshowall;
        private Button btnsearchbuyer;
        private Label lblsearchbuyer;
        private TextBox txtbuyerbyname;
        private Label label3;

        public ListBox Buyerlst
        {
            get { return lstallbuyers; }
        }

    }
}