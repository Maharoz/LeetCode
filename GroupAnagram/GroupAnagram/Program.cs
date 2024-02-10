using System.Collections.Generic;
using System.Diagnostics.Metrics;
//https://leetcode.com/problems/group-anagrams/
namespace GroupAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string[] s = new string[]
            {
                "eat","tea","tan","ate","nat","bat",
               //"a"
            };

            GroupAnagrams(s);
        }

        //public static IList<IList<string>> GroupAnagrams(string[] strs)
        //{
        //    List<IList<string>> result = new List<IList<string>>();
        //    for (int i = 0; i < strs.Length; i++)
        //    {
        //        bool isExists = result != null && result?.FirstOrDefault(innerList => innerList.Contains(strs[i]))?.Count() > 0;

        //        if (!isExists)
        //        {
        //            List<string> list = new List<string>();
        //            list.Add(strs[i]);
        //            int[] master = new int[26];
        //            foreach (char c in strs[i].ToCharArray())
        //            {
        //                int index = c - 97;
        //                master[index]++;
        //            }
        //            for (int j = i+1; j < strs.Length; j++)
        //            {
        //                int[] asc = new int[26];
        //                Array.Copy(master, asc, master.Length);
        //                if (strs[i].Length == strs[j].Length)
        //                {

        //                    foreach (char c in strs[j].ToCharArray())
        //                    {
        //                        int index = c -97;
        //                        asc[index]--;
        //                    }
        //                    if (!asc.Any(x => x > 0))
        //                    {
        //                        list.Add(strs[j]);
        //                    }
        //                }
        //            }
        //            result.Add(list);
        //        }

        //    }

        //    return result;

        //}

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> result = new List<IList<string>>();
            List<int[]> listOfArrays = new List<int[]>();
            Dictionary<string, List<int>> groupDictionary = new Dictionary<string, List<int>>();

            for (int i = 0; i < strs.Length; i++)
            {
                int[] master = new int[26];
                foreach (char c in strs[i].ToCharArray())
                {

                    int index = c - 97;
                    master[index]++;

                }
                listOfArrays.Add(master);
                string key = string.Join(",", master); // Convert array to string for dictionary key

                if (groupDictionary.ContainsKey(key))
                {
                    groupDictionary[key].Add(i);
                }
                else
                {
                    groupDictionary[key] = new List<int> { i };
                }
            }


            foreach (var group in groupDictionary.Values)
            {
                result.Add(group.Select(index => strs[index]).ToList());
            }

            return result;

        }
    }
}
