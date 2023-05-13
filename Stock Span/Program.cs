using System;
using System.Collections.Generic;
using System.Linq;

namespace Stock_Span
{
    public static class AppHelper
    {
        public static void StockSpan(Int32[] arr,Int32 n)
        {
            Stack<Int32> stck = new Stack<int>();
            stck.Push(0);
            Console.Write(0 + " ");
            for(int i = 1; i < n; i++)
            {
                while(stck.Any() && arr[stck.Peek()] <= arr[i])
                {
                    stck.Pop();
                }
                int span=!stck.Any() ? i+1 : i-stck.Peek();
                Console.WriteLine(arr[i]+ "  " + span + " ");
                stck.Push(i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 60, 10, 20, 40, 35, 30, 50, 70, 65 };
            AppHelper.StockSpan(arr, arr.Length);
            Console.ReadLine();
        }
    }
}
