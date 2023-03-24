using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    public class LinkedListIterator<T> : Iterator<T>
    {
        private Node currentNode;
public LinkedListIterator(Node head)
        { // constructor
            currentNode = head;
        }

        public object Next()
        { //regresa el valor actual y avanza al siguiente elemento
            object value = currentNode.data;
            currentNode = currentNode.next;
            return value;
        }

        public bool HasNext()
        {
            if (currentNode == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        T Iterator<T>.Next()
        {
            throw new NotImplementedException();
        }
    }
}
