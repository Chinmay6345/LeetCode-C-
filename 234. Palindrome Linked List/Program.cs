using System;
//https://leetcode.com/problems/palindrome-linked-list/
namespace _234._Palindrome_Linked_List
{
  
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
    public static class AppHelper
    {
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return true;
            }
            ListNode middle = MiddleNode(head);
            ListNode reverse = ReverseLinkedList(middle);
            ListNode p = head;
            while (reverse != null && p != null)
            {
                if (reverse.val != p.val)
                {
                    return false;
                }
                reverse = reverse.next;
                p = p.next;
            }

            return true;
        }

        public static ListNode MiddleNode(ListNode head)
        {
            ListNode p = head;
            ListNode q = head;
            while ((p != null && q != null) && (q.next != null))
            {
                p = p.next;
                q = q.next.next;
            }
            return p;
        }

        public static ListNode ReverseLinkedList(ListNode head)
        {
            ListNode p = head;
            ListNode q = null;
            ListNode r = null;
            try
            {

                while (p != null)
                {
                    r = q;
                    q = p;
                    p = p.next;
                    q.next = r;
                }
                head = q;
            }
            catch (Exception e)
            {
                Console.WriteLine("error  from here " + e.Message);
            }
            return q;
        }
    }

    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            return AppHelper.IsPalindrome(head);
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
