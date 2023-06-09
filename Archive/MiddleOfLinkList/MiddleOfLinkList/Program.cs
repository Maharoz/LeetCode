using System;

namespace MiddleOfLinkList
{

    //https://leetcode.com/problems/middle-of-the-linked-list/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class LinkedList
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node()
            {
            }
            public Node(int val)
            {
                this.val = val;
            }
        }

        private Node first;
        private Node last;

        Node fast;
        public void addLast(int val)
        {
            var node = new Node(val);
            if (isEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }
        private bool isEmpty()
        {
            return first == null;
        }

        public Node MiddleOfLisnkedList()
        {
            if (first == null)
            {
                return null;
            }

            Node fast = first;
            Node slow = first;
            Node prev = null;

            while(fast!=null && fast.next != null)
            {
                fast = fast.next.next;
                prev =slow;
                slow = slow.next;
            }
            prev.next = null;

            return slow;
        }
    }
    }
