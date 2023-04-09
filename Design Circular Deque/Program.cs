using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/design-circular-deque/

namespace Design_Circular_Deque
{
    public class MyCircularDeque
    {
        public Int32 front;
        public Int32 rear;
        public Int32 capacity;
        public Int32[] arr;
        public MyCircularDeque(int k)
        {
            this.capacity = k;
            this.front = -1;
            this.rear = -1;
            this.arr = new Int32[capacity];
        }
        public bool InsertFront(int value)
        {
            if (IsFull())
            {
                return false;
            }
            else if (front == -1 && rear == -1)
            {
                front = 0;
                rear = 0;
                arr[front] = value;
                return true;
            }
            else if (front == 0)
            {
                front = capacity - 1;
                arr[front] = value;
                return true;
            }
            else
            {
                front = front - 1;
                arr[front] = value;
                return true;
            }
        }
        public bool InsertLast(int value)
        {
            if (IsFull())
            {
                return false;
            }
            else if (front == -1 && rear == -1)
            {
                front = 0;
                rear = 0;
                arr[rear] = value;
                return true;
            }
            else if (rear == capacity - 1)
            {
                rear = 0;
                arr[rear] = value;
                return true;
            }
            else
            {
                rear = rear + 1;
                arr[rear] = value;
                return true;
            }
        }
        public bool DeleteFront()
        {
            if (IsEmpty())
            {
                return false;
            }
            else if (front == rear)
            {
                front = rear = -1;
                return true;
            }
            else if (front == capacity - 1)
            {
                front = 0;
                return true;
            }
            else
            {
                front = front + 1;
                return true;
            }
        }
        public bool DeleteLast()
        {
            if (IsEmpty())
            {
                return false;
            }
            else if (front == rear)
            {
                front = rear = -1;
                return true;
            }
            else if (rear == 0)
            {
                rear = capacity - 1;
                return true;
            }
            else
            {
                rear = rear - 1;
                return true;
            }
        }
        public int GetFront()
        {
            if (front == -1)
            {
                return -1;
            }
            return arr[front];
        }
        public int GetRear()
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
                return true;
            return false;
        }
        public bool IsFull()
        {
            if ((rear + 1) % capacity == front)
            {
                return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */
