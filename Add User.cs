using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5_Ran_Uram_Daniel_Geron
{
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (text_valid())
            {
                try
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    string city = txtcity.Text;
                    string street = txtstreet.Text;
                    string country = txtCountry.Text;
                    int housenum = int.Parse(txtHousenum.Text);

                    Seller newone = new Seller(username, password);

                    newone.Adress = new Address(city, country, street, housenum);
                    Program.Eshop = Program.Eshop + newone;
                    MessageBox.Show("Seller " + username + " was added successfully!");
                    this.Close();

                }
                catch (FormatException ex)
                {
                    lblHouseNumError.Text = "Integer Only";
                    txtHousenum.Text = string.Empty;
                }
                catch (OverflowException ey)
                {
                    lblHouseNumError.Text = "Integer Range Exceeded";
                    txtHousenum.Text = string.Empty;
                }
                catch (ArgumentException error)
                {
                    MessageBox.Show(error.Message);

                }
            }
        }
        public string housenum(string str)
        {
            if (str == string.Empty) return "Field Empty!";
            for (int i=0;i<str.Length;i++)
            {
                if (!(str[i] >= '0' && str[i] <= '9')) return "must contain only numbers";
            }
            if (str.Length > 9) return "maximum of 9 characters";
            return null;
        }
        private bool text_valid()
        {
            bool valid = true;
            ClearErrorMessages();
            string check = Functions.input_check(txtUsername.Text);
            if (check != null)
            {
                lblUsernameError.Text = check;
                valid = false;
            }
            if (Program.Eshop.is_username_exist(txtUsername.Text) == true)
            {
                lblUsernameError.Text = "USERNAME ALREADY TAKEN!";
                valid = false;
            }
            check = Functions.input_check(txtPassword.Text);
            if (check != null)
            {
                lblPasswordError.Text = check;
                valid = false;
            }

            check = Functions.input_check(txtcity.Text);
            if (check != null)
            {
                lblCityError.Text = check;
                valid = false;
            }
            check = have_number(txtcity.Text);
            if (check != null)
            {
                lblCityError.Text = check;
                valid = false;
            }
            check = Functions.input_check(txtstreet.Text);
            if (check != null)
            {
                lblStreetError.Text = check;
                valid = false;
            }
            check = have_number(txtstreet.Text);
            if (check != null)
            {
                lblStreetError.Text = check;
                valid = false;
            }
            check = Functions.input_check(txtCountry.Text);
            if (check != null)
            {
                lblCountryError.Text = check;
                valid = false;
            }
            check = have_number(txtCountry.Text);
            if (check != null)
            {
                lblCountryError.Text = check;
                valid = false;
            }        
            check = housenum(txtHousenum.Text);
            if(check != null)
            {
                lblHouseNumError.Text = check;
                valid = false;
            }
            
            return valid;
        }
        private string have_number(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    return "Numbers not Permitted";
                }
            }
            return null;
        }
        private void clear_textbox()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtcity.Text = string.Empty;
            txtstreet.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtHousenum.Text = string.Empty;
        }
        private void ClearErrorMessages()
        {
            lblUsernameError.Text = string.Empty;
            lblPasswordError.Text = string.Empty;
            lblCityError.Text = string.Empty;
            lblStreetError.Text = string.Empty;
            lblCountryError.Text = string.Empty;
            lblHouseNumError.Text = string.Empty;
        }
        private void btnbuyer_Click(object sender, EventArgs e)
        {
            if (text_valid())
            {
                try
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    string city = txtcity.Text;
                    string street = txtstreet.Text;
                    string country = txtCountry.Text;
                    int housenum = int.Parse(txtHousenum.Text);
                    Buyer newone = new Buyer(username, password);
                    newone.Adress = new Address(city, country, street, housenum);
                    Program.Eshop = Program.Eshop + newone;
                    MessageBox.Show("Buyer " + username + " was added successfuly!");
                    this.Close();

                }
                catch (FormatException ex)
                {
                  
                    lblHouseNumError.Text = "Integer Only";
                    txtHousenum.Text = string.Empty;
                }
                catch (OverflowException ey)
                {
                    lblHouseNumError.Text = "Integer Only";
                    txtHousenum.Text = string.Empty;
                }
                catch (ArgumentException error)
                {
                    MessageBox.Show(error.Message);
                    clear_textbox();
                }
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear_textbox();
            ClearErrorMessages();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblStreet_Click(object sender, EventArgs e)
        {

        }

        private void grpadress_Enter(object sender, EventArgs e)
        {

        }
    }
}
