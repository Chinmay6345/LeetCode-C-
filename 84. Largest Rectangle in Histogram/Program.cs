using System;
using System.Collections.Generic;

//https://leetcode.com/problems/largest-rectangle-in-histogram/

namespace _84._Largest_Rectangle_in_Histogram
{
    public static class AppHelper
    {
        public static int LargestRectangle(int[] heights)
        {
            var stack = new Stack<int>(); // keep increasing stack with index in it
            int len = heights.Length;
            int index = 0;
            int maxArea = 0;

            while (index < len)
            {
                if (stack.Count == 0 || heights[stack.Peek()] <= heights[index])
                {
                    stack.Push(index);
                    index++;
                }
                else
                {
                    // start processing the smallest bar
                    var tp = stack.Pop();
                    var area = heights[tp] * (stack.Count == 0 ? index : (index - stack.Peek() - 1));
                    maxArea = Math.Max(maxArea, area);
                }
            }

            while (stack.Count > 0)
            {
                var tp = stack.Pop();
                var area = heights[tp] * (stack.Count == 0 ? index : (index - stack.Peek() - 1));
                maxArea = Math.Max(maxArea, area);
            }

            return maxArea;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] heights = {2,1,5,6,2,3};
            Console.WriteLine(AppHelper.LargestRectangle(heights));
            Console.ReadLine();
        }
    }
}
