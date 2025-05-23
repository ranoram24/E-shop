using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Ran_Uram_Daniel_Geron
{
    internal class Address
    {
        private string city;
        private string country;
        private string street;
        private int housenum;
        public Address(string city, string country, string street, int housenum)
        {
            City = city;
            Country = country;
            Street = street;
            Housenum = housenum;
        }
        public Address() { }
        public Address(Address other)
        {
            City = other.City;
            Country = other.Country;
            Street = other.Street;
            Housenum = other.Housenum;
        }
        public string City
        {
            get { return city; }
            set
            {
                input_check(value);
                if (!valid_string(value)) throw new ArgumentException("INVALID STRING! CAN'T HAVE A NUMBER IN IT!");
                city = value;
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                input_check(value);
                if (!valid_string(value)) throw new ArgumentException("INVALID STRING! CAN'T HAVE A NUMBER IN IT!");
                country = value;
            }
        }
        public string Street
        {
            get { return street; }
            set
            {
                input_check(value);
                if (!valid_string(value)) throw new ArgumentException("INVALID STRING! CAN'T HAVE A NUMBER IN IT!");
                street = value;
            }
        }
        public int Housenum
        {
            get { return housenum; }
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException("HOUSE NUM IS ATLEAST 1");
                housenum = value;
            }



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

        public bool valid_string(string str)
        {
            if (str == null)
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9') return false;
            }
            return true;
        }
        public override string ToString()
        {
            return "City: " + City + "\n" + "Street: " + Street + "\n" + "Housenum: " + Housenum + "\n" + "Country: " + Country;
        }
        public override bool Equals(object obj)
        {
            Address temp = obj as Address;
            if (temp == null) return false;
            return Housenum == temp.Housenum && City.Equals(temp.City) && Street.Equals(temp.Street) && Country.Equals(temp.Country);
        }
    }
}
