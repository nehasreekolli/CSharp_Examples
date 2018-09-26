using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class QueueImp
    {
        //Queue implementation using default/existing methods
        Queue<int> queue = new Queue<int>();
        public void quueImp()
        {
            queue.Enqueue(1);
            queue.Enqueue(2);
            foreach (int ele in queue)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            queue.Clear();
            Console.WriteLine(queue.Count);

        }


        //Queue implementation using array
        int[] array1 = new int[4];
        int index = -1;
        int popIndex = 0;
        public void queArrayEnque(int ele)
        {
            if(index <= 2)
            {
                array1[index + 1] = ele;
                index++;
                foreach (int element in array1)
                {
                    Console.WriteLine(element);
                }
            }
        }

        public void queArrayDeque(int ele)
        {
            if(index != -1)
            {
                if(popIndex <= index)
                {
                    Console.WriteLine(array1[popIndex]);
                    popIndex++;
                }
            }
        }

    }
}
