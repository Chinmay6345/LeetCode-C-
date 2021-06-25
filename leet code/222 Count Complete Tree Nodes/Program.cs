using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _222_Count_Complete_Tree_Nodes
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
        public int countNode(TreeNode root)
        {
            int lh = 0, rh = 0;
            TreeNode curr = root;
            while (curr != null)
            {
                lh++;
                curr = curr.left;
            }
            curr = root;
            while (curr != null)
            {
                rh++;
                curr = curr.right;
            }
            if (lh == rh)
            {
                return (int)Math.Pow(2, lh) - 1;
            }
            else
            {
                return 1 + countNode(root.left) + countNode(root.right);
            }
        }

        public int CountNodes(TreeNode root)
        {
            return countNode(root);
        }

        public int RCountNodes(TreeNode root)
        {
            if (root == null)
                return 0;
            else
                return 1 + RCountNodes(root.left) + RCountNodes(root.right);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
