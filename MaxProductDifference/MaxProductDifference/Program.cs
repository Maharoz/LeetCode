// See https://aka.ms/new-console-template for more information
//https://leetcode.com/problems/maximum-product-difference-between-two-pairs/
int[] a =
{
    4,2,5,9,7,4,8
};
Console.WriteLine(MaxProductDifference(a));


 static int MaxProductDifference(int[] nums)
{
    int result =0;
    Array.Sort(nums);

    int x = nums[0];
    int y = nums[1];

    int a = nums[nums.Length -1];
    int b = nums[nums.Length -2];

    return  (b*a) - (x * y) ;
}
