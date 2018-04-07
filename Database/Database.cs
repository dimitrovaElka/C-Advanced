using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Database : IDatabase
    {
        private const int capacity = 16;
        private int[] data;
        private int currentIndex;

        public void Add(int element)
        {
            throw new NotImplementedException();
        }

        public int Remove()
        {
            throw new NotImplementedException();
        }
    }
}
