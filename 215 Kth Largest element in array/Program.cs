using System;

namespace _215_Kth_Largest_element_in_array
{
    public static class Solution
    {
        public static int findKthLargest(int[] nums, int k)
        {
            //
            int start = 0, end = nums.Length - 1, index = nums.Length - k;
            while (start < end)
            {
                int pivot = partion(ref nums, start, end);
                if (pivot < index) start = pivot + 1;
                else if (pivot > index) end = pivot - 1;
                else return nums[pivot];
            }
            return nums[start];
        }

        private static int partion(ref int[] nums, int start, int end)
        {
            int pivot = start, temp;
            while (start <= end)
            {
                while (start <= end && nums[start] <= nums[pivot])
                {
                    Console.WriteLine("start end num[start] num[pivot] " + start + " " + end + " " + nums[start] + " " + nums[pivot]);
                    start++;
                }
                while (start <= end && nums[end] > nums[pivot]) end--;
                if (start > end) break;
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
            }
            temp = nums[end];
            nums[end] = nums[pivot];
            nums[pivot] = temp;
            return end;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 3, 2, 1, 5, 6, 4 };
            int o = Solution.findKthLargest(arr, 2);
            Console.ReadLine();
        }
    }
}
