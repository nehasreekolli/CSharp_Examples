using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractisePrograms
{
    class Reverse_No
    {
        public static int reverse_no(int no)
        {
            int reverse = 0;
            while(no > 0)
            {
                int remainder = no % 10;
                reverse = (reverse * 10) + remainder;
                no = no / 10;
            }
            return reverse;
        }
    }
}
