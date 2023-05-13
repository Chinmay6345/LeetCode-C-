using System;
using System.Collections.Generic;

//https://leetcode.com/problems/longest-consecutive-sequence/

namespace Longest_Consecutive_Sequence___Largest_Range__
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            HashSet<int> map = new HashSet<int>(nums);
            int longestLength = 0;
            foreach (int num in nums)
            {
                if (map.Contains(num))
                {
                    map.Remove(num);
                    int currentLength = 1;
                    int left = num - 1;
                    int right = num + 1;
                    while (map.Contains(left))
                    {
                        map.Remove(left);
                        currentLength += 1;
                        left--;
                    }
                    while (map.Contains(right))
                    {
                        map.Remove(right);
                        currentLength += 1;
                        right++;
                    }
                    if (currentLength > longestLength)
                    {
                        longestLength = currentLength;
                    }
                }
            }

            return longestLength;
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
