namespace Q5_Ran_Uram_Daniel_Geron
{
    partial class Add_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_User));
            this.grpuser = new System.Windows.Forms.GroupBox();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpadress = new System.Windows.Forms.GroupBox();
            this.lblStreetError = new System.Windows.Forms.Label();
            this.lblCityError = new System.Windows.Forms.Label();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtHousenum = new System.Windows.Forms.TextBox();
            this.lblCountryError = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.lblHouseNumError = new System.Windows.Forms.Label();
            this.lblHouseNum = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnseller = new System.Windows.Forms.Button();
            this.btnbuyer = new System.Windows.Forms.Button();
            this.grpuser.SuspendLayout();
            this.grpadress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpuser
            // 
            this.grpuser.Controls.Add(this.lblPasswordError);
            this.grpuser.Controls.Add(this.lblPassword);
            this.grpuser.Controls.Add(this.lblUsernameError);
            this.grpuser.Controls.Add(this.txtPassword);
            this.grpuser.Controls.Add(this.txtUsername);
            this.grpuser.Controls.Add(this.lblUsername);
            this.grpuser.Location = new System.Drawing.Point(128, 25);
            this.grpuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpuser.Name = "grpuser";
            this.grpuser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpuser.Size = new System.Drawing.Size(533, 89);
            this.grpuser.TabIndex = 23;
            this.grpuser.TabStop = false;
            this.grpuser.Text = "User Details";
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(346, 61);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 16);
            this.lblPasswordError.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(345, 18);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameError.Location = new System.Drawing.Point(63, 62);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(0, 16);
            this.lblUsernameError.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(349, 37);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(141, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(67, 37);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(63, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Tag = "username";
            this.lblUsername.Text = "Username:";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // grpadress
            // 
            this.grpadress.Controls.Add(this.lblStreetError);
            this.grpadress.Controls.Add(this.lblCityError);
            this.grpadress.Controls.Add(this.txtstreet);
            this.grpadress.Controls.Add(this.txtCountry);
            this.grpadress.Controls.Add(this.txtHousenum);
            this.grpadress.Controls.Add(this.lblCountryError);
            this.grpadress.Controls.Add(this.txtcity);
            this.grpadress.Controls.Add(this.lblHouseNumError);
            this.grpadress.Controls.Add(this.lblHouseNum);
            this.grpadress.Controls.Add(this.lblCountry);
            this.grpadress.Controls.Add(this.lblStreet);
            this.grpadress.Controls.Add(this.lblCity);
            this.grpadress.Location = new System.Drawing.Point(128, 124);
            this.grpadress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpadress.Name = "grpadress";
            this.grpadress.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpadress.Size = new System.Drawing.Size(539, 202);
            this.grpadress.TabIndex = 24;
            this.grpadress.TabStop = false;
            this.grpadress.Text = "Adress";
            this.grpadress.Enter += new System.EventHandler(this.grpadress_Enter);
            // 
            // lblStreetError
            // 
            this.lblStreetError.AutoSize = true;
            this.lblStreetError.ForeColor = System.Drawing.Color.Red;
            this.lblStreetError.Location = new System.Drawing.Point(346, 70);
            this.lblStreetError.Name = "lblStreetError";
            this.lblStreetError.Size = new System.Drawing.Size(0, 16);
            this.lblStreetError.TabIndex = 17;
            // 
            // lblCityError
            // 
            this.lblCityError.AutoSize = true;
            this.lblCityError.ForeColor = System.Drawing.Color.Red;
            this.lblCityError.Location = new System.Drawing.Point(64, 70);
            this.lblCityError.Name = "lblCityError";
            this.lblCityError.Size = new System.Drawing.Size(0, 16);
            this.lblCityError.TabIndex = 16;
            // 
            // txtstreet
            // 
            this.txtstreet.Location = new System.Drawing.Point(349, 46);
            this.txtstreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(139, 22);
            this.txtstreet.TabIndex = 11;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(349, 146);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(139, 22);
            this.txtCountry.TabIndex = 10;
            // 
            // txtHousenum
            // 
            this.txtHousenum.Location = new System.Drawing.Point(67, 146);
            this.txtHousenum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHousenum.Name = "txtHousenum";
            this.txtHousenum.Size = new System.Drawing.Size(129, 22);
            this.txtHousenum.TabIndex = 9;
            // 
            // lblCountryError
            // 
            this.lblCountryError.AutoSize = true;
            this.lblCountryError.ForeColor = System.Drawing.Color.Red;
            this.lblCountryError.Location = new System.Drawing.Point(346, 170);
            this.lblCountryError.Name = "lblCountryError";
            this.lblCountryError.Size = new System.Drawing.Size(0, 16);
            this.lblCountryError.TabIndex = 19;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(67, 46);
            this.txtcity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(129, 22);
            this.txtcity.TabIndex = 8;
            // 
            // lblHouseNumError
            // 
            this.lblHouseNumError.AutoSize = true;
            this.lblHouseNumError.ForeColor = System.Drawing.Color.Red;
            this.lblHouseNumError.Location = new System.Drawing.Point(64, 172);
            this.lblHouseNumError.Name = "lblHouseNumError";
            this.lblHouseNumError.Size = new System.Drawing.Size(0, 16);
            this.lblHouseNumError.TabIndex = 18;
            // 
            // lblHouseNum
            // 
            this.lblHouseNum.AutoSize = true;
            this.lblHouseNum.Location = new System.Drawing.Point(63, 128);
            this.lblHouseNum.Name = "lblHouseNum";
            this.lblHouseNum.Size = new System.Drawing.Size(101, 16);
            this.lblHouseNum.TabIndex = 7;
            this.lblHouseNum.Text = "House Number:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(345, 128);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(55, 16);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(345, 27);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(45, 16);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Street:";
            this.lblStreet.Click += new System.EventHandler(this.lblStreet_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(63, 27);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(115, 16);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City of Residence:";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(485, 394);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(132, 42);
            this.btnexit.TabIndex = 28;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(180, 394);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(133, 42);
            this.btnclear.TabIndex = 27;
            this.btnclear.Text = "Clear All";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnseller
            // 
            this.btnseller.Location = new System.Drawing.Point(485, 346);
            this.btnseller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnseller.Name = "btnseller";
            this.btnseller.Size = new System.Drawing.Size(132, 42);
            this.btnseller.TabIndex = 26;
            this.btnseller.Text = "Add as Seller";
            this.btnseller.UseVisualStyleBackColor = true;
            this.btnseller.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnbuyer
            // 
            this.btnbuyer.Location = new System.Drawing.Point(181, 347);
            this.btnbuyer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuyer.Name = "btnbuyer";
            this.btnbuyer.Size = new System.Drawing.Size(133, 42);
            this.btnbuyer.TabIndex = 25;
            this.btnbuyer.Text = "Add as Buyer";
            this.btnbuyer.UseVisualStyleBackColor = true;
            this.btnbuyer.Click += new System.EventHandler(this.btnbuyer_Click);
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnseller);
            this.Controls.Add(this.btnbuyer);
            this.Controls.Add(this.grpadress);
            this.Controls.Add(this.grpuser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_User";
            this.Text = "Add_User";
            this.grpuser.ResumeLayout(false);
            this.grpuser.PerformLayout();
            this.grpadress.ResumeLayout(false);
            this.grpadress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpuser;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox grpadress;
        private System.Windows.Forms.Label lblStreetError;
        private System.Windows.Forms.Label lblCityError;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtHousenum;
        private System.Windows.Forms.Label lblCountryError;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label lblHouseNumError;
        private System.Windows.Forms.Label lblHouseNum;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnseller;
        private System.Windows.Forms.Button btnbuyer;
    }
}