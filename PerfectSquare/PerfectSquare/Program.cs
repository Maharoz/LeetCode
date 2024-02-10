namespace PerfectSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumSquares(5);
        }

        public static int solveMemoization(int n, int[] dpArray) {
            if (n == 0) return 0;

            if (dpArray[n] != -1)
            {
                return dpArray[n];
            }
            int ans = n;
            for (int i = 1; i * i <= n; i++)
            {
                ans = Math.Min(ans,1+solveMemoization(n-(i*i), dpArray));

            }
            dpArray[n]  = ans;
            return dpArray[n];

        }
        public static int NumSquares(int n)
        {
            int[] arr = new int[n+1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            return solveMemoization(n, arr);
        }
    }
}
