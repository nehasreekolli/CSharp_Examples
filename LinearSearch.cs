using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractisePrograms
{
    class LinearSearch
    {
        public static void linearSearch(int[] arr, int searchNo)
        {
                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] == searchNo)
                    {
                        Console.WriteLine("No is found at {0}", i);
                    }
                }
        }
    }
}
