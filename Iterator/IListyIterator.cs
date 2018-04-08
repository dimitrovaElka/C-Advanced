using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorTest
{
    public interface IListyIterator
    {
        bool Move();

        bool HasNext();

        void Print();
    }
}
