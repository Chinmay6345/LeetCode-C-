using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string a = "abcd";
            string b = "bcda"; // bad daa a1b2c3 abc123

            bool p = String.Concat(a.OrderBy(c => c)).Equals(String.Concat(b.OrderBy(c => c)));

            if (p)
            {
                Console.WriteLine("yes");
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalSeconds);
            Console.ReadLine();
        }
    }
}
