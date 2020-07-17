using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*https://leetcode.com/problems/running-sum-of-1d-array/
Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

Return the running sum of nums.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
Example 2:

Input: nums = [1,1,1,1,1]
Output: [1,2,3,4,5]
Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
Example 3:

Input: nums = [3,1,2,10,1]
Output: [3,4,6,16,17]
 

Constraints:

1 <= nums.length <= 1000
-10^6 <= nums[i] <= 10^6
*/
namespace Running_Sum_of_1d_Array
{
    public static class AppHelper
    {
        public static Int32[] RunningSum(Int32[] arr)
        {
            List<Int32> lst = new List<Int32>();
            if (arr.Length == 1)
            {
                lst.Add(arr[0]);
                return lst.ToArray<Int32>();
            }
            Int32 total = 0;
            lst.Add(arr[0]);
            for (Int32 i = 1; i < arr.Length; i++)
            {
                int k = i;
                for (int j = 0; j <= k; j++)
                {
                    total += arr[j];
                }
                lst.Add(total);
                total = 0;
            }
            return lst.ToArray<Int32>();
        }
    }

    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            return AppHelper.RunningSum(nums);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
