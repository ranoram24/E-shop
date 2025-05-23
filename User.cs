using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Ran_Uram_Daniel_Geron
{
    abstract class User
    {
        protected string username;
        protected string password;
        protected Address adress;
        public User(string username, string password, Address adress)
        {
            Username = username;
            Password = password;
            Adress = adress;
        }
        public User()
        { }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User(User other)
        {
            Username = other.username;
            Password = other.password;
            Adress = other.adress;
        }
        public string Username
        {
            get { return this.username; }
            set
            {
                input_check(value);
                this.username = value;
            }
        }
        public string Password
        {
            get { return this.password; }
            set
            {
                input_check(value);
                this.password = value;
            }
        }
        public Address Adress
        {
            get { return this.adress; }
            set { this.adress = new Address(value); }
        }
        public override string ToString()
        {
            string str = "NAME: " + Username + "\n" + "PASSWORD: " + Password + "\n" + Adress.ToString();
            return str;
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

        public override bool Equals(object other)
        {
            User temp = other as User;
            if (temp == null)
            {
                return false;
            }
            return username.Equals(temp.Username) && password.Equals(temp.Password) && adress.Equals(temp.Adress);
        }
    }
}
