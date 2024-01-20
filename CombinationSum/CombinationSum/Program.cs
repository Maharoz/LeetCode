namespace CombinationSum
{

    /https://leetcode.com/problems/combination-sum/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2,3,6,7 };
            IList<IList<int>> res = CombinationSum(array,7);

            // Print the generated subsets
            foreach (List<int> subset in res)
            {
                Console.WriteLine(string.Join(" ", subset));
            }
        }

        static void CalcSubset(int[] A, IList<IList<int>> res, List<int> subset, int index,int target)
        {
            if(target == 0)
            {
                res.Add(new List<int>(subset));
            }

            if(target<=0)
            {
                return;
            }
           

            for (int i = index; i < A.Length; i++)
            {

                subset.Add(A[i]);

                CalcSubset(A, res, subset, i, target - A[i]);
                subset.RemoveAt(subset.Count - 1);
            }
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<int> subset = new List<int>();
            IList<IList<int>> res = new List<IList<int>>();
            int index = 0;
            CalcSubset(candidates, res, subset, index, target);
            return res;
        }
    }
}
