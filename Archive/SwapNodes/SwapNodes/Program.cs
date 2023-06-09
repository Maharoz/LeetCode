using System;

namespace SwapNodes
{
    class Program
    {

        //https://leetcode.com/problems/swap-nodes-in-pairs/
        static void Main(string[] args)
        {
            Linkedlist llist = new Linkedlist();
            llist.addLast(1);
            llist.addLast(2);
            llist.addLast(3);
            llist.addLast(4);

            Console.WriteLine("List before removal of duplicates");
            llist.swapNode();
        }
    }

    public class Linkedlist
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

        public Node first;
        public Node last;

        public void addLast(int n)
        {
            var node = new Node(n);

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

        public void swapNode()
        {
            Node p = first;
   
            while(p!=null && p.next != null)
            {
                int temp = p.val;
                p.val = p.next.val;
                p.next.val = temp;
                p = p.next.next;
            }


        }
        private bool isEmpty()
        {
            return first == null;
        }
    }
}
