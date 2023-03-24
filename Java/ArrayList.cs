using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    public class ArrayList<T> : List<T>
    {
        private const int INITIAL_SIZE = 2;

        private T[] array;
        private int inserted;

        public ArrayList()
        {
            array = new T[INITIAL_SIZE];
        }

        public void addAtTail(T data)
        {
            if (inserted == array.Length)
            {
                increaseSize();
            }
            array[inserted] = data;
            inserted++;
        }

        private void increaseSize()
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public int getSize()
        {
            return inserted;
        }

        public int getLength()
        {
            return array.Length;
        }

        public void removeAll()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = default(T);
            }
            inserted = 0;
        }

        public void addAtFront(T data)
        {
            if (inserted == array.Length)
            {
                increaseSize();
            }
            for (int i = inserted; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = data;
            inserted++;
        }

        public void remove(int index)
        {
            if (index < 0 || index >= inserted)
            {
                return;
            }
            for (int i = index; i < inserted - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[inserted - 1] = default(T);
            inserted--;
        }

        public void setAt(int index, T data)
        {
            if (index < 0 || index >= inserted)
            {
                return;
            }
            array[index] = data;
        }

        public T getAt(int index)
        {
            if (index < 0 || index >= inserted)
            {
                return default(T);
            }
            return array[index];
        }

        public void removeAllWithValue(T data)
        {
            T[] newArray = new T[array.Length];
            int count = 0;
            for (int i = 0; i < inserted; i++)
            {
                if (!array[i].Equals(data))
                {
                    newArray[count] = array[i];
                    count++;
                }
            }
            array = newArray;
            inserted = count;
        }

        public Iterator<T> getIterator()
        {
            return new ArrayListIterator<T>(this);
        }
    }
}
