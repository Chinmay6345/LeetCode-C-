using System;
using System.Collections.Generic;

namespace Index_equals_Value
{
    //https://www.algoexpert.io/questions/Index%20Equals%20Value
    public class Program1
    {
        public int IndexEqualsValue(int[] array)
        {
            Int32 leftIndex = 0;
            IList<int> lst = new List<int>();
            Int32 rightIndex = array.Length - 1;
            while (leftIndex <= rightIndex)
            {
                Int32 middleIndex = (leftIndex + rightIndex) / 2;
                Int32 middleValue = array[middleIndex];
                if (middleValue < middleIndex)
                {
                    leftIndex = middleIndex + 1;
                }
                else if ((middleValue == middleIndex) && (middleIndex == 0))
                {
                    return middleIndex;
                }
                else if ((middleValue == middleIndex) && (array[middleIndex - 1] < middleIndex - 1))
                {
                    return middleIndex;
                }
                else
                {
                    rightIndex = middleIndex - 1;
                }
            }
            return -1;
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
