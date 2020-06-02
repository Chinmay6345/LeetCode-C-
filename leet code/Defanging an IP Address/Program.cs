using System;
//https://leetcode.com/problems/defanging-an-ip-address/
namespace Defanging_an_IP_Address
{
    public static class Solution
    {
        public static string DefangIPaddr(string address)
        {
            String defangIPAddress = String.Empty;
            defangIPAddress = address.Replace(".", "[.]");
            return defangIPAddress;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String s = Solution.DefangIPaddr("1.1.1.1");
        }
    }
}
