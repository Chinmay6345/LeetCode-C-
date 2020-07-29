using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/maximum-sum-circular-subarray/
/*
Given a circular array C of integers represented by A, find the maximum possible sum of a non-empty subarray of C.

Here, a circular array means the end of the array connects to the beginning of the array.  (Formally, C[i] = A[i] when 0 <= i < A.length, and C[i+A.length] = C[i] when i >= 0.)

Also, a subarray may only include each element of the fixed buffer A at most once.  (Formally, for a subarray C[i], C[i+1], ..., C[j], there does not exist i <= k1, k2 <= j with k1 % A.length = k2 % A.length.)

 

Example 1:

Input: [1,-2,3,-2]
Output: 3
Explanation: Subarray [3] has maximum sum 3
Example 2:

Input: [5,-3,5]
Output: 10
Explanation: Subarray [5,5] has maximum sum 5 + 5 = 10
Example 3:

Input: [3,-1,2,-1]
Output: 4
Explanation: Subarray [2,-1,3] has maximum sum 2 + (-1) + 3 = 4
Example 4:

Input: [3,-2,2,-3]
Output: 3
Explanation: Subarray [3] and [3,-2,2] both have maximum sum 3
Example 5:

Input: [-2,-3,-1]
Output: -1
Explanation: Subarray [-1] has maximum sum -1
 

Note:

-30000 <= A[i] <= 30000
1 <= A.length <= 30000
 */
namespace Maximum_Sum_Circular_Subarray
{
    public static class AppHelper
    {
        public static Int32 MaxSubarraySumCircular(Int32[] arr, Int32 n)
        {
            Int32 result = arr[0];
            for (Int32 i = 0; i < n; i++)
            {
                Int32 currMax = arr[i];
                Int32 currSum = arr[i];
                for (Int32 j = 1; j < n; j++)
                {
                    Int32 index = (i + j) % n;
                    currSum += arr[index];
                    currMax = Math.Max(currSum, currMax);
                }
                result = Math.Max(result, currMax);
            }
            return result;
        }
        private static Int32 MaxSumKadaneAlgo(Int32[] arr, Int32 n)
        {
            Int32 result = arr[0];
            Int32 max = arr[0];
            for (Int32 i = 1; i < n; i++)
            {
                max = Math.Max(max + arr[i], arr[i]);
                result = Math.Max(result, max);
            }
            return result;
        }
        public static Int32 MaxSum(Int32[] arr, Int32 n)
        {
            Int32 sum = MaxSumKadaneAlgo(arr, n);
            if (sum < 0)
            {
                return sum;
            }
            Int32 circularSum = 0;
            for (Int32 i = 0; i < n; i++)
            {
                circularSum += arr[i];
                arr[i] = -arr[i];
            }
            Int32 maxCSum = circularSum + MaxSumKadaneAlgo(arr, n);
            return Math.Max(sum, maxCSum);
        }
    }


    public class Solution
    {
        public int MaxSubarraySumCircular(int[] A)
        {
            return AppHelper.MaxSum(A, A.Length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
