﻿using System;

namespace MaximumDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }

     public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
       {
           this.val = val;
           this.left = left;
           this.right = right;
                }
  }
 
}
