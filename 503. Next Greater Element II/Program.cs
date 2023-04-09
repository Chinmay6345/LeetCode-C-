using System;
using System.Collections.Generic;
namespace _503._Next_Greater_Element_II
{
    //https://leetcode.com/problems/next-greater-element-ii/description/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int[] NextGreaterElements(int[] nums)
        {
            int n = nums.Length;
            int[] output = new int[n];
            Array.Fill(output, -1);
            int twice = n * 2;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < twice; i++)
            {
                while (stack.Count != 0 && nums[stack.Peek()] < nums[i % n])
                {
                    output[stack.Pop()] = nums[i % n];
                }
                if (i < n)
                {
                    stack.Push(i);
                }
            }
            return output;
        }
    }
}
