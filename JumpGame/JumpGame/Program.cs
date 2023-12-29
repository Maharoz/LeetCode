namespace JumpGame
{
    internal class Program
    {

        //https://leetcode.com/problems/jump-game/
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 1, 0, 4 };
            CanJump(nums);
        }

        public static bool CanJump(int[] nums)
        {
            int reachableIndex=nums.Length-1;
            int pointerIndex = nums.Length - 2;
            for (int i=nums.Length-1; i>0; i--)
            {
                
                if (nums[pointerIndex] >0 &&(nums[pointerIndex]>=(reachableIndex - pointerIndex)))
                {
                    reachableIndex = pointerIndex;
                    pointerIndex--;
                }
                else
                {
                    pointerIndex--;
                }
            }

            return (reachableIndex==0 && pointerIndex==-1)?true:false;
        }
    }
}
