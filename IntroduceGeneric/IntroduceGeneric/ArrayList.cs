using System;
using System.Collections;

namespace IntroduceGeneric
{
    public abstract class ArrayList
    {
        public abstract int Add(object value);
        public abstract void AddRange(ICollection c);
        public abstract int BinarySearch(int index, int count, object value, IComparer comparer);
        public abstract int BinarySearch(object value);
        public abstract int BinarySearch(object value, IComparer comparer);
        public abstract bool Contains(object item);
    }
}