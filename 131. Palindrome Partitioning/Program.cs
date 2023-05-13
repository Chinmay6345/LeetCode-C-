using System;
using System.Linq;
using System.Collections.Generic;

namespace _131._Palindrome_Partitioning
{
    //https://leetcode.com/problems/palindrome-partitioning/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IList<String>> lst = new List<IList<String>>();
            String s = "aab";
            int len = s.Length;
            AppHelper.PalindromePartition(s, 0, ref lst, new List<String>(), len);
            Console.ReadLine();
        }
    }

    public static class AppHelper
    {
        public static void PalindromePartition(String s, int index, ref List<IList<String>> lst, List<String> ds, int len)
        {
            if (index == len)
            {
                lst.Add(new List<String>(ds));
                return;
            }
            for (int i = index; i < len; i++)
            {
                if (IsPalindrome(s, index, i))
                {
                    ds.Add(s.Substring(index, i-index + 1));
                    PalindromePartition(s, i + 1, ref lst, ds, len);
                    ds.RemoveAt(ds.Count() - 1);
                }
            }
        }
        public static bool IsPalindrome(String s, int start, int end)
        {
            while (start <= end)
            {
                if (s[start] != s[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }
    }


    public class Solution
    {
        public IList<IList<string>> Partition(string s)
        {
            List<IList<String>> lst = new List<IList<String>>();
            int len = s.Length;
            AppHelper.PalindromePartition(s, 0, ref lst, new List<String>(), len);
            return lst;
        }
    }
}
