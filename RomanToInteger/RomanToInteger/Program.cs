namespace RomanToInteger
{

    //https://leetcode.com/problems/roman-to-integer/
    internal class Program
	{
		static void Main(string[] args)
		{
			RomanToInt("MCMXCIV");
		}

		public static int RomanToInt(string s)
		{
			Dictionary<char,int> map = new Dictionary<char,int>();
			map.Add('I', 1);
			map.Add('V', 5);
			map.Add('X', 10);
			map.Add('L', 50);
			map.Add('C', 100);
			map.Add('D', 500);
			map.Add('M', 1000);	
			int result = 0;
            char[] chars = s.ToCharArray();

			for(int i = 0; i <= s.Length - 1; i++)
			{
				int nextcurrentVal = 0;

                 int currentVal=map[s[i]];
				if (s.Length-1 != i)
				{
                     nextcurrentVal = map[s[i + 1]];
				}
				else { nextcurrentVal = 0; }
				

                if (currentVal < nextcurrentVal)
				{
					int x = nextcurrentVal - currentVal;
                    result = result + x;
					i++;
				}
				else
				{
                    result = result + currentVal;
                }
				
			}
			return result;

		}
		
	}
}