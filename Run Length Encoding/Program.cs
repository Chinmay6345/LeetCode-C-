using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Length_Encoding
{
    public static class AppHelper
    {
        public static String RunLenghtEncoding(String str)
        {
            StringBuilder builder = new StringBuilder();
            Int32 currentLength = 1;
            for(Int32 i=1;i<str.Length;i++)
            {
                Char currentChar = str[i];
                Char prevChar = str[i - 1];
                if(currentChar == prevChar || currentLength==9)
                {
                    builder.Append(currentLength.ToString());
                    builder.Append(prevChar.ToString());
                    currentLength = 0;
                }
                currentLength++;
            }
            builder.Append(currentLength.ToString());
            builder.Append(str[str.Length-1].ToString());
            return builder.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String str = "AAAAAAAAAAAAABBCCCCDD";
            String newStr = AppHelper.RunLenghtEncoding(str);

            Console.ReadLine();
        }
    }
}
