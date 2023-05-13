using System;


namespace Inserting_in_a_Linked_List
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {

        }
        public Node(int d)
        {
            data = d;
            next = null;
        }

        public Node head;
        public void InsertAtSortedPosition(int d)
        {
            Node newNode = new Node(d);
            Node p = head;
            Node q = null;
            while (p != null && p.data < d)
            {
                q = p;
                p = p.next;
            }
            newNode.next = q.next;
            q.next = newNode;
        }
        public void InsertAtFirst(int d)
        {
            Node newnode = new Node(d);
            Node p = head;
            newnode.next = p;
            p=head=newnode; 
        }

        public void Create(int [] arr)
        {
            Node newNode=new Node(arr[0]);
            Node p = null;
            p=head=newNode;
            for (int i = 1; i < arr.Length; i++)
            {
                newNode=new Node(arr[i]);
                p.next = newNode;
                p=p.next;
            }

        }

        public void InsertInBetween(int d, int position)
        {
            if (position == 0)
            {
                InsertAtFirst(d);
            }
            else if (position > 0)
            {
                Node p = head;
                for (int i = 0; i < position && p != null; i++)
                {
                    p = p.next;
                }
                Node node = new Node(d);
              
                node.next = p.next;
                p.next = node;
            }
        }

        public void InsertAtLast(int data)
        {
            Node p = head;
            Node newNode=new Node(data);
            while(p.next != null)
            {
                p=p.next;
            }
            p.next = newNode;
        }

        public void DeleteAtFirst()
        {
            Node p = head;
            head = head.next;
            p = null;
        }

        public void DeleteAtPosition(int position)
        {
            Node p = head;
            Node q = null;
            for(int i=0;i<position-1;i++)
            {
                q = p;
                p = p.next;
            }
            q.next = p.next;
            p = null;
        }


        public void Display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.data + " -> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public void Reverse()
        {
            Node p = head;
            Node q = null;
            Node r = null;
            while(p != null)
            {
                r = q;
                q = p;
                p = p.next;
                q.next = r;
            }
            head = q;
        }

        public void RecursiveReverse(Node q,Node p)
        {
            if(p!=null)
            {
                RecursiveReverse(p, p.next);
                p.next = q;
            }
            else
            {
                head = q;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Node p = new Node();
            p.Create(new int[] { 10, 20, 30, 40, 50 });
            p.InsertAtFirst(3);
            p.InsertInBetween(15, 1);
            p.InsertAtLast(60);
            p.InsertAtSortedPosition(55);
            p.Display();
            p.DeleteAtFirst();
            p.DeleteAtPosition(4);
            Console.WriteLine("After reverse ");
            p.RecursiveReverse(null,p.head);
            p.Display();
            Console.ReadLine();
        }
    }
}
