using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Ran_Uram_Daniel_Geron
{
    static class Functions
    {
        public static string input_check(string str)
        {
            if (str == null || str.Length == 0)
            {
                return "Field Empty!";
            }
            if (str[0] == ' ')
            {
                return "cant start with a spaceline";
            }
            if (str[str.Length - 1] == ' ')
            {
                return "cant end on a spaceline";
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
                return "cant have consecutive spaces!";
            }
            if (str.Length > 9) return "maximum of 9 characters";
            
            return null;
        }
    }
}
