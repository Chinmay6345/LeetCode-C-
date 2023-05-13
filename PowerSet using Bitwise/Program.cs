using System;

namespace PowerSet_using_Bitwise
{
    internal class Program
    {
        static void printPowerSet(String str)
        {
            int n = str.Length;

            int powSize = (int)Math.Pow(2, n);

            for (int counter = 0; counter < powSize; counter++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((counter & (1 << j)) != 0)
                        Console.Write(str[j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            String str = "abc";
            printPowerSet(str);
            Console.ReadLine();
        }
    }
}
