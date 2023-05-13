using System;

namespace _445._Add_Two_Numbers_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //https://leetcode.com/problems/add-two-numbers-ii/
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
    public class Solution
    {

        public ListNode Reverse(ListNode head)
        {
            ListNode r = null;
            ListNode q = null;
            ListNode p = head;
            while (p != null)
            {
                r = q;
                q = p;
                p = p.next;
                q.next = r;
            }
            head = q;
            return q;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode p = Reverse(l1);
            ListNode q = Reverse(l2);
            ListNode dummy = new ListNode(-1);
            ListNode currentNode = dummy;
            while (p != null || q != null || carry != 0)
            {
                int val1 = p != null ? p.val : 0;
                int val2 = q != null ? q.val : 0;
                int SumOfValues = val1 + val2 + carry;
                int newValue = SumOfValues % 10;

                ListNode newNode = new ListNode(newValue);
                currentNode.next = newNode;
                currentNode = newNode;

                carry = SumOfValues / 10;
                p = (p != null) ? p.next : null;
                q = (q != null) ? q.next : null;
            }
            return Reverse(dummy.next);
        }
    }
}
