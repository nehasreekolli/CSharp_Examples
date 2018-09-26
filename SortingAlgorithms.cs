using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class SortingAlgorithms
    {
        //public static void swap(int i, int j)
        //{
        //    int temp = i;
        //    i = j;
        //    j = temp;
        //}
        //bubble sort
        public static void bubbleSort(int[] arr)
        {
            int temp;
            for(int i =0; i < arr.Length; i++)
            {
                for(int j = i+1; j< arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        //swap(arr[i], arr[j]);
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(",", arr));
        }

        ////selection sort
        //public static void selectionSort(int[] arr)
        //{

        //}

        //insertion sort
          static void insertionSort(String[] args)
            {
                int[] nos = new int[] { 4, 1, 5, 3, 2 };

                for (int i = 1; i < nos.Length; i++)
                {
                    int temp = nos[i];
                    int j = i - 1;
                    while (j >= 0 && temp < nos[j])
                    {
                        nos[j + 1] = nos[j];
                        j--;
                    }
                    nos[j + 1] = temp;
                }
                foreach (int no in nos)
                {
                    Console.WriteLine(no);
                }
                Console.Read();
            }

        //Quick sort

        //Merge Sort

        //Heap Sort


    
    }
}
