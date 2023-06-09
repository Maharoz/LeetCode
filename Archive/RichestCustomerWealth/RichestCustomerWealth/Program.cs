using System;

namespace RichestCustomerWealth
{
    class Program
    {

        //https://leetcode.com/problems/richest-customer-wealth/
        static void Main(string[] args)
        {
            //  int a[3][3] = { { 1, 2, 3 },{ 3, 2, 1 } }

            int[][] a = new int[3][];
            a[0] = new int[2];
            a[1] = new int[2];
            a[2] = new int[2];

            a[0][0] = 1;
            a[0][1] = 5;

            a[1][0] = 7;
            a[1][1] = 3;

            a[2][0] = 3;
            a[2][1] = 5;
            richestCustomer(a);
        }

        static void richestCustomer(int[][] accounts)
        {
            int highest = 0;

            for(int i = 0; i < accounts.Length; i++)
            {
                int temp = 0;
                for(int j = 0; j < accounts[0].Length; j++)
                {
                    temp = temp + accounts[i][j];
                    if (temp > highest)
                    {
                        highest = temp;
                    }
                    
                }
            }
        }
    }
}
