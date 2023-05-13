using System;

namespace Predeccsor_and_Successor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class Node
        {
            public int key;
            public int data;
            public Node left, right;

            Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

        class GfG
        {
            public static void findPreSuc(Node root, Node p, Node s, int key)
            {
                Node node = root;
                Node succ = null;
                while (node != null)
                {
                    if (node.data <= key)
                    {
                        node = node.right;
                    }
                    else
                    {
                        succ = node;
                        node = node.left;
                    }
                }
                node = root;
                while (node != null)
                {
                    if (node.data >= key)
                    {
                        node = node.left;
                    }
                    else
                    {
                        succ = node;
                        node = node.right;
                    }
                }
            }
        }
    }
}
