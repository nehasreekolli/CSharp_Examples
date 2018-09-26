using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class FibnocciSeries
    {
        //fibonocci series
        public static string fibonocciSeries(int[] arr, int first, int second)
        {
            arr[0] = first;
            arr[1] = second;
            for (int i = 2; i <= arr.Length - 1; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return String.Join(",", arr);
        }

        //Get nth no in fibonocci series
        public static int GetNthFibonacci_Ite(int n)
        {
            int number = n - 1; //Need to decrement by 1 since we are starting from 0
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }
    }
}
