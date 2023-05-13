using System;

namespace G_Array_Implementation_using_Stack
{
    public class MyStack
    {
        int capacity;
        int[] arr;
        int top;
        public MyStack(int c)
        {
            capacity = c;
            arr=new int[capacity];
            top = -1;
        }

        public void push(int x)
        {
            if(top == capacity-1)
            {
                throw new Exception("Stack Overflow");
            }
            top++;
            arr[top] = x;
        }

        public Int32 Pop()
        {
            if(top==-1)
            {
                throw new Exception("Stack Underflow");
            }
            int res = arr[top];
            top--;
            return res;
        }

        public int Peek()
        {
            if(top==-1)
            {
                throw new Exception("No items in Stack");
            }
            return arr[top];
        }

        public int Size()
        {
            return top + 1;
        }

        public Boolean IsEmpty()
        {
            return (top == -1);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(5);
            stack.push(100);
            stack.Pop();
            stack.Pop();
            Console.ReadLine();
        }
    }
}
