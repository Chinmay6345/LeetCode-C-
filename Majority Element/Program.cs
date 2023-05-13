using System;

namespace Majority_Element
{
    //https://leetcode.com/problems/majority-element/
    public static class AppHelper
    {
        public static Int32 Majority(Int32 [] arr)
        {
            Int32 n = arr.Length;
            Int32 count = 1, res = 0;
            for(Int32 i=1;i<n;i++)
            {
                if (arr[res] == arr[i])
                    count++;
                else
                    count--;
                if(count==0)
                {
                    count = 1;
                    res = i;
                }
            }
            count = 0;
            for(Int32 i=0;i<n;i++)
            {
                if (arr[res] == arr[i])
                    count++;
            }
            if (count <= n / 2)
                return -1;
            return arr[res];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
