using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    class OrderTraversal
    {
        public class Node
        {
            public int value;
            public Node left;
            public Node right;
            public Node(int value1)
            {
                value = value1;
            }
        }
        public class Tree
        {
            public Node root;
            public void add()
            {
                root = null;
            }
            public void add(int value)
            {
                if (root == null)
                {
                    root = new Node(value);
                    return;
                }
                add(root, value);
            }
            public Node add(Node root, int value)
            {
                if (root == null)
                {
                    root = new Node(value);
                 }
                else if(root.value > value)
                {
                    root.left = add(root.left, value);
                }
                else
                    root.right = add(root.right, value);

               // Console.WriteLine(root.value);
                return root;
            }

        }

        //InOrderPrint
        public static void InOrderPrint(Node node)
        {
            if(node.left != null)
            {
                InOrderPrint(node.left);
            }
            Console.WriteLine(node.value);
            if(node.right != null)
            {
                InOrderPrint(node.right);
            }
        }
    }
}
