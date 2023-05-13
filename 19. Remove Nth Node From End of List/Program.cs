using System;

namespace _19._Remove_Nth_Node_From_End_of_List
{

    //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return null;
            ListNode p = head;
            int length = 0;
            while (p != null)
            {
                p = p.next;
                length++;
            }
            if (n > length)
                return null;
            if (n == length)
            {
                return head.next;
            }
            int k = length - n + 1;
            p = head;
            ListNode q = null;
            for (int i = 1; i < k; i++)
            {
                q = p;
                p = p.next;
            }
            q.next = p.next;
            return head;
        }

        public ListNode RemoveFromLast(ListNode head,int n)
        {
            ListNode first = head;
            ListNode second = head;
            for(int i= 0; i < n; i++)
            {
                first= first.next;
            }
            while(first!=null)
            {
                first = first.next;
                second = second.next;
            }
            return second;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
