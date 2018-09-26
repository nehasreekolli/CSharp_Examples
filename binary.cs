using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractisePrograms
{
    class binary
    {
        public static int binarySearch(int[] array, int searchEle, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }
            else
            {
                binary bin = new binary();
                int mid = (low + high) / 2;
                if (array[mid] == searchEle)
                {
                    return mid;
                }
                else if (searchEle < array[mid])
                {
                    return binarySearch(array, searchEle, low, mid - 1);

                }
                else if (searchEle > array[mid])
                {
                    return binarySearch(array, searchEle, mid + 1, high);
                }
                return -1;
            }
            
        }

      
    }
}
