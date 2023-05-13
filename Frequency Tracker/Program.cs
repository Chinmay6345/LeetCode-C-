using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            FrequencyTracker ft = new FrequencyTracker();
            ft.Add(5);
            ft.Add(4);
            ft.DeleteOne(6);
            ft.DeleteOne(4);
            ft.DeleteOne(7);
            Console.WriteLine(ft.HasFrequency(1)); // True
        }
    }
    public class FrequencyTracker
    {
        internal Dictionary<long, int> HashMap;
        int count = 0;
        public FrequencyTracker()
        {
            HashMap = new Dictionary<long, int>();
            count = 0;
        }

        public void Add(int number)
        {
            if (!HashMap.ContainsKey(number))
            {
                HashMap.Add(number, 1);
                if (count == 0)
                    count = 1;
                else
                    count++;
            }
            else
            {
                HashMap[number]++;
                count = HashMap[number];
            }

        }

        public void DeleteOne(int number)
        {
            if (HashMap.ContainsKey(number))
            {
                HashMap[number]--;
                count = HashMap[number];
                if (HashMap[number] == 0)
                {
                    HashMap.Remove(number);
                }
            }
        }

        public bool HasFrequency(int frequency)
        {

            return count == frequency;

        }
    }

}
