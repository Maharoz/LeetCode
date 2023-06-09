using System;
using System.Collections.Generic;

namespace BinaryTreePreOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        IList<int> x = new List<int>();

        public IList<int> PreorderTraversal(TreeNode root)
        {

            if (root == null)
            {
                return x;
            }


            x.Add(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);

            return x;

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
