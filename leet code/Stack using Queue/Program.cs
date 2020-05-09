using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/implement-stack-using-queues/
namespace Stack_using_Queue
{
    public class MyStack
    {
        internal Queue<Int32> q1 = null;
        internal List<Int32> lst = null;
        public MyStack()
        {
            this.q1 = new Queue<Int32>();
            this.lst = new List<Int32>();
        }
        public void Push(int x)
        {
            q1.Enqueue(x);
            lst.Insert(0, q1.Dequeue());
        }
        public int Pop()
        {
            int x = lst[0];
            lst.RemoveAt(0);
            return x;
        }
        public int Top()
        {
            return lst[0];
        }
        public bool Empty()
        {
            return lst.Count() == 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
