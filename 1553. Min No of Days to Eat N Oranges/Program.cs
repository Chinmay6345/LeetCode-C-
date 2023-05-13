using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/minimum-number-of-days-to-eat-n-oranges/

namespace _1553.Min_No_of_Days_to_Eat_N_Oranges
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int MinDays(int n)
        {
            Dictionary<int, int> cache = new Dictionary<int, int>();
            return dfs(n, cache);
        }
        private int dfs(int n, Dictionary<int, int> cache)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (cache.ContainsKey(n))
            {
                return cache[n];
            }
            int one = 1 + n % 2 + dfs(n / 2, cache);
            int two = 1 + n % 3 + dfs(n / 3, cache);
            cache[n] = Math.Min(one, two);
            return cache[n];

        }
    }
}
