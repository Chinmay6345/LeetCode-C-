using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/excel-sheet-column-title/

namespace Excel_Sheet_Column_Title
{
    public static class AppHelper
    {
        public static string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;
            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }
            return columnName;
        }
    }

    public class Solution
    {
        public string ConvertToTitle(int n)
        {
            return AppHelper.GetExcelColumnName(n);
        }
    }
}
