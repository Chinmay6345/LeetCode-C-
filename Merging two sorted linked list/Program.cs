using System;
using Inserting_in_a_Linked_List;

namespace Merging_two_sorted_linked_list
{
    public static class AppHelper
    {
        public static Node Merge(Node first,Node second)
        {
            Node third = null; //head of last LL...
            Node last = null;

            if (first.data < second.data)
            {
                third = last = first;
                first = first.next;
                third.next = null;
            }
            else
            {
                third = last = second;
                second = second.next;
                third.next = null;
            }

            while (first != null && second !=null)
            {
                if(first.data < second.data)
                {
                    last.next = first;
                    last = first;
                    first=first.next;
                    last.next = null;
                }
                else
                {
                    last.next = second;
                    last = second;
                    second = second.next;
                    last.next = null;
                }
            }
            if(first != null)
            {
                last.next = first;
            }
            else
            {
                last.next = second;
            }
            return third;
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
