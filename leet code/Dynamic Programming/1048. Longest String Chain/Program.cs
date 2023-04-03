using System;
using System.Collections.Generic;
using System.Linq;
namespace _1048.Longest_String_Chain
{
    //https://leetcode.com/problems/longest-string-chain/


    /*
    You are given an array of words where each word consists of lowercase English letters.

wordA is a predecessor of wordB if and only if we can insert exactly one letter anywhere in wordA without changing the order of the other characters to make it equal to wordB.

For example, "abc" is a predecessor of "abac", while "cba" is not a predecessor of "bcad".
A word chain is a sequence of words [word1, word2, ..., wordk] with k >= 1, where word1 is a predecessor of word2, word2 is a predecessor of word3, and so on. A single word is trivially a word chain with k == 1.

Return the length of the longest possible word chain with words chosen from the given list of words.

 

Example 1:

Input: words = ["a","b","ba","bca","bda","bdca"]
Output: 4
Explanation: One of the longest word chains is ["a","ba","bda","bdca"].  
   */

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class AppHelper
    {

        private static bool compare(string  s1, string s2)
        {
            if (s1.Length != s2.Length + 1) return false;

            int first = 0;
            int second = 0;

            while (first < s1.Length)
            {
                if (second < s2.Length && s1[first] == s2[second])
                {
                    first++;
                    second++;
                }
                else first++;
            }
            if (first == s1.Length && second == s2.Length) return true;
            else return false;
        }


        public static int LongestStrChain(string[] words)
        {

            int n = words.Length;

            //sort the array

            Array.Sort(words, (x,y)=>x.Length.CompareTo(y.Length));

            List<int>dp=Enumerable.Repeat(1,n).ToList();

            int maxi = 1;

            for (int i = 0; i <= n - 1; i++)
            {

                for (int prev_index = 0; prev_index <= i - 1; prev_index++)
                {

                    if (compare(words[i], words[prev_index]) && 1 + dp[prev_index] > dp[i])
                    {
                        dp[i] = 1 + dp[prev_index];
                    }
                }

                if (dp[i] > maxi)
                    maxi = dp[i];
            }
            return maxi;
        }
    }

}
