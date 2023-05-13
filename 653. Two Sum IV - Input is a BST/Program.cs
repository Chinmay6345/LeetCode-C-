using System;
using System.Collections.Generic;

namespace _653._Two_Sum_IV___Input_is_a_BST
{
    internal class Program
    {
        //https://leetcode.com/problems/two-sum-iv-input-is-a-bst/

        /*
         Given the root of a Binary Search Tree and a target number k, return true if there exist two elements in the BST such that their sum is equal to the given target.

 

Example 1:


Input: root = [5,3,6,2,4,null,7], k = 9
Output: true
Example 2:


         
         */
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Solution
        {
            public bool IsPair(TreeNode root, HashSet<int> hset, int sum)
            {
                if (root == null)
                {
                    return false;
                }
                if (IsPair(root.left, hset, sum))
                {
                    return true;
                }
                if (hset.Contains(sum - root.val))
                    return true;
                else
                    hset.Add(root.val);
                return IsPair(root.right, hset, sum);
            }


            public bool FindTarget(TreeNode root, int k)
            {
                HashSet<int> hset = new HashSet<int>();
                return IsPair(root, hset, k);
            }
        }
    }
}
