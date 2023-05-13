using System;


namespace Edit_Distance
{

    public static class AppHelper
    {
        public static int eD(String s1, String s2, int m, int n)
        {
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                dp[i, 0] = i;
            }

            for (int j = 0; j <= n; j++)
            {
                dp[0, j] = j;
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = 1 + Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1],
                                                                dp[i - 1, j - 1]));

                    }
                }
            }

            return dp[m, n];
        }

    }

    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            return AppHelper.eD(word1, word2, word1.Length, word2.Length);
        }
    }
    class Program
    {
        //https://leetcode.com/problems/edit-distance/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
