using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/binary-tree-inorder-traversal/
namespace Binary_Tree_Inorder_Traversal
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
                    stack.Push(p);
                    p = p.left;
                }
                else
                {
                    p = stack.Pop();
                    lst.Add(p.val);
                    p = p.right;
                }
            }
            return lst;
        }
    }
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
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
