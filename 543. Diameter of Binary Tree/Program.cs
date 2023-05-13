using System;

namespace _543._Diameter_of_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //https://leetcode.com/problems/diameter-of-binary-tree/
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

        public int diameter = 0;

        public int height(TreeNode root)
        {
            if (root == null)
                return 0;
            int leftheight = height(root.left);
            int rightheight = height(root.right);
            diameter = Math.Max(diameter, leftheight + rightheight);
            return 1 + Math.Max(leftheight, rightheight);
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            int k = height(root);
            return diameter;
        }
    }
}
