using System;

namespace TwinSum
{

    //https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            LinkedList list = new LinkedList();
             list.addLast(5);
             list.addLast(4);
             list.addLast(2);
            list.addLast(1);
            list.PairSum();
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


        public int PairSum()
        {
            Node head = first;
            if (head == null)
                return 0;

            Node fast = head;
            Node slow = head;
            Node prev = null;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                prev = slow;
                slow = slow.next;
            }
            prev.next = null;

            Node head2 = reverse(slow);
            int res = 0;
            while (head != null)
            {
                res = Math.Max(res, head.val + head2.val);
                head = head.next;
                head2 = head2.next;
            }

            return res;
        }

        private Node reverse(Node head)
        {
            Node prev = null;
            Node next = null;
            Node curr = head;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }







    }
}
