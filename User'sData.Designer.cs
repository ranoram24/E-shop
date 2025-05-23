using System.Windows.Forms;

namespace Q5_Ran_Uram_Daniel_Geron
{
    partial class User_sData
    {
        public ListBox Lstusers 
        {
            get { return lstusers; }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_sData));
            this.lstproducts = new System.Windows.Forms.ListBox();
            this.btnshowproduct = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lstusers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnsearchuser = new System.Windows.Forms.Button();
            this.lblsearchuser = new System.Windows.Forms.Label();
            this.txtuserbyname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstproducts
            // 
            this.lstproducts.FormattingEnabled = true;
            this.lstproducts.ItemHeight = 16;
            this.lstproducts.Location = new System.Drawing.Point(12, 153);
            this.lstproducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstproducts.Name = "lstproducts";
            this.lstproducts.Size = new System.Drawing.Size(803, 132);
            this.lstproducts.TabIndex = 11;
            this.lstproducts.Visible = false;
            this.lstproducts.SelectedIndexChanged += new System.EventHandler(this.lstproducts_SelectedIndexChanged);
            // 
            // btnshowproduct
            // 
            this.btnshowproduct.Location = new System.Drawing.Point(639, 32);
            this.btnshowproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshowproduct.Name = "btnshowproduct";
            this.btnshowproduct.Size = new System.Drawing.Size(133, 32);
            this.btnshowproduct.TabIndex = 10;
            this.btnshowproduct.Text = "Show Products";
            this.btnshowproduct.UseVisualStyleBackColor = true;
            this.btnshowproduct.Visible = false;
            this.btnshowproduct.Click += new System.EventHandler(this.btnshowproduct_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(477, 40);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 16);
            this.lblinfo.TabIndex = 9;
            // 
            // lstusers
            // 
            this.lstusers.FormattingEnabled = true;
            this.lstusers.ItemHeight = 16;
            this.lstusers.Location = new System.Drawing.Point(12, 30);
            this.lstusers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstusers.Name = "lstusers";
            this.lstusers.Size = new System.Drawing.Size(443, 116);
            this.lstusers.TabIndex = 8;
            this.lstusers.SelectedIndexChanged += new System.EventHandler(this.lstusers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose User ";
            // 
            // btnshowall
            // 
            this.btnshowall.Enabled = false;
            this.btnshowall.Location = new System.Drawing.Point(399, 2);
            this.btnshowall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 22;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnsearchuser
            // 
            this.btnsearchuser.Location = new System.Drawing.Point(358, 3);
            this.btnsearchuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearchuser.Name = "btnsearchuser";
            this.btnsearchuser.Size = new System.Drawing.Size(35, 23);
            this.btnsearchuser.TabIndex = 21;
            this.btnsearchuser.Text = "🔍";
            this.btnsearchuser.UseVisualStyleBackColor = true;
            this.btnsearchuser.Click += new System.EventHandler(this.btnsearchseller_Click);
            // 
            // lblsearchuser
            // 
            this.lblsearchuser.AutoSize = true;
            this.lblsearchuser.Location = new System.Drawing.Point(104, 6);
            this.lblsearchuser.Name = "lblsearchuser";
            this.lblsearchuser.Size = new System.Drawing.Size(108, 16);
            this.lblsearchuser.TabIndex = 20;
            this.lblsearchuser.Text = "Search by name:";
            // 
            // txtuserbyname
            // 
            this.txtuserbyname.Location = new System.Drawing.Point(218, 3);
            this.txtuserbyname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuserbyname.Name = "txtuserbyname";
            this.txtuserbyname.Size = new System.Drawing.Size(129, 22);
            this.txtuserbyname.TabIndex = 19;
            // 
            // User_sData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(858, 315);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsearchuser);
            this.Controls.Add(this.lblsearchuser);
            this.Controls.Add(this.txtuserbyname);
            this.Controls.Add(this.lstproducts);
            this.Controls.Add(this.btnshowproduct);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.lstusers);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_sData";
            this.Text = "User_sData";
            this.Load += new System.EventHandler(this.User_sData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstproducts;
        private System.Windows.Forms.Button btnshowproduct;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.ListBox lstusers;
        private System.Windows.Forms.Label label1;
        private Button btnshowall;
        private Button btnsearchuser;
        private Label lblsearchuser;
        private TextBox txtuserbyname;
    }
}