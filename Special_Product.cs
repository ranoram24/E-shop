using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Ran_Uram_Daniel_Geron
{
    internal class Special_Product:Product
    {
        private float package_price = 50;
        public Special_Product(string name, float price, int category) : base(name, price, category)
        {

        }
        public Special_Product(int id, string name, float price, int category) : base(id, name, price, category) { }
        public Special_Product(Special_Product other) : base(other)
        {

        }
        public float Package_Price
        {
            get { return package_price; }
            set
            {
                if (value < 0) throw new ArgumentException("PACKAGE PRICE CAN'T BE NEGETIVE");
                package_price = value;
            }
        }
        public float Total_Price
        {
            get { return base.Price + this.Package_Price; }
        }
        public override string ToString()
        {
            return base.ToString() + "\n TOTAL PRICE WITH " + package_price+" PACKAGE PRICE: " + Total_Price;
        }
        public override bool Equals(object other)
        {
            Special_Product temp = other as Special_Product;
            if (temp == null)
            {
                return false;
            }
            return Package_Price == temp.Package_Price && base.Equals(temp);
        }
       

    }
}
