using System;
//https://leetcode.com/problems/happy-number/
/*
Write an algorithm to determine if a number n is "happy".

A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.

Return True if n is a happy number, and False if not.

Example: 

Input: 19
Output: true
Explanation: 
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1 
*/
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
































