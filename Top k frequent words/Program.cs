using System;
using System.Collections.Generic;
using System.Linq;

namespace Top_k_frequent_words
{
    public static class Solution
    {
        public static IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<String, Int32> dictionary = new Dictionary<String, Int32>();
            foreach (var p1 in words)
            {
                if (dictionary.ContainsKey(p1))
                    dictionary[p1]++;
                else
                    dictionary[p1] = 1;
            }
            List<String> lstString = dictionary.OrderByDescending(d => d.Value)
                           .ThenBy(d => d.Key)
                           .Take(k)
                           .Select(d => d.Key)
                           .ToList();
            return lstString;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = Solution.TopKFrequent(new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 2);
        }
    }
}
