using System;
using System.Collections.Generic;
using System.Linq;

namespace _173._Binary_Search_Tree_Iterator
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
    //https://leetcode.com/problems/binary-search-tree-iterator/
    public class BSTIterator
    {

        public Stack<TreeNode> stck;

        public BSTIterator(TreeNode root)
        {
            stck = new Stack<TreeNode>();
            pushAll(root);
        }

        public int Next()
        {
            var node = stck.Pop();

            pushAll(node.right);

            return node.val;
        }

        public bool HasNext()
        {

            return stck.Count() > 0;
        }

        private void pushAll(TreeNode root)
        {
            while (root != null)
            {
                stck.Push(root);
                root = root.left;
            }
        }
    }
}
