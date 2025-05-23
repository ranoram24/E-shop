using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ran Uram 206661886
//Daniel Geron 212515522
namespace Q5_Ran_Uram_Daniel_Geron
{
    public partial class Form1 : Form
    {
        public const int BUYER_INDICATOR = 1;
        public const int SELLER_INDICATOR = 2;
        private bool saved_clicked = false;
        public Form1()
        {
            InitializeComponent();
            Program.Eshop.seller_from_file();
            this.FormClosing += YourFormName_FormClosing;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.saved_clicked = true;
            Program.Eshop.save_sellers();
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Add_User ne=new Add_User();
            ne.ShowDialog();
        }

        private void btnproductseller_Click(object sender, EventArgs e)
        {
            Product_To_Seller ne=new Product_To_Seller();
            Program.Eshop.print_users(ne.Sellerslst, SELLER_INDICATOR);
            ne.ShowDialog();
        }

        private void btnproductbuyer_Click(object sender, EventArgs e)
        {
            if (Program.Eshop.Buyers.Count == 0)
            {
                MessageBox.Show("NO BUYERS EXIST");
            }
            else
            {
                Product_to_Buyer ne = new Product_to_Buyer();
                Program.Eshop.print_users(ne.Buyerlst, BUYER_INDICATOR);
                ne.ShowDialog();
            }
        }

        private void btnshowsellers_Click(object sender, EventArgs e)
        {
            if (Program.Eshop.Sellers.Count == 0)
            {
                MessageBox.Show("NO SELLERS EXIST!");
            }
            else
            {
                User_sData ne = new User_sData();
                Program.Eshop.print_users(ne.Lstusers, SELLER_INDICATOR);
                ne.BUYER_OR_SELLER_ = SELLER_INDICATOR;
                ne.ShowDialog();
            }
        }

        private void btnallbuyers_Click(object sender, EventArgs e)
        {
            if (Program.Eshop.Buyers.Count == 0)
            {
                MessageBox.Show("NO BUYERS EXIST");
            }
            else
            {
                User_sData ne = new User_sData();
                Program.Eshop.print_users(ne.Lstusers, BUYER_INDICATOR);
                ne.BUYER_OR_SELLER_ = BUYER_INDICATOR;
                ne.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void YourFormName_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved_clicked==false)
            {
                DialogResult result = MessageBox.Show(
                    "Closing the form with the X button will not save your data. Do you want to continue?",
                    "Unsaved Data Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void lblnames_Click(object sender, EventArgs e)
        {

        }
    }
}
