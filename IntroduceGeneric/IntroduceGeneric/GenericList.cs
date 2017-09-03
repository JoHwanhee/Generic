using System.Collections.Generic;

namespace IntroduceGeneric
{
    public class GenericList<T>
    {
        private class Node
        {
            public Node(T t)
            {
                Next = null;
                Data = t;
            }

            public Node Next { get; set; }
            public T Data { get; }
        }

        private Node _head;

        public GenericList()
        {
            _head = null;
        }

        public void AddHead(T t)
        {
            Node n = new Node(t) {Next = _head};
            _head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}