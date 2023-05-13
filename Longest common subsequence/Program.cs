using System;
using System.Collections.Generic;

namespace Longest_common_subsequence
{
    public static class AppHelper
    {
        public static List<char> lcs(String s1, String s2)
        {
            int m = s1.Length, n = s2.Length;

            int[,] dp = new int[m + 1, n + 1];

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
            return buildsequence(dp,s1);
        }

        public static List<char>buildsequence(int [,] lengths,string str)
        {
            List<char> sequence = new List<char>();
            int i = lengths.GetLength(0) - 1;
            int j = lengths.GetLength(1) - 1;
            while(i!=0 && j!=0)
            {
                if(lengths[i,j]==lengths[i-1,j])
                {
                    i--;
                }
                else if(lengths[i,j]==lengths[i,j-1])
                {
                    j--;
                }
                else
                {
                    sequence.Insert(0, str[j - 1]);
                    i--;
                    j--;
                }
            }
            return sequence;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "AXYZ", s2 = "BAZ";
            var k = AppHelper.lcs(s1, s2);
            Console.ReadLine();
        }
    }
}
