using System;


//https://leetcode.com/problems/day-of-the-week/
/*
Given a date, return the corresponding day of the week for that date.

The input is given as three integers representing the day, month and year respectively.

Return the answer as one of the following values {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}.

 

Example 1:

Input: day = 31, month = 8, year = 2019
Output: "Saturday"
Example 2:

Input: day = 18, month = 7, year = 1999
Output: "Sunday"
Example 3:

Input: day = 15, month = 8, year = 1993
Output: "Sunday"
 

Constraints:

The given dates are valid dates between the years 1971 and 2100. 
     
     
*/


namespace Day_of_the_week
{
    public static class AppHelper
    {
        public static String Day(Int32 day, Int32 month, Int32 year)
        {
            DateTime dtime = new DateTime(year, month, day);
            return Convert.ToString(dtime.DayOfWeek);
        }
    }

    public class Solution
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            return AppHelper.Day(day, month, year);
        }
    }
}
