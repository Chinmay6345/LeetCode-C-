using System;

namespace _110._Balanced_Binary_Tree
{
    //https://leetcode.com/problems/balanced-binary-tree/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //https://leetcode.com/problems/balanced-binary-tree/
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
    public class Solution
    {

        public int TreeIsBalanced(TreeNode root)
        {
            if (root == null)
                return 0;
            int left_height = TreeIsBalanced(root.left);
            if (left_height == -1)
                return -1;
            int right_height = TreeIsBalanced(root.right);
            if (right_height == -1)
                return -1;
            if (Math.Abs(left_height - right_height) > 1)
                return -1;
            return Math.Max(left_height, right_height) + 1;
        }

        public bool IsBalanced(TreeNode root)
        {
            int k = TreeIsBalanced(root);
            if (k == -1) return false;
            return true;
        }
    }
}
