//https://leetcode.com/problems/goal-parser-interpretation/

Interpret("G()(al)");
static string Interpret(string command)
{
    string result = string.Empty;

    for(int i =0;i<command.Length;i++)
    {
        if (command[i] == 'G')
       {
            result +='G';
       }
        if (command[i] == '(' && command[i + 1] == ')')
            result += "o";
        if (command[i] == '(' && command[i + 1] == 'a')
            result += "al";
    }

   

    return result;
}