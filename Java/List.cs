using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Java
    {
        internal interface List<T>
        {
            void addAtTail(T data);

            void addAtFront(T data);

            void remove(int index);

            void removeAll();

            void setAt(int index, T data);

            Object getAt(int index);

            void removeAllWithValue(T data);

            int getSize();

            Iterator<T> getIterator();

        }
    }

}
