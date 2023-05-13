using System;
using System.Collections.Generic;
using System.Linq;

namespace _897._Increasing_Order_Search_Tree
{
    //https://leetcode.com/problems/increasing-order-search-tree/
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

    public static class AppHelper
    {
        public static TreeNode IncreasingBST(TreeNode root)
        {

            if (root == null)
            {
                return null;
            }
            TreeNode curr = root;
            TreeNode newroot = null;
            TreeNode newcurr=null;
                   
            int count = 1;
            Stack<TreeNode> stck = new Stack<TreeNode>();
            while (curr != null || stck.Any())
            {
                while (curr != null)
                {

                    stck.Push(curr);
                    curr = curr.left;
                }
                curr = stck.Pop();
                Console.Write(curr.val + " ");
                if (newroot == null)
                {
                    newroot = new TreeNode(curr.val);
                    newcurr = newroot;
                }
                else
                {
                    newcurr.right = new TreeNode(curr.val);
                    newcurr = newcurr.right;
                }
                count++;
                curr = curr.right;
            }
            return newroot ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.right = new TreeNode(6);
            root.right.right = new TreeNode(8);
            root.right.right.left = new TreeNode(7);
            root.right.right.right = new TreeNode(9);
            root.left.right = new TreeNode(4);
            root.left.left = new TreeNode(2);
            root.left.left.left = new TreeNode(1);

            TreeNode result = AppHelper.IncreasingBST(root);
            Console.ReadLine();
        }
    }
}
