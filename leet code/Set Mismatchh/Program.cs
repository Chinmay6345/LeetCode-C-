using System;

//https://leetcode.com/problems/set-mismatch/

namespace Set_Mismatchh
{
    public static class AppHelper
    {
        public static int[] MisMatch(int[] nums)
        {
            Array.Sort(nums);
            int dup = -1, missing = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                int k = nums[i];
                int k1 = nums[i - 1];
                if (k == k1)
                    dup = k;
                else if (k > k1 + 1)
                    missing = k1 + 1;
            }
            int x = nums.Length;
            int y = nums[x - 1];
            return new int[] { dup, x != y ? x : missing };
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = AppHelper.MisMatch(new int[] { 1, 2, 2, 4 });
            Console.ReadLine();
        }
    }
}
