using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractisePrograms
{
    class linear
    {
        public static int linearSearch(int[] linearArray, int searchEle)
        {
            for (int i = 0; i < linearArray.Length; i++)
            {
                if (linearArray[i] == searchEle)
                {
                    Console.WriteLine("Element found");
                    return i;
                }
            }
            Console.WriteLine("Not found");
            return -1;      
        }
    }
}
