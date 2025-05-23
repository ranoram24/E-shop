using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5_Ran_Uram_Daniel_Geron
{
    internal class Eshop
    {
        private const int buyer_indicator = 1;
        private const int seller_indicator = 2;
        private const string system_name = "Eshop";
        private List<Buyer> buyersarr = new List<Buyer>();
        private List<Seller> sellerssarr = new List<Seller>();
        private string filename = "SELLER'S_INFO.TXT";

        public List<Seller> Sellers
        {
            get { return sellerssarr; }
        }
        public List<Buyer> Buyers
        {
            get { return buyersarr; }
        }
        public static Eshop operator +(Eshop manager, Buyer new_buyer)
        {
            manager.buyersarr.Add(new_buyer);
            return manager;
        }
        public static Eshop operator +(Eshop manager, Seller new_seller)
        {
            manager.sellerssarr.Add(new_seller);
            return manager;
        }
        public void save_sellers()
        {
            try
            {
                StreamWriter write = new StreamWriter(filename);
                for (int i = 0;i<Sellers.Count;i++)
                {
                    write.WriteLine($"USERNAME:{Sellers[i].Username}");
                    write.WriteLine($"PASSWORD:{Sellers[i].Password}");
                    Address ad = Sellers[i].Adress;
                    write.WriteLine($"Address:{ad.City}|{ad.Country}|{ad.Street}|{ad.Housenum}");
                    if (Sellers[i].Selling_Items.Count == 0) write.WriteLine("NO PRODUCTS");
                    else
                    {
                        for (int j = 0; j < Sellers[i].Selling_Items.Count; j++)
                        {
                            Special_Product temp = Sellers[i].Selling_Items[j] as Special_Product;
                            if (temp != null)
                            {
                               write.WriteLine($"PRODUCT:{temp.Id}|{temp.Name}|{temp.Price}|{temp.Category}|Special Package"); 
                            }
                            
                            else
                            {
                                Product p = Sellers[i].Selling_Items[j];
                                write.WriteLine($"PRODUCT:{p.Id}|{p.Name}|{p.Price}|{p.Category}|Regular Package");
                            }
                        }
                    }
                    write.WriteLine("END SELLER");
                }
                write.Close();
                MessageBox.Show("all sellers data saved to file!");
               
            }
            catch (Exception e)
            {
                MessageBox.Show($"ERROR SAVING DATA TO {filename},DATA NOT SAVED");
            }
        }
        public void seller_from_file()
        {
            try
            {
                if (File.Exists(filename)==false)
                {
                    MessageBox.Show("FILE DOES NOT EXIST! THE PROGRAM WILL START WITHOUT SELLERS!");
                    return;
                }
                string line;
                Seller temp = null;
                StreamReader read = new StreamReader(filename);
                while ((line = read.ReadLine()) != null)
                {
                    if (line.StartsWith("USERNAME:"))
                    {
                        string username = line.Substring(9);
                        string password = read.ReadLine().Substring(9);
                        string adress_line = read.ReadLine().Substring(8);
                        string[] parts = adress_line.Split('|');
                        Address ad = new Address(parts[0], parts[1], parts[2], int.Parse((parts[3])));
                        temp = new Seller(username, password, ad);
                        Program.Eshop = Program.Eshop + temp;
                    }
                    else if (line.StartsWith("PRODUCT:") && temp != null)
                    {
                        string[] part = line.Substring(8).Split('|');
                        int id = int.Parse(part[0]);
                        string product_name = part[1];
                        float price = float.Parse(part[2]);
                        int cate = product_category(part[3]);
                        if (part[4] == "Special Package")
                        {
                            Special_Product ne = new Special_Product(id,product_name, price, cate);
                            temp.add_product(ne);
                        }
                        else
                        {
                            Product n = new Product(id,product_name, price, cate);
                            temp.add_product(n);
                        }

                    }
                }
                read.Close();
            }
            catch (Exception e)
            {
                Sellers.Clear();
                MessageBox.Show("CANT UPLOAD SELLERS FROM FILE!\n THIS PROGRAM WILL START WITHOUT SELLERS!");
            }
        }
        

        public int product_category(string category)
        {
            if (category == "kids") return 1;
            else if (category == "electronics") return 2;
            else if (category == "office") return 3;
            else return 4;
        }

        public void add_product_to_seller(int seller_index, Product p)
        {
            sellerssarr[seller_index].add_product(p);
        }
        public bool add_product_to_buyer(int buyer_index, int product_id)
        {
            for (int i = 0; i < sellerssarr.Count; i++)
            {
                for (int j = 0; j < sellerssarr[i].Selling_Items.Count; j++)
                {
                    if (sellerssarr[i].Selling_Items[j].Id == product_id)
                    {
                        buyersarr[buyer_index].add_product(sellerssarr[i].Selling_Items[j]);
                        Console.WriteLine("Product was added to Buyer");
                        return true;
                    }
                }
            }
            return false;
        }

        public void print_product_by_name(string name, ListBox list)
        {
            list.Items.Clear();
            for (int i = 0; i < sellerssarr.Count; i++)
            {
                if (sellerssarr[i].Selling_Items.Count == 0) continue;
                for (int j = 0; j < sellerssarr[i].Selling_Items.Count; j++)
                {
                    if (sellerssarr[i].Selling_Items[j].Name == name)
                    {
                        list.Items.Add(sellerssarr[i].Selling_Items[j]);
                    }
                }
            }
        }
        public void filter_users_by_name(ListBox list,string username,int indicator)
        {
            list.Items.Clear();
            if (indicator==buyer_indicator)
            {
                for (int i = 0;i<Buyers.Count;i++)
                {
                    if (Buyers[i].Username == username) list.Items.Add(Buyers[i].Username);
                }
            }
            if (indicator == seller_indicator)
            {
                for (int i = 0;i<Sellers.Count;i++)
                {
                    if (Sellers[i].Username == username) list.Items.Add(Sellers[i].Username);
                }
            }
        }
        public bool is_username_exist(string username)
        {
            if (buyersarr.Count == 0 && sellerssarr.Count == 0) return false;
            else
            {
                if (buyersarr.Count != 0)
                {
                    for (int i = 0; i < buyersarr.Count; i++)
                    {
                        if (buyersarr[i].Username == username) return true;
                    }
                }
                if (sellerssarr.Count != 0)
                {
                    for (int i = 0; i < sellerssarr.Count; i++)
                    {
                        if (sellerssarr[i].Username == username) return true;
                    }
                }
            }
            return false;
        }
        public int get_user_by_name(string username, int indicator)
        {
            if (indicator == buyer_indicator)
            {
                if (buyersarr.Count == 0) return -1;
                else
                {
                    for (int i = 0; i < buyersarr.Count; i++)
                    {
                        if (buyersarr[i].Username == username) return i;
                    }
                }
            }
            if (indicator == seller_indicator)
            {
                if (sellerssarr.Count == 0) return -1;
                else
                {
                    for (int i = 0; i < sellerssarr.Count; i++)
                    {
                        if (sellerssarr[i].Username == username) return i;
                    }
                }
            }
            return -1;
        }

        public void show_all_products(ListBox list)
        {
            list.Items.Clear();
            for (int i = 0;i<Sellers.Count;i++)
            {
               for(int j = 0; j < Sellers[i].Selling_Items.Count;j++)
                {
                    list.Items.Add(Sellers[i].Selling_Items[j]);
                }
            }
        }
        public void print_users(ListBox list, int indicator)
        {
            list.Items.Clear();
            if (indicator == buyer_indicator)
            {
                if (buyersarr.Count == 0)
                {
                    MessageBox.Show("NO BUYERS EXIST!");
                    return;

                }
                else
                {
                    for (int i = 0; i < buyersarr.Count; i++)
                    {
                        list.Items.Add(buyersarr[i].Username);

                    }
                }
            }
            if (indicator == seller_indicator)
            {
                if (sellerssarr.Count == 0)
                {
                    MessageBox.Show("NO SELLERS EXIST");
                }
                else
                {
                    sellerssarr.Sort();
                    for (int i = 0; i < sellerssarr.Count; i++)
                    {
                        list.Items.Add(sellerssarr[i].Username);
                    }
                }
            }
        }
    }
}
