using System;

namespace SymmetricTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
        }
    }
    //https://leetcode.com/problems/symmetric-tree

    public class Tree
    {
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



            public bool IsSymmetric(TreeNode root)
            {
                return isMirror(root.left, root.right);
            }

            private bool isMirror(TreeNode p, TreeNode q)
            {
                if (p == null && q == null)
                {
                    return true;
                }


                if (p == null || q == null)
                {
                    return false;
                }

                return (p.val == q.val) && isMirror(p.left, q.right) &&
                           isMirror(p.right, q.left);



            }

        }
    }
}
