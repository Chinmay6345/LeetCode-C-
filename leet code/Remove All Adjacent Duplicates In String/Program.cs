using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
/*
Given a string S of lowercase letters, a duplicate removal consists of choosing two adjacent and equal letters, and removing them.

We repeatedly make duplicate removals on S until we no longer can.

Return the final string after all such duplicate removals have been made.  It is guaranteed the answer is unique.

 

Example 1:

Input: "abbaca"
Output: "ca"
Explanation: 
For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca". 
*/
namespace Remove_All_Adjacent_Duplicates_In_String
{
    public static class AppHelper
    {
        public static String RemoveConsecutiveElements(String input)
        {
            try
            {
                if (input.Length == 1)
                {
                    return input;
                }
                StringBuilder builder = new StringBuilder();
                builder.Append(input[0]);
                for (int i = 1; i < input.Length; i++)
                {
                    if (builder.Length == 0)
                    {
                        builder.Append(input[i]);
                        continue;
                    }
                    if (builder[builder.Length - 1] != input[i])
                    {
                        builder.Append(input[i]);
                    }
                    else
                    {
                        builder.Remove(builder.Length - 1, 1);
                    }
                }
                return Convert.ToString(builder);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    public class Solution
    {
        public string RemoveDuplicates(string S)
        {
            String result = "";
            try
            {
                result = AppHelper.RemoveConsecutiveElements(S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                result = "";
            }
            return result;
        }
    }
}
