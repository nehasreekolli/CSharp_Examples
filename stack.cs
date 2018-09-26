using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class stack
    {
        //using default/existed methods
        Stack<int> stackEmpl = new Stack<int>();
        public void emp()
        {
            stackEmpl.Push(1);
            stackEmpl.Push(2);
            Console.WriteLine(stackEmpl.Pop());
            Console.WriteLine(stackEmpl.Peek());
            foreach (int id in stackEmpl)
            {
                Console.WriteLine(id);
            }
            stackEmpl.Clear();
            Console.WriteLine(stackEmpl.Count());
        }

        //Implementing Stack using array(Fixed size)
        int[] array1 = new int[4];
        int index = 0;
        public void stackPushImp(int ele)
        {
            if (index <= 3)
            {
                array1[index] = ele;
                index++;
                foreach (int element in array1)
                {
                    Console.WriteLine(element);
                }
            }
        }

        public int stackPopImp()
        {
            if(index > 0)
            {
                index--;
                return array1[index];
            }
            return -1;
        }
    }
}
