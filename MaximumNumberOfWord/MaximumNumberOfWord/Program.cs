using System;

namespace MaximumNumberOfWord
{

    //https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public int MostWordsFound(string[] sentences)
        {

            string[] res;

            int resSize = 0;



            for (int i = 0; i < sentences.Length; i++)
            {
                res = sentences[i].Split(" ");

                if (resSize < res.Length)
                {
                    resSize = res.Length;
                }

            }

            return resSize;
        }
    }
}
