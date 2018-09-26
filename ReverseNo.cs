using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class ReverseNo
    {
        public static void reverseNo(int no)
        {
            int reverse = 0;
            while (no > 0)
            {
                int rem = no % 10;
                reverse = (reverse * 10) + rem;
                no = no / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
