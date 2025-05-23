using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Ran_Uram_Daniel_Geron
{
    internal class Product
    {
        private static int product_id = 1000;
        private readonly int id;
        private string name;
        private float price;
        public enum Ecategory { kids = 1, electronic = 2, office = 3, clothing = 4 };
        private Ecategory category;
        public Product(string name, float price, int category)
        {
            Name = name;
            Price = price;
            Category = (Ecategory)category;
            this.id = product_id;
            product_id++;
        }
        public Product(int id, string name, float price, int category)
        {
            this.id = id;
            Name = name;
            Price = price;
            Category = (Ecategory)category;
            product_id++;
        }

        public Ecategory Category
        {
            get { return category; }
            set
            {
                if (!Enum.IsDefined(typeof(Ecategory), value))
                {
                    throw new ArgumentException("Invalid category.");
                }
                category = value;
            }
        }
        private bool IsValidEcategory(Ecategory value)
        {
            foreach (Ecategory ecategory in Enum.GetValues(typeof(Ecategory)))
            {
                if (ecategory == value)
                {
                    return true;
                }
            }
            return false;
        }
        public string Name
        {
            get { return name; }
            set
            {
                input_check(value);
                name = value;
            }
        }
        public virtual float Price
        {
            get { return price; }
            set
            {
                if (value < 1) throw new ArgumentException("PRICE NEED TO BE AT LEAST 1");
                price = value;
            }
        }
        public int Id
        {
            get { return id; }

        }

        public Product(Product other)
        {
            Name = other.Name;
            Price = other.Price;
            Category = (Ecategory)other.Category;
            this.id = other.Id;
        }
        static void input_check(string str)
        {
            if (str == null || str.Length == 0)
            {
                throw new ArgumentException("STRING CANT BE EMPTY!!!");
            }
            if (str[str.Length - 1] == ' ')
            {
                throw new ArgumentException("CANT END ON A SPACE LINE!");
            }
            bool have_consecutive_spaces = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    have_consecutive_spaces = true;
                    break;

                }
            }
            if (have_consecutive_spaces == true)
            {
                throw new ArgumentException("NO MORE THEN ONE CONSECUTIVE SPACE BETWEEN WORDS!");
            }
        }

        public override string ToString()
        {
            string str = "ID: " + Id + "\n NAME: " + Name + "\n PRICE: " + Price + "\n CATEGORY: " + Category;
            return str;
        }
        public override bool Equals(object other)
        {
            Product temp = other as Product;
            if (temp == null)
            {
                return false;
            }
            return Name.Equals(temp.Name) && Price == temp.Price;
        }
        
    }
}
