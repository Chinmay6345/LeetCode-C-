using System;
using System.Collections.Generic;
using System.Linq;

namespace _129._Sum_Root_to_Leaf_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //https://leetcode.com/problems/sum-root-to-leaf-numbers/
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

        public void Inorder(TreeNode root, ref List<int> lst)
        {
            if (root == null) return;
            if (root.left == null && root.right == null)
            {
                lst.Add(root.val);
            }
            Inorder(root.left, ref lst);
            Inorder(root.right, ref lst);
        }

        public bool CompareLeafTraversal(TreeNode tree1, TreeNode tree2)
        {
            List<int> lst1 = new List<int>();
            List<int> lst2 = new List<int>();
            Inorder(tree1, ref lst1);
            Inorder(tree2, ref lst2);
            return lst1.SequenceEqual(lst2);
        }
        public int sumNodes(TreeNode root, int currentSum)
        {
            if (root == null) return 0;
            currentSum = currentSum * 10 + root.val;
            Console.WriteLine(currentSum * 10 + " root val " + root.val);
            if (root.left == null && root.right == null) return currentSum;
            int leftSum = sumNodes(root.left, currentSum);
            int rightSum = sumNodes(root.right, currentSum);
            return leftSum + rightSum;
        }

        public int SumNumbers(TreeNode root)
        {
            return sumNodes(root, 0);
        }
    }
}
