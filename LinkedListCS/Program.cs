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
        private ITEM data;
        private Node<ITEM> next;

        public ITEM Data
        {
            get;
            set;
        }
        public Node<ITEM> Next
        {
            get;
            set;
        }

        public Node(ITEM data)
        {
            Data = data;
        }
    }
    class ListNode<T>
    {
        private Node<T> first;
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
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        /// <summary>
        /// Удалить первый элемент списка
        /// </summary>
        public void RemoveBegin()
        {
            Node<T> current = first;
            first = first.Next;
        }

        /// <summary>
        /// Удалить список
        /// </summary>
        public void Del()
        {
            first=null;
        }
        public void Print()
        {
            Node<T> current = first;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next; // переход к следующему узлу
            }
        }
    }
}
