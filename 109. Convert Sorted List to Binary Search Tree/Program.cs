using System;
using System.Collections.Generic;
using System.Linq;

namespace _109._Convert_Sorted_List_to_Binary_Search_Tree
{
    //https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }



    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
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
        public TreeNode Tree(List<int> nums, int low, int high)
        {
            if (low > high)
                return null;
            int mid = low + (high - low) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = Tree(nums, low, mid - 1);
            node.right = Tree(nums, mid + 1, high);
            return node;
        }
        public TreeNode SortedListToBST(ListNode head)
        {
            List<int> nums = new List<int>();
            ListNode curr = head;
            while (curr != null)
            {
                nums.Add(curr.val);
                curr = curr.next;
            }
            return Tree(nums, 0, nums.Count() - 1);
        }
    }
}
