using System;
using System.Linq;
using System.Collections.Generic;
namespace _4_Sum
{
    //https://leetcode.com/problems/4sum/

    public static class AppHelper
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            Dictionary<int, List<List<int>>> allPairSums = new Dictionary<int, List<List<int>>>();
            List<IList<int>> lst_f_lst = new List<IList<int>>();
            for (int i = 1; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int currentSum = nums[i] + nums[j];
                    int difference = target - currentSum;
                    if (allPairSums.ContainsKey(difference))
                    {
                        foreach (var pair in allPairSums[difference])
                        {
                            List<int> lst = new List<int>() { pair[0], pair[1], nums[i], nums[j] };
                            lst_f_lst.Add(lst);
                        }
                    }
                }
                for(int k=0;k<i;k++)
                {
                    int CSum = nums[i] + nums[k];
                    List<int> pairs = new List<int>() { nums[i], nums[k] };
                    if (!allPairSums.ContainsKey(CSum))
                    {
                        List<List<int>> group = new List<List<int>>();
                        group.Add(pairs);
                        allPairSums.Add(CSum,group);
                    }
                    else
                    {
                        allPairSums[CSum].Add(pairs);
                    }
                }
            }
            return lst_f_lst;
        }
        class Program
        {
            static void Main(string[] args)
            {
                int[] nums = {2,2,2,2,2 };
                int target = 8;
                var result = AppHelper.FourSum(nums, target);
                Console.ReadLine();
            }
        }
    }
}
