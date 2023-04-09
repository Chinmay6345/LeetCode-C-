using System;
using System.Collections.Generic;
namespace _735._Asteroid_Collision
{
    //https://leetcode.com/problems/asteroid-collision/description/
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] asteroids = { 5, 10, -5 };

            Console.ReadLine();
        }
    }
    public static class AppHelper
    {
        public static int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int asteroid in asteroids)
            {
                int k = asteroid;
                while (stack.Count != 0 && stack.Peek() > 0 & k < 0)
                {
                    int difference = stack.Peek() + k;
                    if (difference < 0)
                    {
                        stack.Pop();
                    }
                    else if (difference > 0)
                    {
                        k = 0;
                    }
                    else
                    {
                        k = 0;
                        stack.Pop();
                    }
                }
                if (k != 0)
                {
                    stack.Push(k);
                }
            }
            int[] output = stack.ToArray();
            Array.Reverse(output);
            return output;
        }
    }
}
