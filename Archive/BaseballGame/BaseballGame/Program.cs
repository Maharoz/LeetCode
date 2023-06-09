using System;
using System.Collections.Generic;

namespace BaseballGame
{

    //https://leetcode.com/problems/baseball-game/submissions/
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            string[] a = { "5", "-2", "4", "C", "D", "9", "+", "+" };
            Stack<int> stack = new Stack<int>();

            foreach (string x in a)
            {
                if (x != "C" && x != "D" && x != "+")
                {
                    stack.Push(Convert.ToInt32(x));
                }
                else if (x == "C")
                {
                    stack.Pop();
                }
                else if (x == "D")
                {
                    int peakedNum = stack.Peek() * 2;
                    stack.Push(peakedNum);
                }
                else if (x == "+")
                {
                    int popOne = stack.Pop();
                    int popTwo = stack.Pop();


                    stack.Push(popTwo);
                    stack.Push(popOne);
                   

                    stack.Push(popOne + popTwo);
                }
            }


            foreach(int i in stack)
            {
               res = res + i;
            }

        }
    }
}
