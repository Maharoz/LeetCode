
using System;
using System.Collections.Generic;
using System.Linq;

namespace stp01
{
    class Program
    {
        //Problem URL--> https://leetcode.com/problems/same-tree/
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.insert(1);
            tree.insert(2);
            tree.insert(1);

            Tree tree2 = new Tree();
            tree.insert(1);
            tree.insert(2);
            tree.insert(1);

            Console.WriteLine(tree.equals(tree2));

        }


        public class Tree
        {
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

            public bool equals(Tree other)
            {
                return equal(root, other.root);
            }

            private bool equal(Node first, Node second)
            {
                if (first == null && second == null)
                {
                    return true;
                }

                if (first != null && second != null)
                {
                    return first.value == second.value
                        && equal(first.leftChild, second.leftChild)
                        && equal(first.rightChild, second.rightChild);
                }

                return false;
            }
        }

    }

}
