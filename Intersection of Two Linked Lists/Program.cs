using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/intersection-of-two-linked-lists/
namespace Intersection_of_Two_Linked_Lists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public static class AppHelper
    {
        public static ListNode IntersectionNode(ListNode p, ListNode q)
        {
            if (p == null || q == null)
            {
                return null;
            }
            Stack<ListNode> stck1 = new Stack<ListNode>();
            Stack<ListNode> stck2 = new Stack<ListNode>();
            ListNode commonNode = null;
            while (p != null)
            {
                stck1.Push(p);
                p = p.next;
            }
            while (q != null)
            {
                stck2.Push(q);
                q = q.next;
            }
            while (stck1.Count != 0 && stck2.Count != 0)
            {
                if (stck1.Peek().Equals(stck2.Peek()))
                {
                    commonNode = stck1.Peek();
                    stck1.Pop();
                    stck2.Pop();
                }
                else
                {
                    break;
                }
            }
            return commonNode != null ? commonNode : null;
        }
        //using HashSet
        public static ListNode IntersectionNodeUsingHSet(ListNode p, ListNode q)
        {
            if (p == null || q == null)
                return null;
            HashSet<ListNode> HSet = new HashSet<ListNode>();
            while (p != null)
            {
                HSet.Add(p);
                p = p.next;
            }
            while (q != null)
            {
                if (HSet.Contains(q))
                {
                    return q;
                }
                q = q.next;
            }
            return null;
        }
    }

    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            return AppHelper.IntersectionNode(headA, headB);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
