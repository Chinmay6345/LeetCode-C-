using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/uncrossed-lines/

namespace _1035.Uncrossed_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int[,] memo = new int[m + 1, n + 1];
            return AppHelper.LCS(nums1, nums2, m, n, ref memo);
        }
    }

    public static class AppHelper
    {
        public static int LCS(int[] s1, int[] s2, int m, int n, ref int[,] dp)
        {
            for (int i = 0; i <= m; i++)
            {
                dp[i, 0] = 0;
            }
            for (int j = 0; j <= n; j++)
            {
                dp[0, j] = 0;
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }
            return dp[m, n];
        }
    }
}
