using System;

namespace ValidateBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public bool IsValidBST(TreeNode root)
        {
            return isValid(root, long.MinValue, long.MaxValue);
        }

        public bool isValid(TreeNode root, long min, long max)
        {

            if (root == null)
            {
                return true;
            }


            if (root.val <= min || root.val >= max)
            {
                return false;
            }

            return isValid(root.left, min, root.val) && isValid(root.right, root.val, max);


        }
    }


public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

}
