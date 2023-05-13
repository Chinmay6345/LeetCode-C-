using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/unique-binary-search-trees/
namespace Unique_Binary_Search_Trees
{

    public class Solution
    {
        public int NumTrees(int n)
        {
            List<List<int>> a = new List<List<int>>();
            var r=a.Distinct().ToList();
            if (n == 1)
            {
                return 1;
            }
            int[] dp = new int[n + 1];
            dp[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                dp[i] = 0;

                for (int j = 0; j < i; j++)
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }

            return dp[n];
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
