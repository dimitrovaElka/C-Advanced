using System;
using System.Collections.Generic;
using System.Text;

namespace Db
{
    public interface IDatabase
    {
        void Add(int element);
        int Remove();
    }
}
