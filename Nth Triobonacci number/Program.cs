using System;
//https://leetcode.com/problems/n-th-tribonacci-number/

/*
The Tribonacci sequence Tn is defined as follows: 

T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.

Given n, return the value of Tn.

 

Example 1:

Input: n = 4
Output: 4
Explanation:
T_3 = 0 + 1 + 1 = 2
T_4 = 1 + 1 + 2 = 4
Example 2:

Input: n = 25
Output: 1389537 
*/
namespace Nth_Triobonacci_number
{
    public static class AppHelper
    {
        public static Int32 TriboNacci(int n)
        {
            Int32 Tzero = 0;
            Int32 Tone = 1;
            Int32 Ttwo = 1;
            Int32 sum = 0;
            if (n == 0)
            {
                sum = Tzero;
            }
            else if (n == 1)
            {
                sum = Tone;
            }
            if (n == 2)
            {
                sum = Ttwo;
            }
            while (n > 2)
            {
                sum = Tzero + Tone + Ttwo;
                Tzero = Tone;
                Tone = Ttwo;
                Ttwo = sum;
                n = n - 1;
            }

            return sum;
        }
    }

    public class Solution
    {
        public int Tribonacci(int n)
        {
            return AppHelper.TriboNacci(n);
        }
    }
}
