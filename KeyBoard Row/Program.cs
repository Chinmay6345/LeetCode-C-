using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/keyboard-row/
namespace KeyBoard_Row
{
    public static class AppHelper
    {
        public static String[] FindWords(string[] arr)
        {
            HashSet<Char> Set1 = new HashSet<char>("QWERTYUIOP".ToCharArray());
            HashSet<Char> Set2 = new HashSet<char>("ASDFGHJKL".ToCharArray());
            HashSet<Char> Set3 = new HashSet<char>("ZXCVBNM".ToCharArray());
            List<String> lst = new List<String>();
            for (Int32 i = 0; i < arr.Length; i++)
            {
                var current = arr[i].ToUpper();
                if ((current.All(g => Set1.Contains(g))))
                {
                    lst.Add(arr[i]);
                }
                else if ((current.All(g => Set2.Contains(g))))
                {
                    lst.Add(arr[i]);
                }
                else if ((current.All(g => Set3.Contains(g))))
                {
                    lst.Add(arr[i]);
                }
            }
            return lst.ToArray();
        }
    }
    public class Solution
    {
        public string[] FindWords(string[] words)
        {
            return AppHelper.FindWords(words);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
