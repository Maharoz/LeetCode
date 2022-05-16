using System;
using System.Collections.Generic;
using System.Linq;

namespace UniValuedBinaryTree
{
    //https://leetcode.com/problems/univalued-binary-tree/
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.insert(1);
            tree.insert(1);
            tree.insert(1);
            tree.insert(1);
            tree.insert(1);

            tree.checkUniValued(tree.root);

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

        bool result = true;
        
        public bool checkUniValued(Node root)
        {

            if (root == null)
            {
                return result;
            }

            x.Add(root.value);

            checkUniValued(root.leftChild);
            checkUniValued(root.rightChild);
            //result = x.Any(o => o != x[0]);
            result = x.Distinct().Count() == 1;
            return result;
        }
    }
}
