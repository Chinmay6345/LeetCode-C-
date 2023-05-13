using System;

namespace Egg_Drop_Puzzle
{
    public static class AppHelper
    {
        public static int eggDrop(int e, int f)
        {
            int[,] dp = new int[f + 1, e + 1];

            for (int i = 1; i <= e; i++)
            {
                dp[1, i] = 1;
                dp[0, i] = 0;
            }

            for (int j = 1; j <= f; j++)
            {
                dp[j, 1] = j;
            }

            for (int i = 2; i <= f; i++)
            {
                for (int j = 2; j <= e; j++)
                {
                    dp[i, j] = int.MaxValue;
                    for (int x = 1; x <= i; x++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], 1 + Math.Max(dp[x - 1, j - 1], dp[i - x, j]));
                    }
                }
            }

            return dp[f, e];
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
