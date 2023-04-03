using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_1_Knapsack_Problem
{
    //https://practice.geeksforgeeks.org/problems/0-1-knapsack-problem0945/1
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Solution
    {
        //Complete this function
        public int knapSack(int W, int[] wt, int[] val, int n)
        {
            int[,] dp = new int[n, W + 1];
            for (int i = wt[0]; i <= W; i++)
            {
                dp[0, i] = val[0];
            }
            for (int idx = 1; idx < n; idx++)
            {
                for (int cap = 0; cap <= W; cap++)
                {
                    int notTaken = 0 + dp[idx - 1, cap];
                    int taken = int.MinValue;
                    if (wt[idx] <= cap)
                    {
                        taken = val[idx] + dp[idx - 1, cap - wt[idx]];
                    }
                    dp[idx, cap] = Math.Max(notTaken, taken);
                }
            }
            return dp[n - 1, W];
        }
    }
}
