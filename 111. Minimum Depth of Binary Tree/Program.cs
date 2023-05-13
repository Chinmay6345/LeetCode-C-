using System;
using System.Collections.Generic;
using System.Linq;

namespace _111._Minimum_Depth_of_Binary_Tree
{
    //https://leetcode.com/problems/minimum-depth-of-binary-tree/
    class QueueItem
    {
        public TreeNode node;
        public int depth;
        public QueueItem(TreeNode node, int depth)
        {
            this.node = node;
            this.depth = depth;
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
    public static class AppHelper
    {
        public static int HeightBTree(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            if (root.left == null)
                return 1 + HeightBTree(root.right);
            if (root.right == null)
                return 1 + HeightBTree(root.left);
            return 1 + Math.Min(HeightBTree(root.left), HeightBTree(root.right));
        }

        public static int HeightBTree1(TreeNode root)
        {
            Int32 depth = 1;
            TreeNode p = root;
            if (root == null)
            {
                return 0;
            }
            else
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(p);
                //depth=1;
                while (queue.Any())
                {
                    int l = queue.Count;
                    for (int i = 0; i < l; i++)
                    {
                        TreeNode n = queue.Dequeue();
                        if (n.left == null && n.right == null)
                        {
                            return depth;
                        }
                        if (n.left != null)
                        {
                            queue.Enqueue(n.left);
                        }
                        if (n.right != null)
                        {
                            queue.Enqueue(n.right);
                        }
                    }
                    depth++;
                }
            }
            return 0;
        }
    }

    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            return AppHelper.HeightBTree(root);
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
