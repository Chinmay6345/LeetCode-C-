using System;
using System.Linq;
using System.Collections.Generic;

namespace _114._Flatten_Binary_Tree_to_Linked_List
{
    //https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0)
        {
            this.val = val;
            left = null;
            right = null;
        }
    }

    public class Solution
    {
        public TreeNode prev = null;

        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;
            Flatten(root.right);
            Flatten(root.left);
            root.right = prev;
            root.left = null;
            prev = root;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>{ 256741038, 623958417, 467905213, 714532089 ,938071625 };
            if (arr.Count == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }
            long max = arr.Max();
            long min = arr.Min();
            long minsum = unchecked((long)(arr.Sum() - max));
            long maxsum = unchecked(arr.Sum() - min);
            Console.WriteLine(minsum + " " + maxsum);

            Console.ReadLine();
        }
    }
}
