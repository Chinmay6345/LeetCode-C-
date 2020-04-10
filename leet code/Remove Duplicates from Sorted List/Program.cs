using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class AppHelper
    {
        public ListNode Duplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode p = head;
            ListNode q = head.next;
            while (q != null)
            {
                if (p.val != q.val)
                {
                    p = q;
                    q = q.next;
                }
                else
                {
                    p.next = q.next;
                    q = null;
                    q = p.next;
                }
            }
            return head;
        }
    }
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            AppHelper helper = new AppHelper();
            return helper.Duplicates(head);
        }
    }
}
