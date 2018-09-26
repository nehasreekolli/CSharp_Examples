using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractisePrograms
{
    class BinarySearch
    {
        public static void binarySearch(int[] arr, int searchNo,int lowerLimit, int upperLimit)
        {
            if (lowerLimit <= upperLimit )
            {
                int mid = (lowerLimit + upperLimit) / 2;
                if (arr[mid] == searchNo)
                {
                    Console.WriteLine("No found at {0} position", mid);
                }
                else if (arr[mid] > searchNo)
                {
                    binarySearch(arr, searchNo, lowerLimit, mid - 1);
                }
                else if (arr[mid] < searchNo)
                {
                    binarySearch(arr, searchNo, mid + 1, upperLimit);
                }
            }
            Console.WriteLine("No not found");
        }
    }
}
