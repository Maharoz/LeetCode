using System;

namespace DeleteMiddleOfLinkedList
{

    //https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.addLast(1);
            list.addLast(2);
            list.addLast(3);
            list.addLast(4);
            list.addLast(5);

            list.reOrderedList();
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
      
        public Node reOrderedList()
        {
            Node head = first;
            if (head == null || head.next == null)
                return null;

            Node fast = head;
            Node slow = head;
            Node prev = null;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                prev = slow;
                slow = slow.next;
            }

            prev.next = slow.next;
            return head;
        }

    }
}
