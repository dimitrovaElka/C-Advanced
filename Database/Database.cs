using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Db
{
    public class Database : IDatabase
    {
        private const int capacity = 16;
        private int[] data;
        private int currentIndex;

        private Database()
        {
            this.Data = new int[capacity];
            this.currentIndex = 0;
        }
        public Database(params int[] elements)
            : this()
        {
            NewMethod(elements);
        }

        private void NewMethod(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.Data[i] = elements[i];
            }
            this.currentIndex = elements.Length;
        }

        public int[] Data
        {
            get
            {
                return this.data;
            }
            private set
            {
                if (value.Length < 1 || value.Length > capacity)
                {
                    throw new InvalidOperationException();
                }
                this.data = value;
            }
        }
        public void Add(int element)
        {
            if (this.currentIndex >= capacity)
            {
                throw new InvalidOperationException();
            }
            this.Data[currentIndex] = element;
            this.currentIndex++;
        }

        public int Remove()
        {
            if (currentIndex <= 0)
            {
                throw new InvalidOperationException();
            }
            this.currentIndex--;
            int element = data[currentIndex];
            data[currentIndex] = default(int); 
            return element;
        }
    }
}
