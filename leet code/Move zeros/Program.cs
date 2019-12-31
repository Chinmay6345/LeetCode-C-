using System;
using System.Collections.Generic;
using System.Linq;

namespace Move_zeros
{
    //https://leetcode.com/problems/move-zeroes/
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array =  { 0, 0};        
            Int32 zeros = Array.FindAll(array, e => e == 0).Count();
            List<Int32> lst = array.Where(element => element != 0).ToList();
            
            for (int j = 0; j < zeros; j++)
            {
                lst.Add(0);
            }
            for(int k=0;k<lst.Count;k++)
            {
                array[k] = lst[k];
            }
            Console.ReadLine();
        } 
    }
}
