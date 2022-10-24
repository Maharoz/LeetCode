//https://leetcode.com/problems/running-sum-of-1d-array/
int sum= 0;
int[] nums = {1,2,3,4};
int[] outPut = new int[nums.Length];

RunningSum(nums);

int[] RunningSum(int[] nums)
{
    for(int i= 0; i < nums.Length; i++)
    {
        for( int j= 0; j <= i; j++)
        {
             sum += nums[j];
        }

        outPut[i] = sum;
        sum = 0;
    }
    return outPut;
}