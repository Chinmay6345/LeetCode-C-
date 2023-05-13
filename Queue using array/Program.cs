using System;
using System.Collections.Generic;

namespace Queue_using_array
{

    public class MyQueue
    {
        internal int [] arr = null;
        internal int front;
        internal int capacity;
        internal int size;

        public MyQueue(int c)
        {
            capacity = c;
            front = 0;
            size = 0;
            arr = new int[c];

        }

        public int getRear()
        {
            if (IsEmpty())
                return -1;
            return (front + size - 1) % capacity;
        }

        public void Enqueue(int x)
        {
            if (IsFull())
                return ;
            int rear = getRear();
            rear = (rear + 1) % capacity;
            arr[rear] = x;
            size++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                return -1;
            front= (front + 1) % capacity; 
            size--;
            return front;
        }

        public bool IsFull()
        {
            return size == capacity;
        }

        public bool IsEmpty()
        {
            return size== 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue q = new MyQueue(3);
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            Console.ReadLine();
        }
    }
}
