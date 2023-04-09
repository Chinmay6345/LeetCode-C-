using System;

namespace _1137._N_th_Tribonacci_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int output = AppHelper.Tribonacci(n);
            Console.ReadLine();
        }
    }

    public static class AppHelper
    {
        public static int Tribonacci(int n)
        {
            int[] dp = new int[n + 3];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                dp[n] = dp[n - 3] + dp[n - 2] + dp[n - 1];
            }
            return dp[n];
        }
    }
}
