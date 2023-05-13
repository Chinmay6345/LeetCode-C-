using System;
using System.Collections.Generic;
using System.Linq;

namespace _662._Maximum_Width_of_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Pair
    {
        public TreeNode node;
        public int index;

        public Pair(int id, TreeNode n)
        {
            index = id;
            node = n;
        }
    }


    public class Solution
    {
        public int maxWidth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<Pair> q = new Queue<Pair>();
            q.Enqueue(new Pair(0, root));
            int width = 0;
            //while (q.Any())
            //{
            //    int min = Int32.MinValue;
            //    int max = Int32.MaxValue;
            //    int count = q.Count();
            //    for (int i = 0; i < q.Count(); i++)
            //    {
            //        var pair = q.Dequeue();
            //        int indx = pair.x;
            //        min = Math.Min(indx, min);
            //        max = Math.Max(indx, max);
            //        TreeNode curr = q.node;
            //        if (curr.left != null)
            //        {
            //            q.Enqueue(new Pair(indx * 2 + 1, curr.left));
            //        }
            //        if (curr.right != null)
            //        {
            //            q.Enqueue(new Pair((indx * 2 + 2), curr.right));
            //        }
            //    }
            //    width = Math.Max(width, max - min + 1);
            //}
            return width;
        }

        public int WidthOfBinaryTree(TreeNode root)
        {
            return maxWidth(root);
        }
    }
}
