using System;
using System.Collections;
using System.Collections.Generic;

namespace AddTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            LinkedList list = new LinkedList();
            
            list.addLast(9);
            list.addLast(9);
            list.addLast(9);
            list.addLast(9);
            list.addLast(9);
            list.addLast(9);
            list.addLast(9);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(0);
            //list.addLast(1);

            list.addLastNew(9);
            list.addLastNew(9);
            list.addLastNew(9);
            list.addLastNew(9);
            //list.addLastNew(5);
            //list.addLastNew(8);
            //list.addLastNew(9);
            //list.addLastNew(7);


            list.AddTwoNumbers();
        }
    }

    public class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
        }
    }
    public class LinkedList
    {
        private Node first;
        private Node last;

        private Node firstNew;
        private Node lastNew;


        private Node resFist;
        private Node resLast;

        private int count = 0;

        public void addLast(int item)
        {
            Node node = new Node(item);

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
            count++;
        }

        public void addLastNew(int item)
        {
            Node node = new Node(item);

            if (isEmptyNew())
            {
                firstNew = node;
                lastNew = node;
            }
            else
            {
                lastNew.next = node;
                lastNew = node;
            }
            count++;
        }


        private bool isEmpty()
        {
            return first == null;
        }

        private bool isEmptyNew()
        {
            return firstNew == null;
        }


        private bool isEmptyRes()
        {
            return resFist == null;
        }


        IList<int> fl = new List<int>();
        IList<int> ll = new List<int>();
        IList<int> c = new List<int>();
        int smaller = 0;
        int carry = 0;
        public Node AddTwoNumbers()
        {
            Node l1 = first;
            Node l2 = firstNew;
            Node result = null;

            while (true)
            {
                fl.Add(l1.value);
                l1 = l1.next;
                if (l1 == null)
                {
                    break;
                }
            }

            while (true)
            {
                ll.Add(l2.value);
                l2 = l2.next;
                if (l2 == null)
                {
                    break;
                }
            }

            while (fl.Count > ll.Count)
            {
                //smaller = fl.Count;
                ll.Add(0);

            }
            while (fl.Count < ll.Count)
            {
                fl.Add(0);

            }
         

            for (int x = 0; x < fl.Count; x++)
            {
                int r = fl[x] + ll[x];
                if (carry == 1)
                {
                    r = r + carry;
                    carry = 0;
                }

                if (r > 9)
                {
                    r = r % 10;
                    carry = 1;
                }
                c.Add(r);
            }

            if (carry == 1)
            {
                c.Add(1);
            }
            foreach(var x in c)
            {
                result = addLastRes(x);
            }

            return result;
        }

        //public Node AddTwoNumbers()
        //{
        //    Node l1 = first;
        //    Node l2 = firstNew;
        //    int num1 = 0;
        //    int num2 = 0;
        //    string uNum1= string.Empty;
        //    string uNum2 = string.Empty;
        //    string revRes = string.Empty;
        //    Node result=null;

        //     int no01 = numOfZero(l1);
        //    while (true)
        //    {
        //        num1 = (num1 * 10) + l1.value;
        //        l1 = l1.next;
        //        if (l1 == null)
        //        {
        //            break;
        //        }
        //    }


        //    int no02 = numOfZero(l2);
        //    while (true)
        //    {
        //        num2 = (num2 * 10) + l2.value;
        //        l2 = l2.next;
        //        if (l2 == null)
        //        {
        //            break;
        //        }
        //    }

        //    uNum1 = Reverse(num1.ToString());
        //    uNum2 = Reverse(num2.ToString());

        //    uNum1 = updatedNumber(no01, uNum1);
        //    uNum2 = updatedNumber(no02, uNum2);



        //    long add =Convert.ToInt64( uNum1) + Convert.ToInt64(uNum2);
        //    revRes = Reverse(add.ToString());




        //    foreach(char x in revRes)
        //    {
        //        result = addLastRes(x-'0');
        //    }


        //    if (result == null)
        //    {
        //        //  result.value = 0;
        //        var node = new Node(0);
        //    }
        //    return result;
        //}



        public Node addLastRes(int item)
        {
            Node node = new Node(item);

            if (isEmptyRes())
            {
                resFist = node;
                resLast = node;
            }
            else
            {
                resLast.next = node;
                resLast = node;
            }
            return resFist;
        }

        //public Node addFirst(int item)
        //{
        //    var node = new Node(item);

        //    if (isEmptyRes())
        //        resFist = resLast = node;
        //    else
        //    {
        //        node.next = resFist;
        //        resFist = node;
        //    }
        //    return resFist;
        //}
        //public static string Reverse(string s)
        //{
        //    char[] charArray = s.ToCharArray();
        //    Array.Reverse(charArray);
        //    return new string(charArray);
        //}
        //public int numOfZero(Node x)
        //{
        //    int c = 0;
        //    while (x.value == 0 )
        //    {
        //        c++;
        //        x = x.next;
        //        if (x == null)
        //        {
        //            break;
        //        }
        //    }
        //    return c;

        //}

        //public string updatedNumber(int x, string num)
        //{
        //    for(int i =0; i < x; i++)
        //    {
        //        num = num + '0';
        //    }

        //    return num;
        //}
    }
}

