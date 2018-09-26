using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class Plaindrome
    {
        public static void palindrome(int no)
        {
            int temp = no;
            int reverse = 0;
            while (no > 0)
            {
                int rem = no % 10;
                reverse = (reverse* 10) + rem;
                no = no / 10;
            }
            Console.WriteLine(reverse);
            Console.WriteLine(temp);
            Console.WriteLine(reverse);
            if (temp == reverse)
            {
                Console.WriteLine(temp + "is a palindrome");
            }
            else
                Console.WriteLine(temp + " is not a plaindrome");
        }
    }
}
