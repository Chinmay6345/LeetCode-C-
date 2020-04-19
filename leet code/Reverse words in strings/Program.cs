using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/reverse-words-in-a-string/
/*
Given an input string, reverse the string word by word.

 

Example 1:

Input: "the sky is blue"
Output: "blue is sky the"
Example 2:

Input: "  hello world!  "
Output: "world! hello"
Explanation: Your reversed string should not contain leading or trailing spaces.
Example 3:

Input: "a good   example"
Output: "example good a"
Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
 

Note:

A word is defined as a sequence of non-space characters.
Input string may contain leading or trailing spaces. However, your reversed string should not contain leading or trailing spaces.
You need to reduce multiple spaces between two words to a single space in the reversed string.
  
*/
namespace Reverse_words_in_strings
{
    public static class AppHelper
    {
        public static String ModifiedString(String str)
        {
            String[] arr = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);
            return String.Join(" ", arr);
        }
        public static String ModifiedString1(String str)
        {
            String result = String.Empty;
            if (String.IsNullOrEmpty(str))
            {
                return str;
            }
            else
            {
                str = string.Join(" ", str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                return String.Join(" ", str.Split(' ').Reverse().ToArray());
            }
        }
        public static String ModifiedString2(String str)
        {
            String[] arr = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);
            return String.Join(" ", arr);
        }
    }
}

    public class Solution
    {
        public string ReverseWords(string s)
        {
            return AppHelper.ModifiedString(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
