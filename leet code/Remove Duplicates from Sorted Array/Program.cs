using System;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
/*
 Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

Example 1:

Given nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.

It doesn't matter what you leave beyond the returned length.
Example 2:

Given nums = [0,0,1,1,1,2,2,3,3,4],

Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.

It doesn't matter what values are set beyond the returned length.
Clarification:

Confused why the returned value is an integer but your answer is an array?

Note that the input array is passed in by reference, which means modification to the input array will be known to the caller as well.

Internally you can think of this:

// nums is passed in by reference. (i.e., without making a copy)
int len = removeDuplicates(nums);

// any modification to nums in your function would be known by the caller.
// using the length returned by your function, it prints the first len elements.
for (int i = 0; i < len; i++) {
    print(nums[i]);
}
 */
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
