using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://leetcode.com/problems/excel-sheet-column-number/
namespace Excel_Sheet_Column_Number
{
    public static class AppHelper
    {
        public static Int32 ColumnLetterToColumnIndex(string columnLetter)
        {
            columnLetter = columnLetter.ToUpper();
            int sum = 0;

            for (int i = 0; i < columnLetter.Length; i++)
            {
                sum *= 26;
                sum += (columnLetter[i] - 'A' + 1);
            }
            return sum;
        }
    }


    public class Solution
    {
        public Int32 TitleToNumber(string s)
        {
            return AppHelper.ColumnLetterToColumnIndex(s);
        }
    }
}
