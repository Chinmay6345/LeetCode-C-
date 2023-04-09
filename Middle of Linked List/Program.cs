using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/middle-of-the-linked-list/
/*
Given a non-empty, singly linked list with head node head, return a middle node of linked list.

If there are two middle nodes, return the second middle node.

 

Example 1:

Input: [1,2,3,4,5]
Output: Node 3 from this list (Serialization: [3,4,5])
The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
Note that we returned a ListNode object ans, such that:
ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.
Example 2:

Input: [1,2,3,4,5,6]
Output: Node 4 from this list (Serialization: [4,5,6])
Since the list has two middle nodes with values 3 and 4, we return the second one.
 

Note:

The number of nodes in the given list will be between 1 and 100. 
*/
namespace Middle_of_Linked_List
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    public class AppHelper
    {
        public ListNode Middle(ListNode head)
        {
            if (head == null)
                return head;
            ListNode p = head; ListNode q = head;
            while (q != null && q.next != null)
            {
                p = p.next;
                q = q.next.next;
            }
            return p;
        }
    }
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            AppHelper helper = new AppHelper();
            return helper.Middle(head);
        }
    }

    
}
