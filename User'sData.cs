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
    public partial class User_sData : Form
    {
        private int BUYER_OR_SELLER_INDICATOR;
        private int user_index;
        private const int Buyer_indicator = 1;
        private const int seller_indicator = 2;
        public int BUYER_OR_SELLER_
        {
            get { return BUYER_OR_SELLER_INDICATOR; }
            set { BUYER_OR_SELLER_INDICATOR = value; }
        }
        public User_sData()
        {
            InitializeComponent();
        }

        private void lstusers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstusers.SelectedIndex!=-1)
            {
                lstproducts.Visible = false;
                btnshowproduct.Text = "show products";
                if (BUYER_OR_SELLER_ == Buyer_indicator)
                {

                    
                        string name = lstusers.SelectedItem.ToString();
                        user_index = Program.Eshop.get_user_by_name(name, Buyer_indicator);
                        Buyer temp = Program.Eshop.Buyers[user_index];
                        lblinfo.Text = temp.ToString();
                        btnshowproduct.Visible = true;
                        if (temp.ShoppingCart.Count == 0) btnshowproduct.Enabled = false;
                        else btnshowproduct.Enabled = true;
                    

                }
                if (BUYER_OR_SELLER_ == seller_indicator)
                {
                    
                        string name = lstusers.SelectedItem.ToString();
                        user_index = Program.Eshop.get_user_by_name(name, seller_indicator);
                        Seller temp = Program.Eshop.Sellers[user_index];
                        lblinfo.Text = temp.ToString();
                        btnshowproduct.Visible = true;
                        if (temp.Selling_Items.Count == 0) btnshowproduct.Enabled = false;
                        else btnshowproduct.Enabled = true;
                    
                }
            }
        }

        private void btnshowproduct_Click(object sender, EventArgs e)
        {
            if (btnshowproduct.Text == "show products")
            {
                if (BUYER_OR_SELLER_ == Buyer_indicator)
                {
                    Buyer temp = Program.Eshop.Buyers[user_index];
                    temp.print_cart(lstproducts);
                    lstproducts.Visible = true;
                    btnshowproduct.Text = "hide products";
                }
                if (BUYER_OR_SELLER_ == seller_indicator)
                {
                    Seller temp = Program.Eshop.Sellers[user_index];
                    temp.print_seller_items(lstproducts);
                    lstproducts.Visible = true;
                    btnshowproduct.Text = "hide products";
                }
            }
            else if (btnshowproduct.Text == "hide products")
            {
                lstproducts.Items.Clear();
                lstproducts.Visible = false;
                btnshowproduct.Text = "show products";
            }
        }

        private void lstproducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_sData_Load(object sender, EventArgs e)
        {

        }

        private void btnsearchseller_Click(object sender, EventArgs e)
        {
            string name=txtuserbyname.Text;
            Program.Eshop.filter_users_by_name(Lstusers, name, BUYER_OR_SELLER_);
            if(lstusers.Items.Count==0) lstusers.Items.Add("NO RESULTS FOUND!");
            this.btnshowall.Enabled = true;
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            Program.Eshop.print_users(lstusers, BUYER_OR_SELLER_);
            txtuserbyname.Text = string.Empty;
        }
    }
}
