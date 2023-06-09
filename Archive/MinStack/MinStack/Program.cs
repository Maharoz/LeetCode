using System;

namespace MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            MinStack minStack = new MinStack();

        }



      
    }

    public class MinStack
    {
        int count;
        int[] items = new int[Int32.MaxValue];
        public MinStack()
        {
            count = 0;
        }

        public void Push(int val)
        {
            if (count == items.Length)
            {
                throw new Exception();
            }
            items[count++] = val;
        }

        public void Pop()
        {
            if (count == 0)
            {
                throw new Exception();
            }
            _ = items[--count];
        }

        public int Top()
        {
            if (count == 0)
            {
                throw new Exception();
            }
            return items[count - 1];
        }

        public int GetMin()
        {
            int temp = 0;
            foreach(int i in items)
            {
                if (i < temp)
                {
                    temp = i;
                }
            }

            return temp;
        }
    }
}
