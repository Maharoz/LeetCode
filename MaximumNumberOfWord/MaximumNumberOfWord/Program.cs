using System;

namespace MaximumNumberOfWord
{
    class Program
    {
        static void Main(string[] args)
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
