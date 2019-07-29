/*
 * Basic implementation of a stack in C#
 *
 * <author>
 *      Pierre Bouillon [https://pbouillon.github.io/]
 * </author>
 *
 * <license>
 *      MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
 * </license>
 */

using System;
using System.Collections.Generic;

namespace DataStructures
{
    /// <summary>
    /// Implements a basic stack
    /// </summary>
    public class Stack<T>
    {
        private readonly int _maxSize;
        private readonly LinkedList<T> _values;

        public bool IsEmpty
            => _values.Count == 0;

        public int Size
            => _values.Count;

        /// <summary>
        /// Default constructor for a stack
        /// </summary>
        /// <param name="maxSize">maximum reachable</param>
        public Stack(int maxSize)
        {
            _maxSize = maxSize;
            _values = new LinkedList<T>();
        }

        /// <summary>
        /// Constructor for a stack with values to initialize it with
        /// </summary>
        /// <param name="maxSize">maximum reachable</param>
        /// <param name="values">list of values to initialize the stack</param>
        public Stack(int maxSize, IEnumerable<T> values)
        {
            _maxSize = maxSize;
            _values = new LinkedList<T>(values);
        }

        /// <summary>
        /// Search if an element is present in the array
        /// </summary>
        /// <param name="toSearch">element to find in the array</param>
        /// <returns>True if the element is found, False otherwise</returns>
        public bool Contains(T toSearch)
        {
            return _values.Contains(toSearch);
        }

        /// <summary>
        /// Peek at the next element to be popped
        /// </summary>
        /// <returns>Null if the stack is empty, the next element otherwise</returns>
        public T Peek()
        {
            return _values.Count > 0
                ? _values.First.Value
                : default;
        }

        /// <summary>
        /// Pop the last pushed element
        /// </summary>
        /// <exception cref="IndexOutOfRangeException">
        ///     If there is an attempt to pop on an empty array
        /// </exception>
        /// <returns>the last element pushed</returns>
        public object Pop()
        {
            if (IsEmpty)
            {
                throw new IndexOutOfRangeException(
                    "Unable to perform pop() on an empty stack"
                );
            }

            var popped = _values.First;
            _values.RemoveFirst();

            return popped;
        }

        /// <summary>
        /// Push a new element in the stack
        /// </summary>
        /// <exception cref="IndexOutOfRangeException">
        ///     If there is an attempt to push in a filled array
        /// </exception>
        /// <param name="value">element to push</param>
        public void Push(T value)
        {
            if (_values.Count + 1 > _maxSize)
            {
                throw new IndexOutOfRangeException("Max stack size reached");
            }

            _values.AddFirst(value);
        }
    }
}
