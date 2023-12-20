namespace AddDigits
{

    //https://leetcode.com/problems/add-digits/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static int AddDigits(int num)
        {
            int result = 0;
            if (num == 0)
            {
                result = 0;
            }
            else if (num % 9 == 0)
            {
                result = 9;
            }
            else
            {
                result = num % 9;
            }

            return result;

        }
    }
  
}
