using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/odd-even-linked-list/
/*
Given a singly linked list, group all odd nodes together followed by the even nodes. Please note here we are talking about the node number and not the value in the nodes.

You should try to do it in place. The program should run in O(1) space complexity and O(nodes) time complexity.

Example 1:

Input: 1->2->3->4->5->NULL
Output: 1->3->5->2->4->NULL
Example 2:

Input: 2->1->3->5->6->4->7->NULL
Output: 2->3->6->7->1->5->4->NULL
 
*/
namespace Odd_EvenLinked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public static class AppHelper
    {
        public static List<Int32> SeparateOddEven(List<Int32> lst)
        {
            List<int> lst_even = new List<int>();
            List<int> lst_odd = new List<int>();
            int count = 1;
            for (Int32 i = 0; i < lst.Count(); i++)
            {
                if (count % 2 == 0)
                {
                    lst_even.Add(lst[i]);
                }
                else
                {
                    lst_odd.Add(lst[i]);
                }
                count = count + 1;
            }
            lst = lst_odd.Concat(lst_even).ToList();
            return lst;
        }
        public static ListNode OEList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            else if (head.next == null)
            {
                return head;
            }
            ListNode p = head;
            ListNode q = head;
            List<Int32> lst = new List<Int32>();
            while (p != null)
            {
                lst.Add(p.val);
                p = p.next;
            }
            lst = SeparateOddEven(lst);
            for (Int32 i = 0; i < lst.Count(); i++)
            {
                q.val = lst[i];
                q = q.next;
            }
            return head;
        }
    }
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            return AppHelper.OEList(head);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
