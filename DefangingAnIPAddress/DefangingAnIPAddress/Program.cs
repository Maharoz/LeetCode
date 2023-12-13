namespace DefangingAnIPAddress
{
    //https://leetcode.com/problems/defanging-an-ip-address/
    internal class Program
    {
        static void Main(string[] args)
        {
            DefangIPaddr("1.1.1.1");
        }

        public static string DefangIPaddr(string address)
        {
            string result =address.Replace(".", "[.]");
            return result;
        }
    }
}
