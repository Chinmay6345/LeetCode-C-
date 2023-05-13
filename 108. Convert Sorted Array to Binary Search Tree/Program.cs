using System;

namespace _108._Convert_Sorted_Array_to_Binary_Search_Tree
{
    //https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            data = val;
            this.left = left;
            this.right = right;
        }

    }

    public class Solution
    {
        public TreeNode Tree(int[] nums, int low, int high)
        {
            if (low > high)
                return null;
            int mid = low + (high - low) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = Tree(nums, low, mid - 1);
            node.right = Tree(nums, mid + 1, high);
            return node;
        }
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return Tree(nums, 0, nums.Length - 1);
        }
    }
}
