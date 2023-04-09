using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
namespace Lowest_Common_Ancestor_of_a_Binary_Search_Tree_235
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
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root.val == p.val || root.val == q.val)
                return root;
            TreeNode lca1 = LowestCommonAncestor(root.left, p, q);
            TreeNode lca2 = LowestCommonAncestor(root.right, p, q);
            if (lca1 != null && lca2 != null)
                return root;
            if (lca1 != null)
                return lca1;
            if (lca2 != null)
                return lca2;
            return null;
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
