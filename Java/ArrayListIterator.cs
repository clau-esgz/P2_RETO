using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    public class ArrayListIterator : Iterator<T>
    {
        private ArrayList arraylist;
        private int currentSpace = 0;

        public ArrayListIterator(ArrayList arrayList)
        {
            this.arraylist = arrayList;
        }

        public T next()
        {
            T data = arraylist.getAt(currentSpace);
            currentSpace++;
            return data;
        }

        public bool hasNext()
        {
            return currentSpace < arraylist.getSize();
        }

        public T Next()
        {
            throw new NotImplementedException();
        }

        public bool HasNext()
        {
            throw new NotImplementedException();
        }
    }
}

