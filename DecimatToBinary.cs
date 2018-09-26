using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class DecimatToBinary
    {
        public static string decimalToBinary(int num)
        {
            int rem;
            string result = string.Empty;
            while (num > 0)
            {
                rem = num % 2;
                num = num / 2;
                result = rem.ToString() + result;
            }
            return result;
        }
    }
}
