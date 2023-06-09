namespace RomanToInteger
{
    //https://leetcode.com/problems/roman-to-integer/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        static int RomanToInt(string s)
        {
           
            Dictionary<Char, int> map = new Dictionary<Char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            int result = map[s.ToCharArray()[s.Length-1]];

            for(int i = s.Length - 2; i >= 0; i--)
            {
                if(map[s.ToCharArray()[i]]< map[s.ToCharArray()[i + 1]])
                {
                    result -= map[s.ToCharArray()[i]];
                }
                else
                {
                    result += map[s.ToCharArray()[i]];
                }
            }

            return result;
        }
    }
}