using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/valid-anagram/submissions/
namespace Valid_Anagaram
{
    public static class Solution
    {
        public static bool IsAnagram(string a, string b)
        {
            return String.Concat(a.OrderBy(c => c)).Equals(String.Concat(b.OrderBy(c => c)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool isvalid = Solution.IsAnagram("anagram", "nagaram");
        }
    }
}
