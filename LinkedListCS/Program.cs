using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode<int> list = new ListNode<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Print();
            Console.ReadKey();


        }
    }
    class Node <ITEM>
    {
        public ITEM data;
        public Node<ITEM> next;
        public Node(ITEM data)
        {
            this.data = data;
        }
    }
    class ListNode<T>
    {
        public Node<T> first;
        public ListNode()
        {
            first = null;
        }
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (first == null)
            {
                first = node;
            }
            else
            {
                Node<T> current = first;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
        }
        public void Print()
        {
            Node<T> current = first;

            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next; // переход к следующему узлу
            }
        }
    }
}
