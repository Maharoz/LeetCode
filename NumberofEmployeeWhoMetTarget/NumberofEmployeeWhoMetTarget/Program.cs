namespace NumberofEmployeeWhoMetTarget
{
    //https://leetcode.com/problems/number-of-employees-who-met-the-target/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            Array.Sort(hours);
            int number = hours.Where(h => h >= target).Count();
            return number;
        }
    }
}
