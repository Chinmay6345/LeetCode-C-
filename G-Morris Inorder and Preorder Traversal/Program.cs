using System;

namespace G_Morris_Inorder_and_Preorder_Traversal
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
    }
    public static class AppHelper
    {
        public static void Inorder(Node root)
        {
            Node curr = root;
            if (curr.left == null)
            {
                Console.WriteLine(curr.data);
                curr = curr.right;
            }
            else
            {
                Node predeccesor = curr.left;
                while (predeccesor.right != null && predeccesor.right != curr)
                {
                    predeccesor = predeccesor.right;
                }
                if (predeccesor.right == null)
                {
                    predeccesor.right = curr;
                    curr = curr.left;
                }
                else
                {
                    predeccesor.right = null;
                    Console.WriteLine(predeccesor.data);
                    curr = curr.right;

                }
            }
        }

        public static void Preorder(Node root)
        {
            Node curr = root;
            if (curr.left == null)
            {
                Console.WriteLine(curr.data);
                curr = curr.right;
            }
            else
            {
                Node predeccesor = curr.left;
                while (predeccesor.right != null && predeccesor.right != curr)
                {
                    predeccesor = predeccesor.right;
                }
                if (predeccesor.right == null)
                {
                    predeccesor.right = curr;
                    Console.WriteLine(predeccesor.data);
                    curr = curr.left;
                }
                else
                {
                    predeccesor.right = null;
                   
                    curr = curr.right;

                }
            }
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
