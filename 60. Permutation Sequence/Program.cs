using System;
using System.Linq;
using System.Collections.Generic;
namespace _60._Permutation_Sequence
{
    //https://leetcode.com/problems/permutation-sequence/
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int k = 17;
            string output = AppHelper.getPermutation(n, k);
            Console.ReadLine();
        }
    }
    public static class AppHelper
    {
        public static String getPermutation(int n, int k)
        {
            int fact = 1;
            List<Int32> numbers = new List<Int32>();
            for (int i = 1; i < n; i++)
            {
                fact = fact * i;
                numbers.Add(i);
            }
            numbers.Add(n);
            String ans = "";
            k = k - 1;
            while (true)
            {
                if (k != 0)
                {
                    ans = ans + "" + numbers[k / fact];
                }
                else
                {
                    ans = ans + "" + numbers[0];

                }
                numbers.Remove(k==0? 0 :k / fact);
                if (numbers.Count() == 0)
                {
                    break;
                }

                    k = k == 0 ? 0:  k % fact;
                fact = fact==0?0: fact / numbers.Count();
            }
            return ans;
        }
    }
}
