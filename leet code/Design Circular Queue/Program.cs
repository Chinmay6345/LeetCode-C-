using System;
//https://leetcode.com/problems/design-circular-queue/
namespace Design_Circular_Queue
{
    public class MyCircularQueue
    {
        public Int32[] arr;
        public Int32 front;
        public Int32 rear;
        public Int32 size;
        public MyCircularQueue(int k)
        {
            this.size = k;
            this.front = -1;
            this.rear = -1;
            this.arr = new Int32[size];
        }
        public bool EnQueue(int value)
        {
            if (front == -1 && rear == -1)
            {
                front = 0;
                rear = 0;
                arr[rear] = value;
                return true;
            }
            else if ((rear + 1) % size == front)
            {
                Console.WriteLine("Queue is Full");
                return false;
            }
            else
            {
                rear = (rear + 1) % size;
                arr[rear] = value;
                return true;
            }
        }
        public bool DeQueue()
        {
            if (front == -1 && rear == -1)
            {
                Console.WriteLine("Queue is Empty");
                return false;
            }
            else if (front == rear)
            {
                front = -1;
                rear = -1;
                return true;
            }
            else
            {
                front = (front + 1) % size;
                return true;
            }
        }
        public int Front()
        {
            if (front == -1)
            {
                return -1;
            }
            return arr[front];
        }
        public int Rear()
        {
            if (rear == -1)
            {
                return -1;
            }
            return arr[rear];
        }
        public bool IsEmpty()
        {
            if (front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFull()
        {
            if (front == 0 && rear == size - 1)
            {
                return true;
            }
            if (front == rear + 1)
            {
                return true;
            }
            return false;
        }
    }

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
