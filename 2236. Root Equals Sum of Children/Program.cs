using System;
namespace _2236._Root_Equals_Sum_of_Children
{
    //https://leetcode.com/problems/root-equals-sum-of-children/
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


        public bool CheckTree(TreeNode root)
        {
            return root.val == root.left.val + root.right.val;
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
