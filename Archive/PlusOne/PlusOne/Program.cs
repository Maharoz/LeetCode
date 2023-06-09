using System;

namespace PlusOne
{

    //https://leetcode.com/problems/plus-one/
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,3 };
            plusOne(a);
        }

        static int[] plusOne(int[] digits)
        {
            int carry = 1;
            int currentValue = 0;

            for(int i = digits.Length - 1; i >= 0; i++)
            {
                currentValue = digits[i] + carry;
                digits[i] = currentValue % 10;
                carry = currentValue / 10;
            }
            if (carry != 0)
            {
                var increasedSizeArray = new int[(digits.Length + 1)];
                increasedSizeArray[0] = carry;
                Array.Copy(digits, 0, increasedSizeArray, 1, digits.Length);
                return increasedSizeArray;
            }

            return digits;
        }
    }
}
