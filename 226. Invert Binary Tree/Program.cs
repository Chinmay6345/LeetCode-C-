using System;

namespace _226._Invert_Binary_Tree
{
    //https://leetcode.com/problems/invert-binary-tree/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            var left = root.left;
            root.left = root.right;
            root.right = left;
            root.left = InvertTree(root.left);
            root.right = InvertTree(root.right);
            return root;
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
