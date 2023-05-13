using System;
using System.Collections.Generic;

namespace Queue_Reversal
{
    public static class AppHelper
    {
        public static void Reverse(Queue<int>q)
        {
            if (q.Count == 0)
                return;
            int x = q.Dequeue();
            Reverse(q);
            q.Enqueue(x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AppHelper.Reverse(new Queue<int>(new int[] { 10, 20, 30 }));
            Console.ReadLine();
        }
    }
}
