using System;
using System.Collections.Generic;

namespace Logvinov_153505_Lab1
{
    public class MyCustomCollection<T> : ICustomCollection<T>
    {
        protected class Node<T>
        {
            public Node(T element)
            {
                information = element;
                next = null;
                prev = null;
            }

            public Node<T> prev;
            public Node<T> next;
            public T information;
        }

        public MyCustomCollection()
        {
            current = null;
            head = tail = null;
            count = 0;
        }

        public T this[int index]
        {   
            get
            {
                Node<T> variable = head;
                for (int i = 0; i < index; i++)
                {
                    variable = variable.next;
                }

                return variable.information;
            }
            set
            {
                Node<T> variable = head;
                for (int i = 0; i < index; i++)
                {
                    variable = variable.next;
                }

                variable.information = value;
            }
        }

        public void Reset()
        {
            current = head;
        }

        public void Next()
        {
            if (current.next != null)
            {
                current = current.next;
            }
        }

        public T Current()
        {
            return current.information;
        }

        public int Count => count;

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }

            count++;
        }

        public void Remove(T item)
        {
            Node<T> variable = head;
            bool temp = false;
            if (head != null)
            {
                while (!EqualityComparer<T>.Default.Equals(variable.information, item))
                {
                    variable = variable.next;
                    if (tail == variable && !EqualityComparer<T>.Default.Equals(variable.information, item))
                    {
                        temp = true;
                        break;
                    }
                }

                if (temp)
                {
                    return;
                }


                if (variable.prev != null && variable.next != null)
                {
                    variable.prev.next = variable.next;
                    variable.next.prev = variable.prev;
                    count--;
                }
                else if (variable == head)
                {
                    head = head.next;
                    head.prev = null;
                    count--;
                }
                else
                {
                    tail = tail.prev;
                    tail.next = null;
                    count--;
                }
            }
        }


        public void RemoveCurrent()
        {
           Remove(current.information);
        }

        private Node<T> current;
        private Node<T> head;
        private Node<T> tail;
        private int count;
    }
}