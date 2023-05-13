using System;

namespace _124._Binary_Tree_Maximum_Path_Sum
{
    //https://leetcode.com/problems/binary-tree-maximum-path-sum/
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

    public static class Solution
    {

        public static int maxValue;
        public static int maxPathDown(TreeNode node)
        {
            if (node == null) return 0;
            int left = Math.Max(0, maxPathDown(node.left));
            int right = Math.Max(0, maxPathDown(node.right));
            maxValue = Math.Max(maxValue, left + right + node.val);
            return Math.Max(left, right) + node.val;
        }

        public static int MaxPathSum(TreeNode root)
        {
            maxValue = Int32.MinValue;
            int k = maxPathDown(root);
            return maxValue;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            Console.WriteLine(Solution.MaxPathSum(root));
            Console.ReadLine();
        }
    }
}
