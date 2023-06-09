﻿// https://leetcode.com/problems/subsets/

int[] x = { 1, 2};
Solution s = new Solution();
s.Subsets(x);
public  class Solution
{
    private IList<IList<int>> res = new List<IList<int>>();

    public IList<IList<int>> Subsets(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return res;

        Backtrack(nums, 0, new List<int>());

        return res;
    }

    private void Backtrack(int[] nums, int i, List<int> cur)
    {
        res.Add(new List<int>(cur));

        if (nums.Length == i)
            return;

        for (int j = i; j < nums.Length; j++)
        {
            cur.Add(nums[j]);

            Backtrack(nums, j + 1, cur);

            cur.RemoveAt(cur.Count - 1);
        }
    }
}