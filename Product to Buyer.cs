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
    public partial class Product_to_Buyer : Form
    {
        private string buyer_username;
        private int buyer_index;
        public Product_to_Buyer()
        {
            InitializeComponent();
        }



    private void lstproductbyname_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lstallbuyers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstallbuyers.SelectedItem!=null)
            {
                buyer_username=lstallbuyers.SelectedItem.ToString();
                this.Text = "adding product to buyer " + buyer_username;
                Program.Eshop.show_all_products(lstproductbyname);
                this.lstproductbyname.Visible = true;
                this.btnsearch.Enabled = true;
                this.txtsearch.Enabled=true;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string product_name=txtsearch.Text;
            Program.Eshop.print_product_by_name(product_name, lstproductbyname);
            if(lstproductbyname.Items.Count==0) { lstproductbyname.Items.Add("No Results"); }
            btnshow.Enabled = true;
            
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            Program.Eshop.show_all_products(lstproductbyname);
            txtsearch.Text = string.Empty;
        }

        private void Product_to_Buyer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsearchseller_Click(object sender, EventArgs e)
        {
            string username=txtbuyerbyname.Text;
            Program.Eshop.filter_users_by_name(lstallbuyers, username,1);
            if (lstallbuyers.Items.Count==0) { lstallbuyers.Items.Add("NO RESULTS FOUND!"); }
            this.btnshowall.Enabled = true;
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            Program.Eshop.print_users(lstallbuyers, 1);
            txtbuyerbyname.Text = string.Empty;
        }

        private void lstproductbyname_DoubleClick(object sender, EventArgs e)
        {
            Product temp = lstproductbyname.SelectedItem as Product;
            if (temp != null)
            {
                buyer_index = Program.Eshop.get_user_by_name(buyer_username, 1);
                Program.Eshop.add_product_to_buyer(buyer_index, temp.Id);
                MessageBox.Show("Product added to buyer " + buyer_username + " Successfully!");
                this.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
