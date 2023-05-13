using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://leetcode.com/problems/longest-valid-parentheses/

namespace _32_Longest_Valid_Parentheses
{
    public static class AppHelper
    {
        public static Int32 LongestValidParentheses(String str)
        {
            int maxLength = 0;
            int n = str.Length;
            int openingCount = 0;
            int closingCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (str[i] == '(')
                {
                    openingCount++;
                }
                else
                {
                    closingCount++;
                }
                if (openingCount == closingCount)
                {
                    maxLength = Math.Max(maxLength, openingCount * 2);
                }
                else if (closingCount > openingCount)
                {
                    openingCount = 0;
                    closingCount = 0;
                }
            }
            openingCount = 0;
            closingCount = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (str[i] == '(')
                {
                    openingCount++;
                }
                else
                {
                    closingCount++;
                }
                if (openingCount == closingCount)
                {
                    maxLength = Math.Max(maxLength, openingCount * 2);
                }
                else if (closingCount < openingCount)
                {
                    openingCount = 0;
                    closingCount = 0;
                }
            }

            return maxLength;
        }

        public static Int32 LongestValidParentheses1(String str)
        {
            int maxLength = 0;
            int n = str.Length;
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            for (int i = 0; i < n; i++)
            {
                Char currentChar = str[i];
                if (currentChar == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count() == 0)
                    {
                        stack.Push(i);
                    }
                    else
                    {
                        maxLength = Math.Max(maxLength, i - stack.Peek());
                    }
                }
            }
            return maxLength;

        }
    }

    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            return AppHelper.LongestValidParentheses(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
