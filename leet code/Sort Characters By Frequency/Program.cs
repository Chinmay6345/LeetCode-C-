using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/sort-characters-by-frequency/
/*
 Given a string, sort it in decreasing order based on the frequency of characters.

Example 1:

Input:
"tree"

Output:
"eert"

Explanation:
'e' appears twice while 'r' and 't' both appear once.
So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
Example 2:

Input:
"cccaaa"

Output:
"cccaaa"

Explanation:
Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
Note that "cacaca" is incorrect, as the same characters must be together.
Example 3:

Input:
"Aabb"

Output:
"bbAa"

Explanation:
"bbaA" is also a valid answer, but "Aabb" is incorrect.
Note that 'A' and 'a' are treated as two different characters.
*/
namespace Sort_Characters_By_Frequency
{
    public static class AppHelper
    {
        public static String SortCharacters(String str)
        {
            if (str.Length == 1)
            {
                return str;
            }
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
            StringBuilder builder = new StringBuilder();
            var Chars = dict.OrderByDescending(a => a.Value);
            foreach (var i in Chars)
            {
                for (int j = 0; j < i.Value; j++)
                {
                    builder.Append(i.Key);
                }
            }
            return Convert.ToString(builder);
        }
    }

    public class Solution
    {
        public string FrequencySort(string s)
        {
            if (!String.IsNullOrEmpty(s))
            {
                return AppHelper.FirstNonRepetitiveWord(s);
            }
            else
            {
                return String.Empty;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
