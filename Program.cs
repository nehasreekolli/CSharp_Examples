using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = new int[] { 1, 2, 4, 5, 6, 7 };
            //int element = 5;
            //Console.WriteLine(SearchAlgo.LinearSearch(arr1, element));
            //int low = 0;
            //int high = arr1.Length;
            //recursive
            //Console.WriteLine(SearchAlgo.BinarySearch(arr1, element, low, high));
            //iterative
            //Console.WriteLine(SearchAlgo.binary(arr1, element, low, high));
            //int[] arr2 = new int[7];
            //Console.WriteLine(FibnocciSeries.fibonocciSeries(arr2, 0, 1));
            //Console.WriteLine(FibnocciSeries.GetNthFibonacci_Ite(7));
            //Console.WriteLine(LeapYear.LeapYr(2000));
            //Console.WriteLine(AddDigits.addDigit(123));
            //Console.WriteLine(Factorial.factorial(4));
            //Console.WriteLine(Factorial.factorialRecursive(4));
            //Console.WriteLine(DecimatToBinary.decimalToBinary(12));
            //swapping.swap(3, 4);
            //swapping.swapUsingTemp(3, 4);
            //swapping.swappingXOR(3, 4);
            //ReverseNo.reverseNo(123);
            //Plaindrome.palindrome(1221);
            //int[] sortArray = new int[] {1,5,4,8};
            //SortingAlgorithms.bubbleSort(sortArray);

            //stack st = new stack();
            //st.emp();

            //QueueImp queue = new QueueImp();
            //queue.quueImp();

            OrderTraversal traverse = new OrderTraversal();
            OrderTraversal.Tree binaryTree = new OrderTraversal.Tree();
            binaryTree.add(2);
            binaryTree.add(5);
            binaryTree.add(10);

            OrderTraversal.InOrderPrint(binaryTree.root);
            
            Console.ReadLine();
        }
    }
}
