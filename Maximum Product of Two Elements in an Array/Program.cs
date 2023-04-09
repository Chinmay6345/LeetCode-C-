using System;
using System.Linq;
//https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
/*
Given the array of integers nums, you will choose two different indices i and j of that array. Return the maximum value of (nums[i]-1)*(nums[j]-1).
 

Example 1:

Input: nums = [3,4,5,2]
Output: 12 
Explanation: If you choose the indices i=1 and j=2 (indexed from 0), you will get the maximum value, that is, (nums[1]-1)*(nums[2]-1) = (4-1)*(5-1) = 3*4 = 12. 
Example 2:

Input: nums = [1,5,4,5]
Output: 16
Explanation: Choosing the indices i=1 and j=3 (indexed from 0), you will get the maximum value of (5-1)*(5-1) = 16.
Example 3:

Input: nums = [3,7]
Output: 12
 

Constraints:

2 <= nums.length <= 500
1 <= nums[i] <= 10^3 
*/
namespace Maximum_Product_of_Two_Elements_in_an_Array
{
    public static class AppHelper
    {
        public static Int32 MaxProduct(Int32[] nums)
        {
            if (nums.Length == 2)
                return (nums[0] - 1) * (nums[1] - 1);
            else
            {
                nums = nums.Select(g => g - 1).OrderBy(g => g).ToArray();
                int max = nums.Max();
                int count = nums.Where(g => g == max).Count();
                if (count > 1)
                {
                    return max * max;
                }
                else
                {
                    return (nums[nums.Length - 1]) *
                          (nums[nums.Length - 2]);
                }
            }
        }
    }

    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            return AppHelper.MaxProduct(nums);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
