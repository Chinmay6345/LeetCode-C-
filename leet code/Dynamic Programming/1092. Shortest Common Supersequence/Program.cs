using System;

namespace _1092._Shortest_Common_Supersequence
{
    //https://leetcode.com/problems/shortest-common-supersequence/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Solution
    {
        public string ShortestCommonSupersequence(string str1, string str2)
        {
            String s1 = str1;
            String s2 = str2;
            int n = s1.Length;
            int m = s2.Length;

            int[,] dp = new int[n + 1, m + 1];
            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = 0;
            }
            for (int k = 0; k <= m; k++)
            {
                dp[0, k] = 0;
            }

            for (int ind1 = 1; ind1 <= n; ind1++)
            {
                for (int ind2 = 1; ind2 <= m; ind2++)
                {
                    if (s1[ind1 - 1] == s2[ind2 - 1])
                        dp[ind1, ind2] = 1 + dp[ind1 - 1, ind2 - 1];
                    else
                        dp[ind1, ind2] = 0 + Math.Max(dp[ind1 - 1, ind2], dp[ind1, ind2 - 1]);
                }
            }

            int len = dp[n, m];
            int i1 = n;
            int j1 = m;

            int index = len - 1;
            String ans = "";

            while (i1 > 0 && j1 > 0)
            {
                if (s1[i1 - 1] == s2[j1 - 1])
                {
                    ans += s1[i1 - 1];
                    index--;
                    i1--;
                    j1--;
                }
                else if (dp[i1 - 1, j1] > dp[i1, j1 - 1])
                {
                    ans += s1[i1 - 1];
                    i1--;
                }
                else
                {
                    ans += s2[j1 - 1];
                    j1--;
                }
            }

            //Adding Remaing Characters - Only one of the below two while loops will run 

            while (i1 > 0)
            {
                ans += s1[i1 - 1];
                i1--;
            }
            while (j1 > 0)
            {
                ans += s2[j1 - 1];
                j1--;
            }
            char[] arr = ans.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }
    }
}
