using System;

namespace OddEvenLinkedList
{
    //https://leetcode.com/problems/odd-even-linked-list/
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            //llist.addLast(1);
            //llist.addLast(2);
            //llist.addLast(3);
            //llist.addLast(4);
            //llist.addLast(5);
            //llist.addLast(6);
            //llist.addLast(7);
            //llist.addLast(8);

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
            Node p = first;

            while(p!=null && p.next != null)
            {
                addLaste(p.next.val);
                if (p.next.next == null)
                {
                    p.next = efirst;
                    return first;
                }
                else
                {
                    p.next = p.next.next;
                    p = p.next;
                }
             
            }

            if (efirst != null)
            {
                p.next = efirst;
            }
           

            return first;
        }


        private Node efirst;
        private Node elast;

        public void addLaste(int val)
        {
            var node = new Node(val);
            if (isEmpty2())
            {
                efirst = node;
                elast = node;
            }
            else
            {
                elast.next = node;
                elast = node;
            }
        }

        private bool isEmpty2()
        {
            return efirst == null;
        }
    }
    }
