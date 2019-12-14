using System;

namespace Happy_Numbers
{
    public static class AppHelper
    {
        public static bool IsHappy(long num)
        {
            long square = 0;
            long sum = 0;
            int count = 0;
            Found: while (num > 0)
            {
                square = Convert.ToInt64(Math.Pow(num % 10, 2));
                num = num / 10;
                sum = sum + square;
            }
            if (count < 10)
            {
                if (sum == 1)
                {
                    goto ReturnValue;
                }
                else
                {
                    num = sum;
                    square = 0;
                    sum = 0;
                    count++;
                    goto Found;
                }
            }
            else
            {
                goto hh;
            }
            hh: return false;
            ReturnValue: return true;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(AppHelper.IsHappy(n));
            Console.ReadLine();
        }
    }
}
































