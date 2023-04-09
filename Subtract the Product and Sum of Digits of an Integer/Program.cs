using System;
//https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
namespace Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
{
    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            Int32 multiply = 1;
            Int32 sum = 0;
            foreach (Char item in n.ToString())
            {
                multiply = multiply * (int)Char.GetNumericValue(item);
                sum = sum + (int)Char.GetNumericValue(item);
            }
            Int32 difference = multiply - sum;
            return difference;
        }
    }
}
