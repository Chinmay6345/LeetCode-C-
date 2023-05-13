using System;
using System.Collections.Generic;

namespace G_Celebrity_Problem
{
    public static class GFG
    {
        // Person with 2 is celebrity
        static int[,] MATRIX = { { 0, 0, 1, 0 },
                            { 0, 0, 1, 0 },
                            { 0, 0, 0, 0 },
                            { 0, 0, 1, 0 } };

        // Returns true if a knows
        // b, false otherwise
        static bool knows(int a, int b)
        {
            bool res = (MATRIX[a, b] == 1) ?
                                         true :
                                         false;
            return res;
        }

        // Returns -1 if celebrity
        // is not present. If present,
        // returns id (value from 0 to n-1).
        public static int findCelebrity(int n)
        {
            Stack<int> st = new Stack<int>();
            int c;

            // Step 1 :Push everybody
            // onto stack
            for (int i = 0; i < n; i++)
            {
                st.Push(i);
            }

            while (st.Count > 1)
            {
                // Step 2 :Pop off top
                // two persons from the
                // stack, discard one
                // person based on return
                // status of knows(A, B).
                int a = st.Pop();
                int b = st.Pop();

                
                // Step 3 : Push the
                // remained person onto stack.
                if (knows(a, b))
                {
                    st.Push(b);
                }

                else
                    st.Push(a);
            }

            // If there are only two people
            // and there is no
            // potential candidate
            if (st.Count == 0)
                return -1;

            c = st.Pop();

            // Step 5 : Check if the last
            // person is celebrity or not
            for (int i = 0; i < n; i++)
            {
                // If any person doesn't
                //  know 'c' or 'a' doesn't
                // know any person, return -1
                Console.WriteLine(Environment.NewLine);
                Console.Write(c + " " + i);
                Console.WriteLine(Environment.NewLine);
                Console.Write(i + " " + c);
                if (i != c && (knows(c, i) ||
                              !knows(i, c)))
                {
                    
                    return -1;
                }
            }
            return c;
        }

    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(GFG.findCelebrity(4));
                Console.ReadLine();
            }
        }
    }
