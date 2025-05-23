using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5_Ran_Uram_Daniel_Geron
{
    internal class Seller:User,IComparable<Seller>
    {
        private List<Product> selling_items = new List<Product>();

        public Seller(string username, string password, Address adress) : base(username, password, adress)
        { }
        public Seller() : base() { }
        public Seller(string username, string password) : base(username, password) { }
        public Seller(Seller other) : base(other) { }
        public List<Product> Selling_Items
        {
            get { return selling_items; }
        }
        public void add_product(Product new_product)
        {
            Special_Product temp = new_product as Special_Product;
            if (temp != null)
            {
                selling_items.Add(new Special_Product(temp));
                Console.WriteLine("Product " + temp.Name + " added to seller " + this.Username);
            }
            else
            {
                selling_items.Add(new Product(new_product));
                Console.WriteLine("Product " + new_product.Name + " added to seller " + this.Username);
            }
        }
        public void print_seller_items(ListBox list)
        {
            list.Items.Clear();
            for (int i = 0; i < selling_items.Count; i++)
            {
                list.Items.Add(selling_items[i]);
            }
        }
        public bool equal(Object other)
        {
            Seller temp = other as Seller;
            if (temp == null) return false;
            if (this.Selling_Items.Count != temp.Selling_Items.Count) return false;
            for (int i = 0; i < Selling_Items.Count; i++)
            {
                if (this.Selling_Items[i].Id != this.Selling_Items[i].Id) return false;
            }
            return true;
        }
        public int CompareTo(Seller other)
        {
            if (this.Selling_Items.Count < other.Selling_Items.Count) return -1;
            if (this.Selling_Items.Count > other.Selling_Items.Count) return 1;
            else return 0;
        }
    }
}
