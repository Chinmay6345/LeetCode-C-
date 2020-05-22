using System;
using System.Collections.Generic;
//https://leetcode.com/problems/binary-tree-preorder-traversal/
namespace Binary_Tree_Preorder_Traversal
{
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
        public static List<Int32> PreorderTraversal(TreeNode root)
        {
            TreeNode p = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<Int32> lst = new List<Int32>();
            while (p != null || stack.Count != 0)
            {
                if (p != null)
                {
                    lst.Add(p.val);
                    stack.Push(p);
                    p = p.left;
                }
                else
                {
                    p = stack.Pop();
                    p = p.right;
                }
            }
            return lst;
        }
    }
    public class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            return AppHelper.PreorderTraversal(root);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
