using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
namespace _653.Two_Sum_IV___Input_is_a_BST
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

        public bool isPairSum(TreeNode root, int sum, HashSet<int> s)
        {
            if (root == null) return false;

            if (isPairSum(root.left, sum, s) == true)
                return true;

            if (s.Contains(sum - root.val))
                return true;
            else
                s.Add(root.val);
            return isPairSum(root.right, sum, s);
        }

        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> s = new HashSet<int>();
            return isPairSum(root, k, s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
