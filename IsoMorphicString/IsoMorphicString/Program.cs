using static System.Reflection.Metadata.BlobBuilder;

namespace IsoMorphicString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "badc";
            string t = "baba";
            bool result=IsIsomorphic(s, t);
            Console.WriteLine(result);
        }

        public static bool IsIsomorphic(string s, string t)
        {
            bool result = true;
       

            Stack<char> stackS = new Stack<char>();
            Stack<char> stackT = new Stack<char>();
            Dictionary<char, char> tracker = new Dictionary<char, char>();

            if (s.Length != t.Length)
            {
                return false;
            }
            foreach (char c in s.ToCharArray())
            {
                stackS.Push(c);
            }

            foreach (char c in t.ToCharArray())
            {
                stackT.Push(c);
            }

            while (stackS.Count > 0 && stackT.Count > 0)
            {
                if (tracker.ContainsKey(stackS.Peek()))
                {
                    char value = tracker[stackS.Peek()];
                    if (value != stackT.Peek())
                    {
                        result = false;
                        return result;
                    }
                    else
                    {
                        stackS.Pop();
                        stackT.Pop();
                    }
                }
                else
                {
                    foreach (KeyValuePair<char, char> b in tracker)
                    {
                        if(b.Value == stackT.Peek())
                        {
                            char myKey = tracker.FirstOrDefault(x => x.Value == stackT.Peek()).Key;
                            if(myKey != stackS.Peek())
                            {
                                result = false;
                                return result;
                            }
                        }

                    }
                        tracker.Add(stackS.Pop(), stackT.Pop());
                }

            }

            return result;
        }
    }
}