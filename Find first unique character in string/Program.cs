using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/first-unique-character-in-a-string/
/*
Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

Examples:

s = "leetcode"
return 0.

s = "loveleetcode",
return 2.
*/

namespace Find_first_unique_character_in_string
{
    public static class AppHelper
    {
        public static Int32 FirstNonRepetitiveWord(String str)
        {
            Dictionary<Char, Int32> dict = new Dictionary<Char, Int32>();
            for (Int32 i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    dict[str[i]]++;
                }
                else
                {
                    dict[str[i]] = 1;
                }
            }
            IEnumerable<Char> UniqueChar = dict.Where(a => a.Value == 1).Select(a => a.Key);
            if (UniqueChar.Count() > 0)
            {
                return Array.IndexOf(str.ToCharArray()
                            , dict.Where(a => a.Value == 1).Select(a => a.Key).FirstOrDefault());
            }
            else
            {
                return -1;
            }
        }
    }
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            return AppHelper.FirstNonRepetitiveWord(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
