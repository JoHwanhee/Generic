using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IntroduceGeneric
{
    public abstract class List<T> 
    {
        public abstract void Add(T item);
        public abstract void AddRange(IEnumerable<T> collection);
        public abstract ReadOnlyCollection<T> AsReadOnly();
        public abstract int BinarySearch(int index, int count, T item, IComparer<T> comparer);
        public abstract int BinarySearch(T item);
    }
}
