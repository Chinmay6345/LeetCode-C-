using System;
using System.Collections.Generic;
using System.Linq;

namespace _113._Path_Sum_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //https://leetcode.com/problems/path-sum-ii/
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


        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {



            var res = new List<IList<int>>();
            var path = new List<int>();
            int cSum = 0;
            helper(root, targetSum, cSum, path, res);
            return res;

        }

        public void helper(TreeNode root, int tSum, int cSum, List<int> path, List<IList<int>> res)
        {
            if (root == null) return;
            //      add to path the root value
            path.Add(root.val);
            //      add root.val to currSum and see if currSum == tSum
            //      if equal and is leaf then copy path and add it to res
            //      else go left and right
            cSum += root.val;
            if (cSum == tSum && root.left == null && root.right == null)
            {
                var x = new List<int>();
                foreach (int i in path) x.Add(i);
                res.Add(x);
            }
            else
            {
                helper(root.left, tSum, cSum, path, res);
                helper(root.right, tSum, cSum, path, res);
            }
            path.RemoveAt(path.Count() - 1);
        }
    }
}
