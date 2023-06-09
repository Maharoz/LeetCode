using System;
using System.Collections.Generic;
using System.Linq;

namespace SomeOfLeftLeaves
{

    //https://leetcode.com/problems/sum-of-left-leaves/
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.insert(3);
            tree.insert(9);
            tree.insert(20);
            tree.insert(15);
            tree.insert(7);

            tree.sumOfLeftLeave(tree.root);
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

        public int sumOfLeftLeave(Node root)
        {
            int total = 0;
            if (root == null)
            {
                return total;
            }

            if (root.leftChild!= null && root.leftChild.leftChild==null
                && root.leftChild.rightChild==null
                )
            {
                x.Add(root.value);
            }

            sumOfLeftLeave(root.leftChild);
            sumOfLeftLeave(root.rightChild);
            total = x.Sum(x => Convert.ToInt32(x));
            return total;
        }

    }
}
