using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class LinkedList<T>
    {
        public int Count { get; private set; } = 0;

        public LinkedListNode<T> Head { get; private set; }

        public LinkedListNode<T> Tail { get; private set; }

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
            ++Count;

            Tail = newNode;

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
            var newNode = new LinkedListNode<T>(value);
            ++Count;

            Tail.Next = newNode;
            Tail = newNode;
        }

        public bool Contains(T value)
        {
            for (var parsedNode = Head; parsedNode != null; parsedNode = parsedNode.Next)
            {
                if (parsedNode.Value.Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        public int Find(T value)
        {
            var totalParsed = 0;

            for (var parsedNode = Head; parsedNode != null; parsedNode = parsedNode.Next, ++totalParsed)
            {
                if (parsedNode.Value.Equals(value))
                {
                    return totalParsed;
                }
            }

            return -1;
        }

        public void Insert(T value, int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException(
                    "Index specified larger than the number of elements in the queue");
            }

            var totalParsed = 0;
            LinkedListNode<T> currentNode;

            for (currentNode = Head; totalParsed < index; currentNode = currentNode.Next, ++totalParsed)
            {
                if (totalParsed == index - 1)
                {
                    break;
                }
            }

            var newNode = new LinkedListNode<T>(value, currentNode.Next);
            currentNode.Next = newNode;
        }

        public void Remove(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException(
                    "Index specified larger than the number of elements in the queue");
            }

            var totalParsed = 0;
            LinkedListNode<T> currentNode;

            for (currentNode = Head; totalParsed < index - 1; currentNode = currentNode.Next, ++totalParsed)
            {
                if (totalParsed == index - 1)
                {
                    break;
                }
            }

            currentNode.Next = currentNode.Next.Next;
        }

        public void RemoveFirst()
        {
            Head = Head.Next;
        }

        public void RemoveLast()
        {
            LinkedListNode<T> currentNode;

            for (currentNode = Head; currentNode.Next != Tail; currentNode = currentNode.Next) { }

            Tail = currentNode;
            currentNode.Next = null;
        }
    }
}