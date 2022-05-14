using System;
using static RemoveDuplicate.LinkedList;

namespace RemoveDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
           
        LinkedList llist = new LinkedList();
        llist.addLast(1);
        llist.addLast(1);
        llist.addLast(2);
        llist.addLast(3);
        llist.addLast(3);
        llist.addLast(3);
         
        Console.WriteLine("List before removal of duplicates");
        llist.purifiedList();
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

        public Node purifiedList()
        {
            Node p = first;
            Node q;

            if (first == null)
            {
                return first;
            }

            while (p.next != null)
            {
                if (p.val == p.next.val)
                {
                    q = p.next.next;
                    p.next = null;
                    p.next = q;
                }
                else if (p.val != p.next.val)
                {
                    {
                        p= p.next;
                    }
                }
            }

          
            return first;
           
        }
    }
}
