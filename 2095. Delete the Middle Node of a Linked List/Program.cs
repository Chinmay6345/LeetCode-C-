using System;

namespace _2095._Delete_the_Middle_Node_of_a_Linked_List
{
    //https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/
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
        public ListNode DeleteMiddle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode p = head;
            ListNode q = head;
            while ((p != null && q != null) && (q.next != null))
            {
                p = p.next;
                q = q.next.next;
            }
            p = p.next.next;
            return head;
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
