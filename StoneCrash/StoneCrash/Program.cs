using System.Diagnostics.CodeAnalysis;

namespace StoneCrash
{

    //https://leetcode.com/problems/last-stone-weight/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] x = { 2, 7, 4, 1, 9, 1 };
            LastStoneWeight(x);
        }

        static int LastStoneWeight(int[] stones)
        {
            var q = new PriorityQueue<int,int>(stones.Select(x => (x,-x)));


            while (q.Count > 1)
            {
                int a = q.Dequeue()-q.Dequeue();
                if (a != 0) q.Enqueue(a, -a);
                
            }
            return (q.Count == 0 ? 0:q.Peek());
        }
    }
}
