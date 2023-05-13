using System;
using System.Collections.Generic;


namespace Spiral_Matrix
{
    //https://leetcode.com/problems/spiral-matrix/
    //https://www.algoexpert.io/questions/Spiral%20Traverse

    public static class AppHelper
    {
        public static List<int> SpiralTraverse(int[,] array)
        {
            List<int> lst = new List<int>();
            int startRow = 0;
            int startCol = 0;
            int endRow = array.GetLength(0) - 1;
            int endCol = array.GetLength(1) - 1;
            while (startRow <= endRow && startCol <= endCol)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    lst.Add(array[startRow, col]);
                }
                for (int row = startRow + 1; row <= endRow; row++)
                {
                    lst.Add(array[row, endCol]);
                }
                for (int col = endCol - 1; col >= startCol; col--)
                {
                    if (startRow == endRow)
                    {
                        break;
                    }
                    lst.Add(array[endRow, col]);
                }
                for (int row = endRow - 1; row > startRow; row--)
                {
                    if (startCol == endCol)
                    {
                        break;
                    }
                    lst.Add(array[row, startCol]);
                }
                endRow--;
                startRow++;
                startCol++;
                endCol--;
            }
            return lst;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
