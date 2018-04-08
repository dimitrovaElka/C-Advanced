using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorTest
{
    public class ListyIterator<T> : IListyIterator, IEnumerable<T>
    {
        private ICollection<T> collection;
        private int currentIndex;

        public ListyIterator(params T[] collection)
        {
            this.collection = new List<T>(collection);
            this.currentIndex = 0;
        }


        public bool HasNext() => this.currentIndex < this.collection?.Count - 1;

        public bool Move()
        {
            if (currentIndex < this.collection.Count - 1)
            {
                this.currentIndex++;
                return this.currentIndex < this.collection?.Count;
            }
            return false;
        }

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(collection.ToList()[this.currentIndex]);
        }

        public void PrintAll()
        {
            var output = "";
            foreach (var element in this.collection)
            {
                output = output + element + " ";
            }
            Console.WriteLine(output.TrimEnd());
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection.ToList()[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    }
}
