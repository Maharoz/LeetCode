using System;
using System.Collections.Generic;
using System.Linq;

namespace RangeSumOfBST
{

    //https://leetcode.com/problems/range-sum-of-bst/
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.insert(10);
            tree.insert(5);
            tree.insert(15);
            tree.insert(3);
            tree.insert(7);
            tree.insert(18);

          //  tree.RangeSumBST();
        }
    }

    public class Tree
    {

        List<int> x = new List<int>();
        public class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value = value;
            }
        }

        public Node root;

        public void insert(int value)
        {
            var node = new Node(value);
            if (root == null)
            {
                root = node;
                return;
            }

            Node current = root;

            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
            }

        }





        public int RangeSumBST(Node root, int low, int high)
        {
            int total = 0;
            if (root == null)
            {
              
                return total;
            }

            Console.WriteLine(root.value);

            if (root.value <= high && root.value >= low)
            {
                x.Add(root.value);
            }

           

            RangeSumBST(root.leftChild, low, high);
            RangeSumBST(root.rightChild, low, high);
            total = x.Sum(x => Convert.ToInt32(x));
            return total;
        }
    }
}
