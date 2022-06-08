using System;

namespace DefangingAnIPAddress
{
    //https://leetcode.com/problems/defanging-an-ip-address/
    class Program
    {
        static void Main(string[] args)
        {
           
        }


        public string DefangIPaddr(string address)
        {
            address = address.Replace(".", "[.]");

            return address;
        }
    }
}
