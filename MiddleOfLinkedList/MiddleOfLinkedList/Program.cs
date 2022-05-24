using System;

namespace MiddleOfLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            llist.addLast(1);
            llist.addLast(2);
            llist.addLast(3);
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


        public Node middleNode()
        {
            var fast = first;
            var slow = first;
            int count = 0;

            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                count++;
            }


            return slow;
        }


    }
}
