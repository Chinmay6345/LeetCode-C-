using System;

namespace Largest_BST_in_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
    public class NodeValue
    {
        public int maxNode, minNode, maxSize;

        public NodeValue(int minNode, int maxNode, int maxSize)
        {
            this.maxNode = maxNode;
            this.minNode = minNode;
            this.maxSize = maxSize;
        }
    };
    class Solution
    {
        private NodeValue largestBSTSubtreeHelper(TreeNode root)
        {
            // An empty tree is a BST of size 0.
            if (root == null)
            {
                return new NodeValue(Int32.MaxValue, Int32.MinValue, 0);
            }

            // Get values from left and right subtree of current tree.
            NodeValue left = largestBSTSubtreeHelper(root.left);
            NodeValue right = largestBSTSubtreeHelper(root.right);

            // Current node is greater than max in left AND smaller than min in right, it is a BST.
            if (left.maxNode < root.val && root.val < right.minNode)
            {
                // It is a BST.
                return new NodeValue(Math.Min(root.val, left.minNode), Math.Max(root.val, right.maxNode),
                                    left.maxSize + right.maxSize + 1);
            }

            // Otherwise, return [-inf, inf] so that parent can't be valid BST
            return new NodeValue(Int32.MinValue, Int32.MaxValue,
                                Math.Max(left.maxSize, right.maxSize));
        }

        public int largestBSTSubtree(TreeNode root)
        {
            return largestBSTSubtreeHelper(root).maxSize;
        }
    }
}
