using System;

namespace _236._Lowest_Common_Ancestor_of_a_Binary_Tree
{
    //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
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

    public class Solution
    {


        public TreeNode LCA(TreeNode root, int p, int q)
        {
            if (root == null)
                return null;
            if (root.val == p || root.val == q)
                return root;
            TreeNode lca1 = LCA(root.left, p, q);
            TreeNode lca2 = LCA(root.right, p, q);
            if (lca1 != null && lca2 != null)
                return root;
            if (lca1 != null)
                return lca1;
            else
                return lca2;


        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            return LCA(root, p.val, q.val);
        }
    }
}
