//https://leetcode.com/problems/longest-common-prefix/


static string LongestCommonPrefix(string[] strs)
{
    string s = strs[0];

  for(int i = 1; i < strs.Length; i++)
    {
        while (strs[i].IndexOf(s) != 0)
        {
            s=s.Substring(0,s.Length-1);    
        }
    }
  return s;
}