using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    public class LinkedList<T> : List<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public int Size
        {
            get { return size; }
        }

        public void AddAtTail(T data)
        {
            Node<T> node = new Node<T>();
            node.data = data;
            if (size == 0)
            {
                head = node;
            }
            else
            {
                node.previous = tail;
                tail.next = node;
            }
            tail = node;
            size++;
        }

        public void AddAtFront(T data)
        {
            Node<T> node = new Node<T>();
            node.data = data;
            if (size == 0)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head.previous = node;
                head = node;
            }
            size++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }
            if (size == 1)
            {
                head = null;
                tail = null;
                size = 0;
            }
            else if (index == 0)
            {
                head = head.next;
                head.previous = null;
            }
            else if (index == size - 1)
            {
                tail = tail.previous;
                tail.next = null;
            }
            else
            {
                Node<T> iteratorNode = FindNode(index);
                iteratorNode.previous.next = iteratorNode.next;
                iteratorNode.next.previous = iteratorNode.previous;
            }
            size--;
        }

        private Node<T> FindNode(int index)
        {
            if (index < 0 || index >= size)
            {
                return null;
            }
            Node<T> iteratorNode = head;
            int i = 0;
            while (i != index)
            {
                i++;
                iteratorNode = iteratorNode.next;
            }
            return iteratorNode;
        }

        public void RemoveAll()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void SetAt(int index, T data)
        {
            Node<T> foundNode = FindNode(index);
            if (index < 0 || index >= size)
            {
                return;
            }
            if (foundNode != null)
            {
                foundNode.data = data;
            }
        }

        public T GetAt(int index)
        {
            if (index < 0 || index >= size)
            {
                return default(T);
            }
            Node<T> currentNode = head;
            for (int currentIndex = 0; currentIndex < index; currentIndex++)
            {
                currentNode = currentNode.next;
            }
            return currentNode.data;
        }

        public void RemoveAllWithValue(T data)
        {
            Node<T> iteratorNode = head;
            while (iteratorNode != null)
            {
                if (iteratorNode.data.Equals(data))
                {
                    if (iteratorNode == head)
                    {
                        head = head.next;
                        head.previous = null;
                    }
                    else if (iteratorNode == tail)
                    {
                        tail = tail.previous;
                        tail.next = null;
                    }
                    else if (size == 1)
                    {
                        head = null;
                        tail = null;
                        size = 0;
                    }
                    else
                    {
                        iteratorNode.previous.next = iteratorNode.next;
                        iteratorNode.next.previous = iteratorNode.previous;
                    }
                }
                iteratorNode = iteratorNode.next;
            }
        }
        public Iterator getIterator()
        { //
            return new LinkedListIterator(head);// retorna un objeto de tipo linkedlistiterator sin asignar a una variable
        }
    }
}
