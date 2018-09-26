using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class AddDigits
    {
        public static int addDigit(int no)
        {
            int sum = 0;
            while (no > 0)
            {
                int remainder = no % 10;
                no = no / 10;
                sum = sum + remainder;
            }
            return sum;
        }
        
    }
}
