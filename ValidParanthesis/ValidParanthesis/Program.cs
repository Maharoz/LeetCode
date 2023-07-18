using System.Linq;

namespace ValidParanthesis
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			bool res = IsValid("]");
		}

		public static bool IsValid(string s)
		{
			Stack<char> stack = new Stack<char>();
			char[] chars = s.ToCharArray();
			foreach (char c in chars)
			{
				if (c == '(' || c == '{' || c == '[')
				{
					stack.Push(c);
				}
				else
				{
					if ( c == ')')
					{
						if (stack.Count > 0 &&  stack.Peek() == '(')
						{
							stack.Pop();
						}
						else
						{
							return false;
						}
					}else if ( c == '}')
					{
						if (stack.Count > 0 &&  stack.Peek() == '{')
						{
							stack.Pop();
						}
						else
						{
							return false;
						}
					}
					else if ( c == ']')
					{
						if (stack.Count > 0 && stack.Peek() == '[')
						{
							stack.Pop();
						}
						else
						{
							return false;
						}
					}
				}
			}
			return stack.Count==0?true:false;
		}
	}
}