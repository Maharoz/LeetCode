int[] x = { 1, 2,3 };
Solution s = new Solution();
var result = s.Subsets(x);
foreach (var i in result)
{
    Console.WriteLine(i);
}


public class Solution
{
	private IList<IList<int>> res = new List<IList<int>>();

	public IList<IList<int>> Subsets(int[] nums)
	{
		if (nums == null || nums.Length == 0)
			return res;

		Backtrack( 0, new List<int>(), nums);

		return res;
	}

	private void Backtrack( int i, List<int> cur, int[] nums)
	{
		res.Add(new List<int>(cur));

		if (nums.Length == i)
			return;

		for (int j = i; j < nums.Length; j++)
		{
			cur.Add(nums[j]);

			Backtrack( j + 1, cur,nums);

			cur.RemoveAt(cur.Count - 1);
		}
	}
}