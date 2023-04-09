using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _402._Remove_K_digits
{
    public static class AppHelper
    {
        public static string removeKdigits(string num, int k)
        {
          
            int n = num.Length;
            Stack<char> mystack=new Stack<char>();
            foreach (char c in num)
            {
                while (mystack.Any() && k > 0 && mystack.Peek() > c)
                { mystack.Pop(); k -= 1; }

                if (mystack.Count !=0 || c != '0')
                    mystack.Push(c);
            }

            //Now remove the largest values from the top of the stack
            while (mystack.Count() != 0 && k--> 0)
            {
                mystack.Pop();
            }
            if (mystack.Count()==0)
                return "0";

            List<String> lst = new List<String>(n);
            while (mystack.Any())
            {
                lst.Add(mystack.Peek().ToString());
                mystack.Pop();
            }
            lst.Reverse();
            return String.Join("", lst.Select(g=>g));
        }


        public static string RemoveKdigits_Approach2(string num, int k)
        {
            int n = num.Length;
            int x = k;
            Stack<string> mystack = new Stack<string>();
            foreach (char c in num)
            {
                while (mystack.Count > 0 && k > 0 && int.Parse(mystack.Peek().ToString()) > int.Parse(c.ToString()))
                {
                    mystack.Pop(); k -= 1;

                }
                if(mystack.Count==0 && c=='0')
                {
                    continue;
                }
                mystack.Push(c.ToString());
            }
            var arr = mystack.ToArray();
            Array.Reverse(arr);
            return string.Join("", arr);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppHelper.removeKdigits("112",1));
            Console.ReadLine();
        }
    }
}
