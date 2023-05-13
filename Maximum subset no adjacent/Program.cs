using System;

namespace Maximum_subset_no_adjacent
{
    //https://www.algoexpert.io/questions/Max%20Subset%20Sum%20No%20Adjacent
    public static class AppHelper
    {
        public static int sum(int[] arr)
        {
            if (arr.Length == 0)
                return 0;
            if (arr.Length == 1)
                return arr[0];
            int[] nums = (int[])arr.Clone();
            nums[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < arr.Length; i++)
            {
                nums[i] = Math.Max(nums[i - 1], nums[i - 2] + nums[i]);
            }
            return nums[nums.Length - 1];
        }
    }

    public class P1
    {
        public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            return AppHelper.sum(array);
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
