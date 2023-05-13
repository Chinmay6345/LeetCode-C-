using System;

namespace _222._Count_Complete_Tree_Nodes
{
    //https://leetcode.com/problems/count-complete-tree-nodes/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int CountNodes(TreeNode root)
        {
            int left_height = 0;
            int right_height = 0;
            TreeNode curr = root;
            while (curr != null)
            {
                left_height = left_height + 1;
                curr = curr.left;
            }
            curr = root;
            while (curr != null)
            {
                right_height = right_height + 1;
                curr = curr.right;
            }
            if (right_height == left_height)
            {
                return (int)Math.Pow(2, left_height) - 1;
            }
            else
            {
                return 1 + CountNodes(root.left) + CountNodes(root.right);
            }
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
}
