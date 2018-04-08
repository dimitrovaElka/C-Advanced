using IteratorTest;
using NUnit.Framework;
using System;

namespace IteratorTests
{
    public class IteratorTests
    {
        [Test]
        public void TestValidConstructor()
        {
            int[] values = new int[] { 1, 2, 3 };
            ListyIterator<int> iterator = new ListyIterator<int>(values);

            Assert.That(iterator, Is.EquivalentTo(values));
        }
    }
}
