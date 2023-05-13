using System;
using System.Collections.Generic;

namespace _138._Copy_List_with_Random_Pointer
{
    public class Node
    {
        public int data;
        public Node next, random;
        public Node(int x)
        {
            data = x;
            next = random = null;
        }
    }

    public static class AppHelper
    {
        public static Node CopyRandomList(Node head)
        {
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();
            Node curr = head;
            while (curr != null)
            {
                map.Add(curr, new Node(curr.data));
                curr = curr.next;
            }
            curr = head;
            while (curr != null)
            {
                Node cloneCurr = map[curr];
                cloneCurr.next = map[curr.next];
                cloneCurr.random = map[curr.random];
            }
            Node head2 = map[head];
            return head2;
        }

        public static Node CopyRandomList2(Node head)
        {
            if(head==null)
            {
                return null;
            }
            Node curr = head;
            while(curr != null)
            {
                Node nextNode = curr.next;
                curr.next=new Node(curr.data);
                curr.next.next = nextNode;
                curr = nextNode;
            }
            for(curr = head; curr != null; curr = curr.next.next)
            {
                curr.next.random = curr.random!=null ? curr.random.next : null;
            }

            Node original=head;
            Node copy=head.next;
            Node temp = copy;
            while(original != null && copy!=null)
            {
                original.next = original.next !=null ? original.next.next : null;
                copy.next = copy.next !=null ? copy.next.next : null;
                original=original.next;
                copy=copy.next;
            }
            return temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(10);
            head.next = new Node(5);
            head.next.next = new Node(20);
            head.next.next.next = new Node(15);
            head.next.next.next.next = new Node(20);

            head.random = head.next.next;
            head.next.random = head.next.next.next;
            head.next.next.random = head;
            head.next.next.next.random = head.next.next;
            head.next.next.next.next.random = head.next.next.next;

            Node newNode=AppHelper.CopyRandomList(head);
            Console.ReadLine();
        }
    }
}
