using System;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/remove-duplicates-from-sorted-array/

namespace Remove_Duplicates_from_Sorted_Array
{
    public static class AppHelper
    {
        public static Int32 DuplicateCount(Int32[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.All(g => g == nums.First()))
            {
                for (int j = 0; j < 1; j++)
                {
                    nums[j] = nums.First();
                }
                return 1;
            }
            Int32 count = 0;
            var GroupedCount = nums.GroupBy(a => a).Select(g => new { Key = g.Key, Count = g.Count() });
            if (GroupedCount.Count() > 0)
            {
                count = GroupedCount.Count();
                var distintct = GroupedCount.Distinct();
                int counter = 0;
                foreach (var item in distintct)
                {
                    nums[counter] = Int32.Parse(item.Key.ToString());
                    counter++;
                }
                return count;
            }
            else
            {
                return count;
            }
        }
        public static Int32 ArrLen(Int32[] arr)
        {
            try
            {
                if (arr.Length == 0)
                {
                    return 0;
                }
                HashSet<Int32> HSet = new HashSet<Int32>(arr);
                for (Int32 i = 0; i < HSet.Count(); i++)
                {
                    arr[i] = HSet.ElementAt(i);
                }
                return HSet.Count();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }


    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            return AppHelper.DuplicateCount(nums);
        }
    }
}
