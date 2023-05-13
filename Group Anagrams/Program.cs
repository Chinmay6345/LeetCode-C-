using System;
using System.Linq;
using System.Collections.Generic;

namespace Group_Anagrams
{
    //https://leetcode.com/problems/group-anagrams/
    //Tc O(w*nlogn)
    //Sc O(w*n) =>w is the number of words and n is length of longest word
    public static class AppHelper
    {
        public static IList<IList<String>> GroupAnagrams(string[] strs)
        {
            Dictionary<String, IList<String>> valuePairs = new Dictionary<string, IList<String>>();
            foreach(String word in strs)
            {
                Char[] arr = word.ToCharArray();
                Array.Sort(arr);
                String sortedWord = new string(arr);
                if(valuePairs.ContainsKey(sortedWord))
                {
                    valuePairs[sortedWord].Add(word);
                }
                else
                {
                    valuePairs[sortedWord] = new List<String>() { word };
                }
            }
            return valuePairs.Values.ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String [] arr ={"eat", "tea", "tan", "ate", "nat", "bat"};
            var result = AppHelper.GroupAnagrams(arr);
            Console.ReadLine();
        }
    }
}
