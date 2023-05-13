using System;
using System.Collections.Generic;

namespace Leaders_in_an_array
{
    public static class AppHelper
    {
        public static List<Int32>LeadersArray(Int32 [] arr)
        {
            List<Int32> lst = new List<int>();
            int n = arr.Length;
            int curr_leader = arr[n - 1];
            lst.Add(arr[n - 1]);
            for(int i=n-2;i>=0;i--)
            {
                if(arr[i]>curr_leader)
                {
                    curr_leader = arr[i];
                    lst.Add(arr[i]);
                }
            }
            lst.Reverse();
            return lst;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 7, 10, 4, 3, 3, 6, 5, 2 };
            List<int> leaders = AppHelper.LeadersArray(arr);
            Console.ReadLine();
        }
    }
}
