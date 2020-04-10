using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/remove-duplicates-from-sorted-list/
/*
 Given a sorted linked list, delete all duplicates such that each element appear only once.

Example 1:

Input: 1->1->2
Output: 1->2
Example 2:

Input: 1->1->2->3->3
Output: 1->2->3
*/
namespace Remove_Duplicates_from_Sorted_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class AppHelper
    {
        public ListNode Duplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode p = head;
            ListNode q = head.next;
            while (q != null)
            {
                if (p.val != q.val)
                {
                    p = q;
                    q = q.next;
                }
                else
                {
                    p.next = q.next;
                    q = null;
                    q = p.next;
                }
            }
            return head;
        }
        public ListNode RemoveDuplicates(ListNode head)
        {
            ListNode p = head;
            ListNode q = null;
            while (p != null && p.next != null)
            {
                if (p.val == p.next.val)
                {
                    q = p.next.next;
                    p.next = q;
                }
                else
                {
                    p = p.next;
                }
            }
            return head;
        }
    }
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            AppHelper helper = new AppHelper();
            return helper.Duplicates(head);
        }
    }
}
