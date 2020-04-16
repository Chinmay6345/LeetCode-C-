using System;
//https://leetcode.com/problems/remove-linked-list-elements/
/*
 Remove all elements from a linked list of integers that have value val.

Example:

Input:  1->2->6->3->4->5->6, val = 6
Output: 1->2->3->4->5
 */
namespace Remove_Linked_List_elements
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class AppHelper
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode Remove(ListNode head, Int32 val)
        {
            ListNode p = head;
            ListNode q = null;
            if (head == null)
            {
                return head;
            }
            while (p != null && p.val == val)
            {
                head = p.next;
                p = head;
            }
            while (p != null)
            {
                while (p != null && p.val != val)
                {
                    q = p;
                    p = p.next;
                }
                if (p == null)
                {
                    return head;
                }
                q.next = p.next;
                p = q.next;
            }
            return head;
        }
    }
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            AppHelper helper = new AppHelper();
            return helper.Remove(head, val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
