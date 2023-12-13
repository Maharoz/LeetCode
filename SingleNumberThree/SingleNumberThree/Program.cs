namespace SingleNumberThree
{
    //https://leetcode.com/problems/single-number-iii/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            int[] x =
            {
                1,2,1,3,2,5
            };
            SingleNumber(x);
        }

        public static int[] SingleNumber(int[] nums)
        {

            List<int> list = new List<int>();
            foreach (int i in nums)
            {
                if (list.Contains(i))
                {
                    list.Remove(i);
                }
                else
                {
                    list.Add(i);
                }
            }

            return list.ToArray();
        }
    }
}
