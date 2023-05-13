using System;

namespace Longest_Mountain_in_Array
{
    //https://leetcode.com/problems/longest-mountain-in-array/
    public static class Solution
    {
        public static int LongestMountain(int[] arr)
        {
            int longestPeak = 0;
            int i = 1;
            int n = arr.Length;
            while (i < n - 1)
            {
                bool isPeak = arr[i - 1] < arr[i] && arr[i] > arr[i + 1];
                if (!isPeak)
                {
                    i += 1;
                    continue;
                }
                int leftIndex = i - 2;
                int rightIndex = i + 2;
                while (leftIndex >= 0 && arr[leftIndex] < arr[leftIndex + 1])
                {
                    leftIndex = leftIndex - 1;
                }
                while (rightIndex < n && arr[rightIndex] < arr[rightIndex - 1])
                {
                    rightIndex = rightIndex + 1;
                }
                int currentPeak = rightIndex - leftIndex - 1;
                longestPeak = Math.Max(longestPeak, currentPeak);
                i = rightIndex;
            }
            return longestPeak;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
            int k = Solution.LongestMountain(arr);
            Console.ReadLine();
        }
    }
}
