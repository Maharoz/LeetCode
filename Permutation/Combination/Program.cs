namespace Combination
{

    //https://leetcode.com/problems/permutations/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            IList<IList<int>> res = Permute(nums);

        }

        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> resultList = new List<IList<int>>();
            backtrack(resultList, new List<int>(), nums);
            return resultList;
        }
        private static void backtrack(IList<IList<int>> resultList, List<int> tempList, int[] nums)
        {
            if (tempList.Count == nums.Length)
            {
                resultList.Add(new List<int>(tempList));
                return;
            }

            foreach (int number in nums)
            {
                if (tempList.Contains(number))
                    continue;

                tempList.Add(number);
                backtrack(resultList, tempList, nums);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
