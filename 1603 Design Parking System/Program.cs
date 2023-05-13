using System;

namespace _1603_Design_Parking_System
{
    public class ParkingSystem
    {

        public Int32 big;
        public Int32 medium;
        public Int32 small;
        public ParkingSystem(int big, int medium, int small)
        {
            this.big = big;
            this.medium = medium;
            this.small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    return --big >= 0;
                case 2:
                    return --medium >= 0;
                default:
                    return --small >= 0;


            }
        }
    }

    /**
     * Your ParkingSystem object will be instantiated and called as such:
     * ParkingSystem obj = new ParkingSystem(big, medium, small);
     * bool param_1 = obj.AddCar(carType);
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
