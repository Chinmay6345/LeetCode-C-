using System;
using System.Collections.Generic;
using System.Linq;

namespace _117._Populating_Next_Right_Pointers_in_Each_Node_II
{
    //https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }


    public class Solution
    {

        public Node Connect(Node root)
        {
            if (root == null)
                return root;

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Any())
            {
                int size = q.Count();
                if (size == 0)
                    return root;

                while (size > 0)
                {
                    Node temp;

                    if (size > 1)
                    {
                        temp = q.Peek();
                        q.Dequeue();

                        Node nextAdd = q.Peek();
                        temp.next = nextAdd;

                    }
                    else
                    {
                        temp = q.Peek();
                        q.Dequeue();
                    }

                    if (temp.left != null)
                        q.Enqueue(temp.left);
                    if (temp.right != null)
                        q.Enqueue(temp.right);

                    size--;

                }
            }

            return root;
        }
    }

}
