/**
 * Basic implementation of a linked list in C#
 * 
 * @author: Pierre Bouillon [https://pbouillon.github.io/]
 * @license: MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
 */

using System;
using System.Collections.Generic;

namespace DataStructures
{
    /// <summary>
    /// Implements a linked list
    /// </summary>
    /// <typeparam name="T">Desired type of the linked list</typeparam>
    public class LinkedList<T>
    {
        /// <summary>
        /// Number of nodes in the list
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// First node
        /// </summary>
        public LinkedListNode<T> Head { get; private set; }

        /// <summary>
        /// Last node
        /// </summary>
        public LinkedListNode<T> Tail { get; private set; }

        /// <summary>
        /// Default linked list constructor
        /// </summary>
        /// <param name="values">Values with whom initializing the linked list; null if not specified</param>
        public LinkedList(IEnumerable<T> values = null)
        {
            if (values == null)
            {
                return;
            }

            foreach (var value in values)
            {
                Add(value);
            }
        }

        /// <summary>
        /// Add a new value in the list
        /// </summary>
        /// <param name="value">Value to add</param>
        public void Add(T value)
        {
            var newNode = new LinkedListNode<T>(value);
            ++Count;

            // If no nodes are register, the new one become the head and the tail
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }

            // Appending the new node after the tail
            Tail.Next = newNode;

            // Updating tail's status
            Tail = Tail.Next;
        }

        /// <summary>
        /// Check if a value is stored among the linked list's nodes
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>True if there is at least one node with this value</returns>
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

        /// <summary>
        /// Find the index of the node containing the provided value
        /// </summary>
        /// <param name="value">Value of the node to find</param>
        /// <returns>The node index if found; -1 otherwise</returns>
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

        /// <summary>
        /// Insert a new node containing the provided value at a specific index
        /// </summary>
        /// <param name="value">Value of the node to insert</param>
        /// <param name="index">Index of the node to insert</param>
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

        /// <summary>
        /// Remove a node at a specific position in the linked list
        /// </summary>
        /// <param name="index">Index of the node to remove</param>
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

        /// <summary>
        /// Remove the first node in the linked list
        /// </summary>
        public void RemoveFirst()
        {
            Head = Head?.Next;
        }

        /// <summary>
        /// Remove the last node of the linked list
        /// </summary>
        public void RemoveLast()
        {
            if (Count == 0)
            {
                return;
            }

            LinkedListNode<T> currentNode;

            for (currentNode = Head; currentNode.Next != Tail; currentNode = currentNode.Next) { }

            Tail = currentNode;
            currentNode.Next = null;
        }
    }
}