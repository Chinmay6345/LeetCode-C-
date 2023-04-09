using System;
using System.Linq;
using System.Collections.Generic;


namespace _2104._Sum_of_Subarray_Ranges
{
    //https://leetcode.com/problems/sum-of-subarray-ranges/description/
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2,9,7,8,3,4,6,1 };

            Console.WriteLine(AppHelper.SubArrayRanges(nums));
            Console.ReadLine();
        }
    }
    public static class AppHelper
    {
        public static long SubArrayRanges(int[] nums)
        {
           
            Stack<int> stack = new Stack<int>();
            int res = 0;
            int n = nums.Length;
            int[] minPrev = new int[n];
            int[] minNext = new int[n];



            for (int i = 0; i < n; i++)
            {
                while (stack.Any() && nums[stack.Peek()] > nums[i])
                {
                    stack.Pop();
                }

                if (stack.Any())
                {
                    minPrev[i] = i + 1;
                }

                else
                {
                    minPrev[i] = i - stack.Peek();
                }

                stack.Push(i);
            }

            stack.Clear();
            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Any() && nums[stack.Peek()] >= nums[i])
                    stack.Pop();

                if (stack.Any())
                {
                    minNext[i] = n - i;
                }

                else
                {
                    minNext[i] = stack.Peek() - i;
                }

                stack.Push(i);
            }

            int MOD = (int)(Math.Pow(10, 9) + 7);

            for (int i = 0; i < n; i++)
            {
                res = (res + nums[i] * minPrev[i] * minNext[i]) % MOD;
            }

            return res;
        }
    }
}
