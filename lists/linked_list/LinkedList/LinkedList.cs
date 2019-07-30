using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; private set; }

        public LinkedList(IEnumerable<T> values = null)
        {
            if (values == null) return;

            foreach (var value in values)
            {
                Add(value);
            }
        }

        public void Add(T value)
        {
            var newNode = new LinkedListNode<T>(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                var parsedNode = Head;
                while (!parsedNode.IsTail)
                {
                    parsedNode = parsedNode.Next;
                }
                parsedNode.Next = newNode;
            }
        }

        public void Append(T value)
        {
            // TODO
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            // TODO
            throw new NotImplementedException();
        }

        public int Find(T value)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void Insert(T value, int index)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void Remove(int index)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
