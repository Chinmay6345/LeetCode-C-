using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Address
{
    public static class AppHelper
    {
        internal static List<String> ValidIPAddress(String str)
        {
            List<String> lst = new List<string>();
            for (int i = 1; i < Math.Min(str.Length, 4); i++)
            {
                String[] ipAddress = { "", "", "", "" };
                ipAddress[0] = str.Substring(0, i - 0);

                if (!isValidPart(ipAddress[0]))
                {
                    continue;
                }

                for (int j = i + 1; j < i + Math.Min(str.Length - i, 4); j++)
                {
                    ipAddress[1] = str.Substring(i, j - i);
                    if (!isValidPart(ipAddress[1]))
                    {
                        continue;
                    }


                    for (int k = j + 1; k < j + Math.Min(str.Length - j, 4); k++)
                    {
                        ipAddress[2] = str.Substring(j, k - j);
                        ipAddress[3] = str.Substring(k);
                        if (isValidPart(ipAddress[2]) && isValidPart(ipAddress[3]))
                        {
                            lst.Add(join(ipAddress));
                        }
                    }
                }

            }
            return lst;
        }

        private static String join(String [] strings)
        {
            StringBuilder builder = new StringBuilder();
            for(int i=0;i<strings.Length;i++)
            {
                builder.Append(strings[i]);
                if( i < strings.Length-1)
                {
                    builder.Append(".");
                }
            }
            return builder.ToString();
        }

        private static bool isValidPart(String str)
        {
            int toInt = Convert.ToInt32(str);
            if (toInt > 255)
                return false;
            return str.Length == toInt.ToString().Length;
        }
    }

   
    public class A
    {
        public A()
        {
            Console.WriteLine('a');
        }

        public A(int a)
        {
            Console.WriteLine("a parameter");
        }
    }


    class B : A
    {
        public B()
        {
            
            
                Console.WriteLine('b');
            
        }

        public B(int d,int c)
        {
            Console.WriteLine("b parameter 1");
        }

        public B(int a) : this (10,0)
        {
            Console.WriteLine("b parameter");
        }

        static void Main(string[] args)
        {
            ///A a = new B(0);
            //A a = new B(1);
            Console.ReadLine();

            //ad comment

        }
    }
}
