using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    internal interface Iterator<T>
    {
        T Next();
        bool HasNext();
    }
}
