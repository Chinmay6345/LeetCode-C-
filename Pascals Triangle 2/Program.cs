using System;
using System.Collections.Generic;
using System.Linq;

namespace Pascals_Triangle_2
{
    //https://leetcode.com/problems/pascals-triangle-ii/
    public static class Solution
    {
        public static IList<int> Generate(int numRows)
        {
            List<Int32> output = new List<Int32>();
            output.Add(1);
            for (int i = 1; i <= numRows; i++)
            {
                List<Int32> current_row = new List<int>();
                current_row.Add(1);
                for (int j = 1; j < i; j++)
                {
                    Console.WriteLine(output[j - 1] + " " + output[j]);
                    int k = output[j - 1] + output[j];
                    current_row.Add(k);
                }
                current_row.Add(1);
                output = current_row;
            }
            return output; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = Solution.Generate(1);
            Console.ReadLine();
        }
    }
}
