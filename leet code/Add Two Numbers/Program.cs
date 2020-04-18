using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/add-two-numbers/
/*
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807. 
*/
namespace Add_Two_Numbers
{
    public static class AppHelper
    {
        public static ListNode ResultList(ListNode x, ListNode y)
        {
            if (x == null)
            {
                return y;
            }
            else if (y == null)
            {
                return x;
            }
            else if (x == null && y == null)
            {
                return null;
            }
            ListNode p = x;
            ListNode q = y;
            Int32 sum = 0; Int32 carry = 0; Int32 num1 = 0; Int32 num2 = 0;
            ListNode dHead = new ListNode(0);
            ListNode curr = null;
            curr = dHead;
            while (p != null || q != null)
            {
                num1 = (p != null) ? p.val : 0;
                num2 = (q != null) ? q.val : 0;
                sum = carry + num1 + num2;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;

            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dHead.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AppHelper.ResultList(l1, l2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
