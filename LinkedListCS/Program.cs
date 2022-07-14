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
            ListNode<string> list = new ListNode<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            
            list.Print();

            list.RemoveElement("c");
            list.Print();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс элемнта списка
    /// </summary>
    /// <typeparam name="ITEM"></typeparam>
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

    /// <summary>
    /// Класс списка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ListNode<T>
    {
        public Node<T> first;
        public ListNode()
        {
            first = null;
        }

        /// <summary>
        /// Добавить элемент в конец списка
        /// </summary>
        /// <param name="data"></param>
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
        /// Удаление выбранного элемента
        /// </summary>
        /// <param name="obj"></param>
        public void RemoveElement(T obj)
        {
            Node<T> previous = null;
            Node<T> current = first;
            if (first.Data.Equals(obj))
            {
                first = first.Next;
            }
            else
            {
                previous.Next = current.Next;

                // Если это был последний элемент списка, 
                // то изменяем указатель на крайний элемент списка.
                if (current.Next == null)
                {
                    current = previous;
                }
            }
        }

        /// <summary>
        /// Удаление из конца списка
        /// </summary>
        public void RemoveEnd()
        {
            Node<T> current = first;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }

        /// <summary>
        /// Удалить список
        /// </summary>
        public void Del()
        {
            first=null;
        }

        /// <summary>
        /// Вывести список на экран
        /// </summary>
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
