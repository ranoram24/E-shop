using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Q5_Ran_Uram_Daniel_Geron
{
    
    public partial class Product_To_Seller : Form
    {
        private string current_username;
        private int current_index;
        public Product_To_Seller()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear_error_messeges()
        {
            lblcate.Text = string.Empty;
            lblproductnameerror.Text = string.Empty;
            lblpriceerror.Text = string.Empty;

        }

        public string price_check(string str)
        {
            if (str == string.Empty) return "Field Empty!";
            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= '0' && str[i] <= '9')&& (str[i]!='.')) return "must contain only numbers";
            }
            float str2 = float.Parse(str);
            if (str2 < 1) return "price need to be at least 1";
            
            if (str.Length > 6) return "maximum of 6 characters";
            return null;
        }
        private bool is_valid()
        {
            bool valid = true;
            clear_error_messeges();
            if (return_category_num() == 0)
            {
                lblcate.Text = "pick category!";
                valid = false;
            }
            string producterror =Functions.input_check(txtproductname.Text);
            if (producterror != null)
            {
                lblproductnameerror.Text = producterror;
                valid = false;
            }
            string price = price_check(txtprice.Text);
            if(price!= null) { lblpriceerror.Text = price; valid = false;}
            
            return valid;
        }
        private int return_category_num()
        {
            if (rkids.Checked == true) return 1;
            else if (relectronics.Checked == true) return 2;
            else if (roffice.Checked == true) return 3;
            else if (rclothing.Checked == true) return 4;
            else return 0;
        }
        private void clear_category()
        {
            rclothing.Checked = false;
            rkids.Checked = false;
            relectronics.Checked = false;
            roffice.Checked = false;
        }
        private void btncreate_Click(object sender, EventArgs e)
        {
            if (is_valid())
            {
                try
                {
                    string product_name = txtproductname.Text;
                    float product_price = float.Parse(txtprice.Text);
                    int category = return_category_num();
                    if (checkspacial.Checked == true)
                    {
                        Special_Product p = new Special_Product(product_name, product_price, category);
                        Program.Eshop.add_product_to_seller(current_index, p);
                        MessageBox.Show("product added to " + current_username + " successfully!");
                        this.Close();
                    }
                    else
                    {
                        Product p = new Product(product_name, product_price, category);
                        Program.Eshop.add_product_to_seller(current_index, p);
                        MessageBox.Show("product added to " + current_username + " successfully!");
                        this.Close();
                    }
                }
                catch (FormatException ev)
                {
                    lblpriceerror.Text = "must be float!";
                }
                catch (OverflowException eh)
                {
                    lblpriceerror.Text = "must be in range of float";
                }
                catch (ArgumentException error)
                {
                    lblpriceerror.Text = error.Message;
                    txtprice.Text = string.Empty;
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear_error_messeges();
            txtproductname.Text = string.Empty;
            txtprice.Text = string.Empty;
            clear_category();
            checkspacial.Checked = false;
        }

     

        private void lstsellers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstsellers.SelectedItem!=null)
            {
                current_username=lstsellers.SelectedItem.ToString();
                grpaddproduct.Visible = true;
                this.Text = "adding product to seller " + current_username;
                current_index = Program.Eshop.get_user_by_name(current_username, 2);



            }
        }

        private void lblspacial_Click(object sender, EventArgs e)
        {

        }

        private void btnsearchseller_Click(object sender, EventArgs e)
        {
            string username = txtsellerbyname.Text;
            Program.Eshop.filter_users_by_name(lstsellers, username, 2);
            if (lstsellers.Items.Count == 0) { lstsellers.Items.Add("NO RESULTS FOUND!"); }
            this.btnshowall.Enabled = true;
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            Program.Eshop.print_users(lstsellers, 2);
            txtsellerbyname.Text = string.Empty;
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
