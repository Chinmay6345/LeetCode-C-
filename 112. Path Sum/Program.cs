using System;

namespace _112._Path_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //https://leetcode.com/problems/path-sum/
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

    public static class AppHelper
    {
        public static Boolean HasSum(TreeNode root, int s, int sum)
        {
            if (root != null)
            {
                s += root.val;
                if (root.left == null && root.right == null)
                {
                    if (s == sum) return true;
                    else return false;
                }

                return HasSum(root.left, s, sum) || HasSum(root.right, s, sum);
            }
            return false;
        }
    }
    public class Solution
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            return AppHelper.HasSum(root, 0, sum);
        }
    }
}
