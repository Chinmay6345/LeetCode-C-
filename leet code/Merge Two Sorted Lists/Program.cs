using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    public class AppHelper
    {
        public ListNode Merge(ListNode p, ListNode q)
        {
            ListNode newHead = null;
            ListNode sorting = null;
            if (p == null)
            {
                return q;
            }
            if (q == null)
            {
                return p;
            }
            if (p != null && q != null)
            {
                if (p.val < q.val)
                {
                    sorting = p;
                    p = sorting.next;
                }
                else
                {
                    sorting = q;
                    q = sorting.next;
                }
            }
            newHead = sorting;
            while (p != null && q != null)
            {
                if (p.val < q.val)
                {
                    sorting.next = p;
                    sorting = p;
                    p = sorting.next;
                }
                else
                {
                    sorting.next = q;
                    sorting = q;
                    q = sorting.next;
                }
            }
            if (p == null)
            {
                sorting.next = q;
            }
            if (q == null)
            {
                sorting.next = p;
            }
            return newHead;
        }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            AppHelper helper = new AppHelper();
            return helper.Merge(l1, l2);
        }
    }
}
