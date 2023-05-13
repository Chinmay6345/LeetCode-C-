using System;
using System.Linq;
using System.Collections.Generic;

namespace Pascals_triangle
{
    //https://leetcode.com/problems/pascals-triangle/
    public static  class Solution
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if(numRows==0)
            {
                return result;
            }
            result.Add(new List<int>() { 1 });
            for(int i=1;i<numRows;i++)
            {
                List<Int32> prev_row = result.ElementAt(i - 1).ToList();
                List<Int32> current_row = new List<int>();
                current_row.Add(1);
                for(int j=1;j<i;j++)
                {
                    Console.WriteLine(prev_row[j - 1] + " " + prev_row[j]);
                    int k = prev_row[j - 1] + prev_row[j];
                    current_row.Add(k);
                }
                current_row.Add(1);
                result.Add(current_row);
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = Solution.Generate(5);
            Console.ReadLine();
        }
    }
}
