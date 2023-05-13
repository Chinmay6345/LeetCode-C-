using System;

namespace _142._Linked_List_Cycle_II
{
    //https://leetcode.com/problems/linked-list-cycle-ii/

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
        public ListNode Start(ListNode head)
        {
            ListNode meet = FindLoop(head);
            if (meet == null)
            {
                return null;
            }
            ListNode temp = head;
            while (temp != meet)
            {
                temp = temp.next;
                meet = meet.next;
            }
            return temp;
        }

        public ListNode FindLoop(ListNode head)
        {
            ListNode p = head;
            ListNode q = head;
            while ((p != null && q != null) && (q.next != null))
            {
                p = p.next;
                q = q.next.next;
                if (p == q)
                {
                    return p;
                }
            }
            return null;
        }

        public ListNode DetectCycle(ListNode head)
        {
            return Start(head);
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
