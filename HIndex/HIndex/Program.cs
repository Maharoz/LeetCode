namespace HIndex
{

    //https://leetcode.com/problems/h-index/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 9,8,5,4,2};
            HIndex(x);
        }

        public static int HIndex(int[] citations)
        {
            Array.Sort(citations);
            Array.Reverse(citations);

            int hIndex = 0;
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] >= i + 1)
                {
                    hIndex = i + 1;
                }
                else
                {
                    break;
                }
            }

            return hIndex;
        }
    }
}
