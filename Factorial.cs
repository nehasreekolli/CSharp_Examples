using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class Factorial
    {
        public static int factorialRecursive(int no)
        {
            if (no < 0)
            {
                return -1;
            }
            else if (no == 0)
            {
                return 1;
            }
            else
                return (no * factorialRecursive(no - 1));
        }

        public static int factorial(int no)
        {
            int fact = 1;
            for(int i = 1; i <= no; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
