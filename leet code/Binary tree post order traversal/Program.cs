using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/binary-tree-postorder-traversal/
namespace Binary_tree_post_order_traversal
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
        public static List<Int32> BinaryTreeIterPostOrder(TreeNode root)
        {
            TreeNode p = root;
            List<Int32> lst = new List<Int32>();
            Stack<TreeNode> stck = new Stack<TreeNode>();
            while (true)
            {
                if (p != null)
                {
                    stck.Push(p);
                    p = p.left;
                }
                else
                {
                    if (stck.Count == 0)
                        break;
                    else
                    {
                        if (stck.Peek().right == null)
                        {
                            p = stck.Pop();
                            lst.Add(p.val);
                            if (stck.Count != 0)
                            {
                                while (p == stck.Peek().right)
                                {
                                    lst.Add(stck.Peek().val);
                                    p = stck.Pop();
                                    if (stck.Count == 0)
                                        break;
                                }
                            }

                        }
                        if (stck.Count != 0)
                            p = stck.Peek().right;
                        else
                            p = null;
                    }
                }
            }
            return lst;
        }
        public static IList<int> Ap2PostorderTraversal(TreeNode root)
        {
            List<Int32> result = new List<Int32>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode p = root;
            while (stack.Any() || p != null)
            {
                if (p != null)
                {
                    stack.Push(p);
                    result.Insert(0, p.val);  // Reverse the process of preorder
                    p = p.right;             // Reverse the process of preorder
                }
                else
                {
                    TreeNode node = stack.Pop();
                    p = node.left;           // Reverse the process of preorder
                }
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
