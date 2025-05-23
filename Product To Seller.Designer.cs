using System.Windows.Forms;

namespace Q5_Ran_Uram_Daniel_Geron
{
    partial class Product_To_Seller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_To_Seller));
            this.grpaddproduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblproductnameerror = new System.Windows.Forms.Label();
            this.lblpriceerror = new System.Windows.Forms.Label();
            this.lblcate = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.checkspacial = new System.Windows.Forms.CheckBox();
            this.lblspacial = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.rclothing = new System.Windows.Forms.RadioButton();
            this.roffice = new System.Windows.Forms.RadioButton();
            this.relectronics = new System.Windows.Forms.RadioButton();
            this.rkids = new System.Windows.Forms.RadioButton();
            this.lblcat = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.lstsellers = new System.Windows.Forms.ListBox();
            this.lblselectseller = new System.Windows.Forms.Label();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnsearchseller = new System.Windows.Forms.Button();
            this.lblsearchseller = new System.Windows.Forms.Label();
            this.txtsellerbyname = new System.Windows.Forms.TextBox();
            this.grpaddproduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpaddproduct
            // 
            this.grpaddproduct.Controls.Add(this.label1);
            this.grpaddproduct.Controls.Add(this.btnclear);
            this.grpaddproduct.Controls.Add(this.lblproductnameerror);
            this.grpaddproduct.Controls.Add(this.lblpriceerror);
            this.grpaddproduct.Controls.Add(this.lblcate);
            this.grpaddproduct.Controls.Add(this.btncreate);
            this.grpaddproduct.Controls.Add(this.checkspacial);
            this.grpaddproduct.Controls.Add(this.lblspacial);
            this.grpaddproduct.Controls.Add(this.lblprice);
            this.grpaddproduct.Controls.Add(this.rclothing);
            this.grpaddproduct.Controls.Add(this.roffice);
            this.grpaddproduct.Controls.Add(this.relectronics);
            this.grpaddproduct.Controls.Add(this.rkids);
            this.grpaddproduct.Controls.Add(this.lblcat);
            this.grpaddproduct.Controls.Add(this.lblpname);
            this.grpaddproduct.Controls.Add(this.txtprice);
            this.grpaddproduct.Controls.Add(this.txtproductname);
            this.grpaddproduct.Location = new System.Drawing.Point(12, 174);
            this.grpaddproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpaddproduct.Name = "grpaddproduct";
            this.grpaddproduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpaddproduct.Size = new System.Drawing.Size(776, 217);
            this.grpaddproduct.TabIndex = 6;
            this.grpaddproduct.TabStop = false;
            this.grpaddproduct.Text = "Add Product";
            this.grpaddproduct.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(277, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "special package is an additional 50";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(548, 133);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(169, 46);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear All";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblproductnameerror
            // 
            this.lblproductnameerror.AutoSize = true;
            this.lblproductnameerror.ForeColor = System.Drawing.Color.Red;
            this.lblproductnameerror.Location = new System.Drawing.Point(152, 55);
            this.lblproductnameerror.Name = "lblproductnameerror";
            this.lblproductnameerror.Size = new System.Drawing.Size(0, 16);
            this.lblproductnameerror.TabIndex = 16;
            // 
            // lblpriceerror
            // 
            this.lblpriceerror.AutoSize = true;
            this.lblpriceerror.ForeColor = System.Drawing.Color.Red;
            this.lblpriceerror.Location = new System.Drawing.Point(545, 55);
            this.lblpriceerror.Name = "lblpriceerror";
            this.lblpriceerror.Size = new System.Drawing.Size(0, 16);
            this.lblpriceerror.TabIndex = 15;
            // 
            // lblcate
            // 
            this.lblcate.AutoSize = true;
            this.lblcate.ForeColor = System.Drawing.Color.Red;
            this.lblcate.Location = new System.Drawing.Point(5, 133);
            this.lblcate.Name = "lblcate";
            this.lblcate.Size = new System.Drawing.Size(0, 16);
            this.lblcate.TabIndex = 14;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(548, 81);
            this.btncreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(169, 46);
            this.btncreate.TabIndex = 13;
            this.btncreate.Text = "Create Product";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // checkspacial
            // 
            this.checkspacial.AutoSize = true;
            this.checkspacial.Location = new System.Drawing.Point(404, 89);
            this.checkspacial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkspacial.Name = "checkspacial";
            this.checkspacial.Size = new System.Drawing.Size(18, 17);
            this.checkspacial.TabIndex = 12;
            this.checkspacial.UseVisualStyleBackColor = true;
            // 
            // lblspacial
            // 
            this.lblspacial.AutoSize = true;
            this.lblspacial.Location = new System.Drawing.Point(277, 89);
            this.lblspacial.Name = "lblspacial";
            this.lblspacial.Size = new System.Drawing.Size(114, 16);
            this.lblspacial.TabIndex = 11;
            this.lblspacial.Text = "Special Package:";
            this.lblspacial.Click += new System.EventHandler(this.lblspacial_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(497, 31);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(41, 16);
            this.lblprice.TabIndex = 10;
            this.lblprice.Text = "Price:";
            // 
            // rclothing
            // 
            this.rclothing.AutoSize = true;
            this.rclothing.Location = new System.Drawing.Point(108, 161);
            this.rclothing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rclothing.Name = "rclothing";
            this.rclothing.Size = new System.Drawing.Size(76, 20);
            this.rclothing.TabIndex = 9;
            this.rclothing.TabStop = true;
            this.rclothing.Text = "Clothing";
            this.rclothing.UseVisualStyleBackColor = true;
            // 
            // roffice
            // 
            this.roffice.AutoSize = true;
            this.roffice.Location = new System.Drawing.Point(108, 135);
            this.roffice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roffice.Name = "roffice";
            this.roffice.Size = new System.Drawing.Size(62, 20);
            this.roffice.TabIndex = 8;
            this.roffice.TabStop = true;
            this.roffice.Text = "Office";
            this.roffice.UseVisualStyleBackColor = true;
            // 
            // relectronics
            // 
            this.relectronics.AutoSize = true;
            this.relectronics.Location = new System.Drawing.Point(108, 111);
            this.relectronics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relectronics.Name = "relectronics";
            this.relectronics.Size = new System.Drawing.Size(94, 20);
            this.relectronics.TabIndex = 7;
            this.relectronics.TabStop = true;
            this.relectronics.Text = "Electronics";
            this.relectronics.UseVisualStyleBackColor = true;
            // 
            // rkids
            // 
            this.rkids.AutoSize = true;
            this.rkids.Location = new System.Drawing.Point(108, 85);
            this.rkids.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rkids.Name = "rkids";
            this.rkids.Size = new System.Drawing.Size(54, 20);
            this.rkids.TabIndex = 6;
            this.rkids.TabStop = true;
            this.rkids.Text = "Kids";
            this.rkids.UseVisualStyleBackColor = true;
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Location = new System.Drawing.Point(5, 85);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(65, 16);
            this.lblcat.TabIndex = 3;
            this.lblcat.Text = "Category:";
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Location = new System.Drawing.Point(45, 31);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(96, 16);
            this.lblpname.TabIndex = 2;
            this.lblpname.Text = "Product Name:";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(548, 27);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 22);
            this.txtprice.TabIndex = 1;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(155, 28);
            this.txtproductname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(100, 22);
            this.txtproductname.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(252, 398);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(312, 41);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lstsellers
            // 
            this.lstsellers.FormattingEnabled = true;
            this.lstsellers.ItemHeight = 16;
            this.lstsellers.Location = new System.Drawing.Point(61, 34);
            this.lstsellers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstsellers.Name = "lstsellers";
            this.lstsellers.Size = new System.Drawing.Size(667, 132);
            this.lstsellers.TabIndex = 8;
            this.lstsellers.SelectedIndexChanged += new System.EventHandler(this.lstsellers_SelectedIndexChanged);
            // 
            // lblselectseller
            // 
            this.lblselectseller.AutoSize = true;
            this.lblselectseller.Location = new System.Drawing.Point(59, 9);
            this.lblselectseller.Name = "lblselectseller";
            this.lblselectseller.Size = new System.Drawing.Size(92, 16);
            this.lblselectseller.TabIndex = 9;
            this.lblselectseller.Text = "Choose Seller";
            // 
            // btnshowall
            // 
            this.btnshowall.Enabled = false;
            this.btnshowall.Location = new System.Drawing.Point(493, 5);
            this.btnshowall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 18;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnsearchseller
            // 
            this.btnsearchseller.Location = new System.Drawing.Point(443, 5);
            this.btnsearchseller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearchseller.Name = "btnsearchseller";
            this.btnsearchseller.Size = new System.Drawing.Size(35, 23);
            this.btnsearchseller.TabIndex = 17;
            this.btnsearchseller.Text = "🔍";
            this.btnsearchseller.UseVisualStyleBackColor = true;
            this.btnsearchseller.Click += new System.EventHandler(this.btnsearchseller_Click);
            // 
            // lblsearchseller
            // 
            this.lblsearchseller.AutoSize = true;
            this.lblsearchseller.Location = new System.Drawing.Point(185, 9);
            this.lblsearchseller.Name = "lblsearchseller";
            this.lblsearchseller.Size = new System.Drawing.Size(108, 16);
            this.lblsearchseller.TabIndex = 16;
            this.lblsearchseller.Text = "Search by name:";
            // 
            // txtsellerbyname
            // 
            this.txtsellerbyname.Location = new System.Drawing.Point(307, 5);
            this.txtsellerbyname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsellerbyname.Name = "txtsellerbyname";
            this.txtsellerbyname.Size = new System.Drawing.Size(129, 22);
            this.txtsellerbyname.TabIndex = 15;
            // 
            // Product_To_Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsearchseller);
            this.Controls.Add(this.lblsearchseller);
            this.Controls.Add(this.txtsellerbyname);
            this.Controls.Add(this.lblselectseller);
            this.Controls.Add(this.lstsellers);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grpaddproduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product_To_Seller";
            this.Text = "Product_To_Seller";
            this.grpaddproduct.ResumeLayout(false);
            this.grpaddproduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpaddproduct;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblproductnameerror;
        private System.Windows.Forms.Label lblpriceerror;
        private System.Windows.Forms.Label lblcate;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.CheckBox checkspacial;
        private System.Windows.Forms.Label lblspacial;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.RadioButton rclothing;
        private System.Windows.Forms.RadioButton roffice;
        private System.Windows.Forms.RadioButton relectronics;
        private System.Windows.Forms.RadioButton rkids;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox lstsellers;
        private Label lblselectseller;
        private Button btnshowall;
        private Button btnsearchseller;
        private Label lblsearchseller;
        private TextBox txtsellerbyname;
        private Label label1;

        public ListBox Sellerslst
        {
            get { return lstsellers; }
        }
    }
}