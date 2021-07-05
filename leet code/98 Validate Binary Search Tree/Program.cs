using System;
using System.Collections.Generic;

namespace _98_Validate_Binary_Search_Tree
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
        public static void isBST(TreeNode root, ref List<int> lst)
        {
            if (root != null)
            {
                isBST(root.left, ref lst);
                lst.Add(root.val);
                isBST(root.right, ref lst);
            }
        }
    }

    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            List<int> lst = new List<int>();
            if (root == null) return true;
            AppHelper.isBST(root, ref lst);
            if (lst.Count == 1) return true;
            for (int i = 1; i < lst.Count; i++)
            {
                if (lst[i] <= lst[i - 1])
                    return false;
            }
            return true;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
