using System;

namespace Max_Consecutive_Ones
{
    //https://leetcode.com/problems/max-consecutive-ones/
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int res = 0, curr = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    
                    curr++;
                    res = Math.Max(curr, res);
                }
                else
                {
                    curr = 0;
                }
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
