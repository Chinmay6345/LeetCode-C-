using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Regular_Expression_Matching
{
    //https://leetcode.com/problems/regular-expression-matching/description/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class AppHelper
    {
        public static bool IsMatch(string s, string p)
        {
            bool[,] cache = new bool[s.Length, p.Length];
            return match_TopDown(s, p, 0, 0, cache);
        }

        public static bool match(string s, string p, int i, int j)
        {
            if (i >= s.Length && j >= p.Length)
            {
                return true;
            }
            if (j >= p.Length)
            {
                return false;
            }
            bool IsMatch = i < s.Length && (s[i] == p[j] || p[j] == '.');
            if (j + 1 < p.Length && p[j + 1] == '*')
            {
                return match(s, p, i, j + 2) || (IsMatch && match(s, p, i + 1, j));
            }
            if (IsMatch)
                return match(s, p, i + 1, j + 1);
            return false;
        }

        public static bool match_TopDown(string s, string p, int i, int j, bool[,] cache)
        {
            if (cache[i, j])
            {
                return true;
            }
            if (i >= s.Length && j >= p.Length)
            {
                return true;
            }
            if (j >= p.Length)
            {
                return false;
            }
            bool IsMatch = i < s.Length && (s[i] == p[j] || p[j] == '.');
            if (j + 1 < p.Length && p[j + 1] == '*')
            {
                cache[i, j] = match(s, p, i, j + 2) || (IsMatch && match(s, p, i + 1, j));
                return cache[i, j];
            }
            if (IsMatch)
            {
                cache[i, j] = match(s, p, i + 1, j + 1);
            }
            cache[i, j] = false;
            return false;
        }

        public static bool BottomUp(string s, string p)
        {
            int n = s.Length, m = p.Length;
            bool[,] dp = new bool[n + 1, m + 1];
            dp[n, m] = true;
            for (int i = n; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    bool matched = i < s.Length && (s[i] == p[j] || p[j] == '.');
                    if (j + 1 < m && p[j + 1] == '*')
                    {
                        dp[i, j] = (matched && dp[i + 1, j]) || dp[i, j + 2];
                    }

                    else if (matched)
                        dp[i, j] = dp[i + 1, j + 1];
                }
            }
            return dp[0, 0];
        }
    }

}
