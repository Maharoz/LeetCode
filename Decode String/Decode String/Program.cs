// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

DecodeString("3[a]2[bc]");

string DecodeString(string s)
{
   string result = string.Empty;
   Stack<string> elmentStack = new Stack<string>();
    Stack<int> multiplierStack = new Stack<int>();

    foreach(char c in s)
    {
        if (char.IsDigit(c))
        {
            multiplierStack.Push(c);
        }
        else
        {
            elmentStack.Push(c.ToString());
        }
    }
    return result;
}