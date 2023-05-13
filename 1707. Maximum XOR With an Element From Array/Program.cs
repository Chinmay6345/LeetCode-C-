using _421._Maximum_XOR_of_Two_Numbers_in_an_Array;
using System;
using System.Collections.Generic;
using System.Linq;
namespace _1707._Maximum_XOR_With_an_Element_From_Array
{
    public static class Solution
    {
        public static void MaximizeXor(int[] nums, int[][] queries)
        {
            int queriesLength = queries.Length;
            int[] ans = new int[queriesLength];
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < queriesLength; i++)
            {
                List<int>lst=new List<int>();
                lst.AddRange(new int[] { queries[i][0], queries[i][1], i});
                list.Add(lst);
            }
            list.Sort((a, b) =>
            {
                return a[1] - b[1];
            });
            int index = 0;
            Array.Sort(nums);
            Trie trie = new Trie();
            foreach (List<int> query in list)
            {
                while (index < nums.Length && nums[index] <= query[1])
                {
                    trie.Insert(nums[index]);
                    index++;
                }
                int tempAns = -1;
                if (index != 0)
                {
                    tempAns = trie.getMax(query[0]);
                }
                Console.WriteLine(tempAns);
                ans[query[2]] = tempAns;
            }

            //return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 3, 4 };
            int[][] queries =
            {
                new int[] { 3,2 },
                new int[] { 1,3 },
                new int[] { 5,6 }
            };
            Solution.MaximizeXor(nums, queries);
            Console.ReadLine();
        }
    }
}
