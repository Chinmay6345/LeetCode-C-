using System;

namespace G_Floor_in_BST
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int val = 0, Node left = null, Node right = null)
        {
            data = val;
            this.left = left;
            this.right = right;
        }

        public Node floor(Node root,int key)
        {
            Node res = null;
            while(root !=null)
            {
                if (root.data == key)
                {
                    return root;
                }
                else if(root.data > key)
                {
                    root = root.left;
                }
                else
                {
                    res = root;
                    root = root.right;
                }
            }
            return res;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
