using System;
//https://leetcode.com/problems/remove-nth-node-from-end-of-list/

/*
 Given a linked list, remove the n-th node from the end of list and return its head.

Example:

Given linked list: 1->2->3->4->5, and n = 2.

After removing the second node from the end, the linked list becomes 1->2->3->5.
Note:

Given n will always be valid.
*/
namespace Remove_Nth_Node_From_End_of_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public static class AppHelper
    {
        public static ListNode RemoveNth(ListNode head, Int32 n)
        {
            ListNode p = head;
            ListNode q = head;
            ListNode prev = null;
            Int32 count = 0;
            if (head == null || head.next == null)
            {
                return null;
            }
            while (p != null)
            {
                count = count + 1;
                p = p.next;
            }
            if (count == n)
            {
                return head.next;
            }
            else
            {
                Int32 difference = count - n;
                for (Int32 i = 0; i < difference; i++)
                {
                    prev = q;
                    q = q.next;
                }
                prev.next = q.next;
                return head;
            }
        }
    }

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            return AppHelper.RemoveNth(head, n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
