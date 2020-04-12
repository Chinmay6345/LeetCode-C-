using System;

//https://leetcode.com/problems/sort-list/
/*
Sort a linked list in O(n log n) time using constant space complexity.

Example 1:

Input: 4->2->1->3
Output: 1->2->3->4
Example 2:

Input: -1->5->3->4->0
Output: -1->0->3->4->5 
*/

namespace Sort_a_Linked_List
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class AppHelper
    {
        public ListNode SortedList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode i = head;
            ListNode j = null;
            for (i = head; i.next != null; i = i.next)
            {
                for (j = i.next; j != null; j = j.next)
                {
                    if (i.val > j.val)
                    {
                        Int32 temp = i.val;
                        i.val = j.val;
                        j.val = temp;
                    }
                }
            }
            return head;
        }
    }

    public class Solution
    {
        public ListNode SortList(ListNode head)
        {
            AppHelper helper = new AppHelper();
            return helper.SortedList(head);
        }
    }
}
