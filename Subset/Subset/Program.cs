namespace Subset
{

    //https://leetcode.com/problems/subsets/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            IList<IList<int>> resultList = new List<IList<int>>();
            backTrack(resultList, new List<int>(), nums, 0);
            Console.WriteLine(resultList);
        }

        private static void backTrack(IList<IList<int>> resultSets,List<int> tempSets, int[] nums,int start)
        {
            resultSets.Add(new List<int>(tempSets));

            for (int i = start; i < nums.Length; i++)
            {
                tempSets.Add(nums[i]);

                backTrack(resultSets, tempSets, nums, i + 1);
                tempSets.Remove(tempSets.Count() - 1);
            }
        }
    }
}