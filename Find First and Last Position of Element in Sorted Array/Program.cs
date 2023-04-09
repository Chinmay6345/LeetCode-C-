using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {5,7,7,8,8,10 };
            List<int> lst = new List<int>();
            var t = array.Select((value, index) => new { value, index }).Where(a =>a.value==8).Select(a => a.index);
            var s = t.ElementAt(0);
            Console.ReadLine();
        }
    }
}
