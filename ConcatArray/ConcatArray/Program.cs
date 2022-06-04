
using System;

namespace ConcatArray
{
    class Program
    {
        //https://leetcode.com/problems/concatenation-of-array/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] GetConcatenation(int[] input)
        {
            int[] copy = new int[input.Length];
            int[] res = new int[input.Length + copy.Length];
            Array.Copy(input, copy, input.Length);
            input.CopyTo(res, 0);
            copy.CopyTo(res, input.Length);

            return res;
        }
    }
}
