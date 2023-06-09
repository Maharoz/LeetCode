using System;

namespace Palindrome
{

    //https://leetcode.com/problems/palindrome-number/
    class Program
    {
        static void Main(string[] args)
        {
            palindrome c = new palindrome();
           bool x= c.check(-121);
        }

        class palindrome {
            public int reminder,sum=0;
            public int temp;
            public bool check(int number)
            {
                temp = number;

                if (number < 0)
                {
                    return false;
                }
                while (number > 0)
                {
                    reminder = number % 10;

                    sum = (sum * 10) + reminder;

                    number = number / 10;
                }

                if (temp == sum)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

    }
}
