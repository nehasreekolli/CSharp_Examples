using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractisePrograms
{
    class BubbleSort
    {
        public static void swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        public static void bubble(int[] array)
        {
            for(int i = 0; i< array.Length; i++)
            {
                for(int j = i; j< array.Length- 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        swap(array, j, j+1);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", array));
        }

    }
}
