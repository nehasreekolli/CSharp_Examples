using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractisePrograms
{
    class InsertionSort
    {
        public static void swap(int[] a,int i, int j)
        {
            int temp = a[i];    
            a[i] = a[j];
            a[j] = temp;
        }
        public static void Insertionsort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int min = i;
                int j = i - 1;
                while(j >= 0 && array[j] > array[min])
                {
                    swap(array, min, j);
                    min = j;
                    j--;
                }
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
