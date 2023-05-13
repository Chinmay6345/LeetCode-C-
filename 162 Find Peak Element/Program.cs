using System;

namespace _162_Find_Peak_Element
{
    //https://leetcode.com/problems/find-peak-element/

    public class Solution
    {
        public int FindPeakElement(int[] nums)
        {


            int n = nums.Length;
            int[] arr = nums.Clone() as int[];
            int low = 0, high = n - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if ((mid == 0 || arr[mid - 1] <= arr[mid]) &&
                    (mid == n - 1 || arr[mid + 1] <= arr[mid]))
                    return mid;
                if (mid > 0 && arr[mid - 1] >= arr[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;

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
