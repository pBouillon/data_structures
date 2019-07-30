/**
 * Basic implementation of a queue in C#
 * 
 * @author: Pierre Bouillon [https://pbouillon.github.io/]
 * @license: MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
 */

using System.Collections.Generic;

namespace DataStructures
{
    /// <summary>
    /// Implements a basic queue
    /// </summary>
    /// <typeparam name="T">Desired type of the queue</typeparam>
    class Queue<T>
    {
        private int _capacity;
        private LinkedList<T> _values;

        /// <summary>
        /// Basic constructor for the queue
        /// </summary>
        /// <param name="capacity">Maximum capacity of the queue</param>
        public Queue(int capacity)
        {
            _capacity = capacity;
        }

        /// <summary>
        /// Search if an element is present in the queue
        /// </summary>
        /// <param name="value">element to find in the queue</param>
        /// <returns>True if the element is found, False otherwise</returns>
        public bool Contains(T value)
        {
            return _values.Contains(value);
        }

        /// <summary>
        /// Dequeue an element from the queue
        /// </summary>
        /// <returns>The dequeued element</returns>
        public T Dequeue()
        {
            var value = _values.Last.Value;
            _values.RemoveLast();
            return value;
        }

        /// <summary>
        /// Enqueue an element in the queue
        /// </summary>
        /// <param name="value">Value to enqueue in the queue</param>
        public void Enqueue(T value)
        {
            if (_values.Count + 1 > _capacity)
            {
                throw new System.Exception("Queue full");
            }
            
            _values.AddLast(value);
        }

        /// <summary>
        /// Peek at the next element to be dequeued
        /// </summary>
        /// <returns>The value if present, default otherwise</returns>
        public T Peek()
        {
            return _values.Count == 0
                ? default
                : _values.Last.Value;
        }

        /// <summary>
        /// Clear all contained values
        /// </summary>
        public void RemoveAll()
        {
            _values = new LinkedList<T>();
        }
    }
}
