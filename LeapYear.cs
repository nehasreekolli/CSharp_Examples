using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class LeapYear
    {
        public static string LeapYr(int year)
        {
            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return "leap year";
            }
            return "not a leap year";
        }
    }
}
