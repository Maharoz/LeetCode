namespace KidsWithGreatestNumberOfCandies
{

    //https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            KidsWithCandies(candies, extraCandies);
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> result = new List<bool>();

            for (int i= 0; i<candies.Length ;i++)
            {
                candies[i] += extraCandies;

                int max = candies.Max();

                if (candies[i] == max)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }

                candies[i] -= extraCandies;
            }
            return result;
        }
    }
}
