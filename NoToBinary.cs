using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractisePrograms
{
    class NoToBinary
    {
        public static string noToBinary(int no)
        {
            int rem;
            string result = String.Empty;
            while (no > 0)
            {
                rem = no % 2;
                no = no / 2;
                result = rem.ToString() + result;
            }
            return result;
        }
    }
}
