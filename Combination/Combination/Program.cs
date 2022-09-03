using System;
using System.Collections.Generic;

namespace Combination
{

    //https://leetcode.com/problems/combinations/
    class Program
    {
        public static IList<IList<int>> Combine(int n, int k)
        {

            List<IList<int>> res = new List<IList<int>>();
            backtracking(1, n, k, new List<int>(), res);
            return res;
        }

        private static void backtracking(int start, int n, int k, List<int> list, List<IList<int>> res)
        {
            if (k == 0)
            {
                res.Add(new List<int>(list));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                list.Add(i);
                backtracking(i + 1, n, k - 1, list, res);
                list.RemoveAt(list.Count - 1);
            }
        }

        static void Main(string[] args)
        {
            Combine(4, 2);
        }
    }
}
