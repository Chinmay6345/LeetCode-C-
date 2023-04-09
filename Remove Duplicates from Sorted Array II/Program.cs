using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/

namespace Remove_Duplicates_from_Sorted_Array_II
{
    public static class AppHelper
    {
        public static int Duplicate(int[] nums)
        {
            int count = 0, j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    count++;
                else
                    count = 0;
                if (count > 1)
                    nums[j] = nums[i + 1];
                else
                    nums[j++] = nums[i];
            }
            if (j < nums.Length)
            {
                nums[j++] = nums[nums.Length - 1];
            }
            return j;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k=AppHelper.Duplicate(nums);
        }
    }
}
