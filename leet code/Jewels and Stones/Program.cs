using System;
using System.Linq;
//https://leetcode.com/problems/jewels-and-stones/

    /*You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is considered a different type of stone from "A".

Example 1:

Input: J = "aA", S = "aAAbbbb"
Output: 3
Example 2:

Input: J = "z", S = "ZZ"
Output: 0*/

namespace Jewels_and_Stones
{
    public static class AppHelper
    {
        public static Int32 NumJewelsInStones(string J, string S)
        {
            Int32 count = 0;
            for (Int32 i = 0; i < S.Length; i++)
            {
                if (J.Any(g => g == S[i]))
                    count++;
            }
            return count;
        }
    }

    public class Solution
    {
        public Int32 NumJewelsInStones(string J, string S)
        {
            return AppHelper.NumJewelsInStones(J, S);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
