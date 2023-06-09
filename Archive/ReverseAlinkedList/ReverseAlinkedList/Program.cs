using System;

namespace ReverseAlinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            llist.addLast(1);
            llist.addLast(2);
            llist.addLast(3);

            llist.organizedList();
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

        public Node organizedList()
        {
            Node current = first;
            Node next=null;
            Node prev = null;


            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;

            }

              first=prev;

         

            return first;
        }


    }
}
