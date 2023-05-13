using System;

namespace Shortest_Unsorted_Continuous_Subarray
{
    //https://leetcode.com/problems/shortest-unsorted-continuous-subarray/
    //https://www.algoexpert.io/questions/Subarray%20Sort

    public static class AppHelper
    {
        public static int [] SubarraySort(int [] arr)
        {
            int MinOutOfOrder = Int32.MaxValue;
            int MaxOutOfOrder = Int32.MinValue;
            int n = arr.Length;
            for(int i=0;i<n;i++)
            {
                int num = arr[i];
                if(isOutOfOrder(i,num,arr))
                {
                    MinOutOfOrder = Math.Min(MinOutOfOrder, num);
                    MaxOutOfOrder = Math.Max(MaxOutOfOrder, num);
                }
            }
            if(MinOutOfOrder== Int32.MaxValue)
            {
                return new int[] { -1, -1 };
            }
            int left = 0;
            int right = n - 1;
            while (MinOutOfOrder>=arr[left])
            {
                left++;
            }
            while(MaxOutOfOrder<=arr[right])
            {
                right--;
            }

            return new int[] { left, right };
        }
        public static bool isOutOfOrder(int i,int num,int [] arr)
        {
            if (i == 0)
                return num > arr[i + 1];
            if (i == arr.Length - 1)
                return num < arr[i - 1];
            return num > arr[i + 1] || num < arr[i - 1];
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2,6,4,8,10,9,15 };
            int[] result = AppHelper.SubarraySort(arr);
            Console.ReadLine();
        }
    }
}
