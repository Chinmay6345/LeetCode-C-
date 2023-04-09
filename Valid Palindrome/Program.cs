using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/valid-palindrome/
namespace Valid_Palindrome
{
    public static class AppHelper
    {
        public static bool isValid(String input)
        {
            char[] chars = input.ToCharArray();
            int i = 0;
            int j = input.Length - 1;

            while (i < j)
            {
                while (!Char.IsLetterOrDigit(chars[i]) && i < j)
                {
                    i++;
                }
                while (!Char.IsLetterOrDigit(chars[j]) && i < j)
                {
                    j--;
                }

                if (Char.ToLower(chars[i]) != Char.ToLower(chars[j]))
                {
                    return false;
                }

                i++;
                j--;
            }
            return true;
        }
    }

    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return true;
            }
            else
            {
                return AppHelper.isValid(s);
            }
        }
    }
}
