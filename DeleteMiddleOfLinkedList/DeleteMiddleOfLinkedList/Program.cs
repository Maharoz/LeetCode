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

        public Node reverse(Node head)
        {
            Node prev = null;
            Node current_node = head;

            while (current_node != null)
            {
                Node next_node = current_node.next;
                current_node.next = prev;
                prev = current_node;
                current_node = next_node;

            }
            return prev;
        }

        public void merge(Node l1, Node l2)
        {
            while (l1 != null)
            {
                Node l1_next = l1.next;
                Node l2_next = l2.next;

                l1.next = l2;

                if (l1_next == null)
                {
                    break;
                }

                l2.next = l1_next;
                l1 = l1_next;
                l2 = l2_next;
            }
        }
    }
}
