namespace find_the_middle_index_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            int[] array = { 2, 3, -1, 8, 4 };
            Console.WriteLine(FindMiddleIndex(array));
        }

        static int FindMiddleIndex(int[] nums)
        {
            int sumOfLeft = 0;

            int sumOfRight = 0;

            int result = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumOfLeft = sumOfLeft + nums[j];
                }

                for (int k = i + 1; k < nums.Length; k++)
                {
                    sumOfRight = sumOfRight + nums[k];
                }

                if (sumOfLeft == sumOfRight)
                {
                    result = i;
                    return result;
                }
                sumOfLeft = 0;
                sumOfRight = 0;
            }
            return result;
        }
    }
}