using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
namespace Kids_With_the_Greatest_Number_of_Candies
{
    public static class AppHelper
{
    public static IList<Boolean>lstCandies(Int32 [] candies,Int32 extra)
    {
        List<Boolean>lst=new List<Boolean>();
        Int32 max= candies.Max();
        foreach(Int32 item in candies)
        {
            if(item + extra >= max)
            {
                lst.Add(true);
            }
            else
            {
                lst.Add(false);
            }
        }
        return lst;
    }
}


public class Solution 
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        return AppHelper.lstCandies(candies,extraCandies);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
