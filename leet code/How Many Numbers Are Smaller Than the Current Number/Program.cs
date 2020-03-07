using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].

Return the answer in an array.

 

Example 1:

Input: nums = [8,1,2,2,3]
Output: [4,0,1,1,3]
Explanation: 
For nums[0]=8 there exist four smaller numbers than it (1, 2, 2 and 3). 
For nums[1]=1 does not exist any smaller number than it.
For nums[2]=2 there exist one smaller number than it (1). 
For nums[3]=2 there exist one smaller number than it (1). 
For nums[4]=3 there exist three smaller numbers than it (1, 2 and 2).
Example 2:

Input: nums = [6,5,4,8]
Output: [2,1,0,3]
Example 3:

Input: nums = [7,7,7,7]
Output: [0,0,0,0]
 

Constraints:

2 <= nums.length <= 500
0 <= nums[i] <= 100 
*/
//https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
namespace How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    public static class AppHelper
    {
        public static Int32[] SmallerThanCurrent(Int32[] nums)
        {
            Int32[] returnarray = new Int32[nums.Length];
            if (nums.Length == 0)
            {
                return nums;
            }
            else if (nums.Length == 1)
            {
                nums[0] = 0;
                return nums;
            }
            else
            {
                for (Int32 i = 0; i < nums.Length; i++)
                {
                    Int32 count = nums.Count(x => x < nums[i]);
                    returnarray[i] = count;
                }
                return returnarray;
            }
        }
    }

    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            return AppHelper.SmallerThanCurrent(nums);
        }
    }
}
