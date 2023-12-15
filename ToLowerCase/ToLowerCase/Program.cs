//https://leetcode.com/problems/to-lower-case/

Console.WriteLine(ToLowerCase("al&phaBET"));
static string ToLowerCase(string s)
{
    string result = string.Empty;
    foreach(char c in s)
    {
      
        if(c >= 'A' && c <= 'Z')
        {
            int capAscii = (int)c;
            int smallAscii = c + 32;
            char sm = (char)smallAscii;
            result = result + sm;
        }
        else
        {
            result += c;
        }
    }
    return result;

}
