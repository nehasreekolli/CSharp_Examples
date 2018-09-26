using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractisePrograms
{
    class Reverse
    {
        public static string reverseString(string str)
        {
            string rev_string = String.Empty;
            int str_length = str.Length;
            for(int i = str_length - 1; i >= 0; i--)
            {
                rev_string += str[i];
            }
            return rev_string;
        }
    }
}
