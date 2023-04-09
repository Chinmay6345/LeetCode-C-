using System;
//https://leetcode.com/problems/length-of-last-word/
namespace Length_of_Last_word
{
    public static class AppHelper
    {
        public static int lengthOfLastWord(string a)
        {
            bool char_flag = false;
            int len = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(a[i]))
                {
                    char_flag = true;
                    len++;
                }
                else
                {
                    if (char_flag == true)
                    {
                        return len;
                    }
                }
            }
            return len;
        }
    }


    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            return AppHelper.lengthOfLastWord(s);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Solution s = new Solution();
            int k = s.LengthOfLastWord("hello world");
        }
    }
}
