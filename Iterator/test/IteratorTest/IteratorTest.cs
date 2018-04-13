using System;
using Xunit;
using Iterator;
using System.Collections.Generic;
using System.Linq;

namespace IteratorTest
{
    public class IteratorTest
    {
        [Fact]
        public void MainTest()
        {
            var collection = new CustomCollection<int> { 1, 2, 3, 4, 5 };
            var iterator = collection.CreateIterator();
            Assert.Equal(new int[] { 1, 3, 5 }, iterator.getCollectionFromIterator().ToList());
        }
    }

    public static class IteratorExtensions
    {
        public static IEnumerable<int> getCollectionFromIterator(this Iterator<int> iterator)
        {
            while (!iterator.IsDone())
            {
                yield return iterator.Next();
            }
        }
    }
}
