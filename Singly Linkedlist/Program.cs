using System;

namespace Singly_Linkedlist
{
    public class Node
    {
        public Int32 data;
        public Node next;

        public Node()
        {

        }
        public Node(Int32 data)
        {
            this.data = data;
            this.next = null;
        }
        public Node head;
        public Node head1;
        public void Create(Int32[] arr)
        {
            Node newNode = new Node(arr[0]);
            Node p = null;
            p = head = newNode;
            for (Int32 i = 1; i < arr.Length; i++)
            {
                newNode = new Node(arr[i]);
                p.next = newNode;
                p = p.next;
            }
            //PrintElementsinSinglyLinkedList();
            //Console.WriteLine();
            //RecursiveDisplayUsingHeadRecursion(head);
            //Console.WriteLine();
            //RecursiveDisplayUsingTailRecursion(head);
            //Console.WriteLine();
        }
        public void Create1(Int32[] arr)
        {
            Node newNode = new Node(arr[0]);
            Node p = null;
            p = head1 = newNode;
            for (Int32 i = 1; i < arr.Length; i++)
            {
                newNode = new Node(arr[i]);
                p.next = newNode;
                p = p.next;
            }
            //PrintElementsinSinglyLinkedList();
            //Console.WriteLine();
            //RecursiveDisplayUsingHeadRecursion(head);
            //Console.WriteLine();
            //RecursiveDisplayUsingTailRecursion(head);
            //Console.WriteLine();
        }
        public void PrintElementsinSinglyLinkedList()
        {
            Node q = head;
            while (q != null)
            {
                Console.Write(q.data + " ");
                q = q.next;
            }
        }
        public void RecursiveDisplayUsingHeadRecursion(Node p)
        {
            if (p != null)
            {
                Console.Write(p.data + " ");
                RecursiveDisplayUsingHeadRecursion(p.next);
            }
        }
        public void RecursiveDisplayUsingTailRecursion(Node p)
        {
            if (p != null)
            {
                RecursiveDisplayUsingTailRecursion(p.next);
                Console.Write(p.data + " ");

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 1, 2, 3, 4, 5, 6 };
            Node node = new Node();
            node.Create(arr);
            Console.ReadLine();
        }
    }
}
