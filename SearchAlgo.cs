using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class SearchAlgo
    {
        //linear search
        public static int LinearSearch(int[] arr, int ele)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ele)
                {
                    return i;
                }
            }
            return -1;
        }

        //Binary search
        //recursive approach
        public static int BinarySearch(int[] arr, int ele, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }
            else
            {
                int mid = (low + high) / 2;
                if (arr[mid] == ele)
                {
                    return mid;
                }
                else if (arr[mid] > ele)
                {
                    return BinarySearch(arr,ele,low,mid - 1);
                }
                else if(arr[mid] < ele)
                { 
                    return BinarySearch(arr, ele, mid + 1, high);
                }
            }
            return -1;
        }

        //Binary Search
        //Iteartive approach

        public static int binary(int[] array, int searchEle,int low, int high)
        {
            while( low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == searchEle)
                {
                    return mid;
                }
                else if (array[mid] > searchEle)
                {
                    high = mid - 1; 
                }
                else if (array[mid] < searchEle)
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
