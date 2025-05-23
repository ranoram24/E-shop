using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5_Ran_Uram_Daniel_Geron
{
    internal class Buyer:User
    {
        private List<Product> shopping_cart = new List<Product>();
        private float cartprice = 0;

        public Buyer(string username, string password, Address adress) : base(username, password, adress)
        { }
        public Buyer(string username, string password) : base(username, password)
        { }
        public Buyer(Buyer other) : base(other) { }
        public float Cart_Price
        {
            get { return cartprice; }
            set
            {
                cartprice = value;
            }
        }
        public List<Product> ShoppingCart { get { return shopping_cart; } }
        public void add_product(Product new_product)
        {
            Special_Product temp = new_product as Special_Product;
            if (temp != null)
            {
                shopping_cart.Add(new Special_Product(temp));
                Console.WriteLine("Product " + temp.Name + " added to buyer " + this.Username);
                Cart_Price += temp.Total_Price;

            }
            else
            {
                shopping_cart.Add(new Product(new_product));
                Console.WriteLine("Product " + new_product.Name + " added to buyer " + this.Username);
                Cart_Price += new_product.Price;
            }
        }
        public void print_cart(ListBox list)
        {
            list.Items.Clear();
            for (int i = 0; i < shopping_cart.Count; i++)
            {
                list.Items.Add(shopping_cart[i].ToString());
            }
        }
        public bool equal(Object other)
        {
            Buyer temp = other as Buyer;
            if (temp == null) return false;
            if (this.shopping_cart.Count != temp.shopping_cart.Count) return false;
            for (int i = 0; i < shopping_cart.Count; i++)
            {
                if (this.ShoppingCart[i].Id != this.ShoppingCart[i].Id) return false;
            }
            return true;
        }
        
    }
}
