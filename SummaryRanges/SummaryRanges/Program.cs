using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SummaryRanges
{
    //https://leetcode.com/problems/summary-ranges/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 0, 2, 3, 4, 6, 8, 9 };
            SummaryRanges(x);
        }

        static IList<string> SummaryRanges(int[] nums)
        {
            IList<string> res = new List<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                int start = nums[i];

                while (i + 1 < nums.Length && (nums[i + 1] - nums[i] == 1))
                {
                    i++;
                }

                if (start != nums[i])
                {
                    res.Add(string.Format("{0}->{1}", start, nums[i]));
                }
                else
                {
                    res.Add(start.ToString());
                }
            }
            return res;
           
        }

    }
}