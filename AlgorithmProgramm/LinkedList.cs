using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgramm
{
    internal class LinkedList<T>
    {
        internal Node<T> head;
        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void AddInReverseOrder(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
        }
        internal Node<T> InsertAtParticularPosition(int position, T data)
        {
            Node<T> newestNode = new Node<T>(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }
        internal void InsertAtFirstPosition(int position, T data)
        {
            Node<T> node = new Node<T>(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Choice");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
        public Node<T> Pop()
        {
            Node<T> node = head;
            if (head == null)
            {
                Console.WriteLine("liklist is empty");
            }
            else
            {
                head = head.next;
            }
            return node;
        }
        public Node<T> PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
                return null;
            }
            else
            {
                Node<T> n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }
                n.next = null;
                return n;
            }
        }
        internal void LinkedListSize()
        {
            int count = 0;
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\nSize of Linked List is:-" + " " + count);

        }
        internal int Search(int value)
        {
            int count = 0;
            Node<T> node = this.head;


            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    return count;

                }
                node = node.next;
                count++;
            }
            return count;
        }
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " " + "\n");
                temp = temp.next;
            }
        }
    }
}

