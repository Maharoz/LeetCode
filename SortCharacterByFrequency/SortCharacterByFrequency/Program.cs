namespace SortCharacterByFrequency
{

    //https://leetcode.com/problems/sort-characters-by-frequency/
    internal class Program
    {
        static void Main(string[] args)
        {
            FrequencySort("cccaaa");
        }

        public static string FrequencySort(string s)
        {
            string result=string.Empty;
            int[] asciiValArr= new int[s.Length];
            Dictionary<string,int> dic = new Dictionary<string,int>();

           for(int i = 0; i < asciiValArr.Length; i++)
            {
                asciiValArr[i] = s[i];
            }



            // Use LINQ to group elements by their frequency
            int[] grouped = asciiValArr.GroupBy(x => x)
                              .OrderByDescending(g => g.Count())
                              .SelectMany(g => g).ToArray();

       


            for (int i = 0; i < grouped.Length; i++)
           {
                result=result + Convert.ToChar(grouped[i]);
           }

            return result;
        }
    }
}
