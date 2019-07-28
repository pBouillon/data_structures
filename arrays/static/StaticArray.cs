/**
 * Basic implementation of a static array in C#
 * 
 * @author: Pierre Bouillon [https://pbouillon.github.io/]
 * @licence: MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
 */

using System;

namespace DataStructures
{
    /// <summary>
    /// Implements a basic static array
    /// </summary>
    /// <typeparam name="T">Type of the desired array</typeparam>
    class StaticArray<T>
    {
        private T[] _values;
        private readonly int _capacity;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="capacity">Max array capacity</param>
        /// <param name="initialValue">Value with whom the array will be initialized</param>
        public StaticArray(int capacity, T initialValue = default)
        {
            _capacity = capacity;
            _values = new T[_capacity];

            for (var i = 0; i < _capacity; ++i)
            {
                _values[i] = initialValue;
            }
        }

        /// <summary>
        /// Default accessors for an array
        /// </summary>
        /// <param name="index">index of the cell to access</param>
        /// <returns>The value on the given index</returns>
        public T this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }

        /// <summary>
        /// Add a value at a specific index
        /// </summary>
        /// <param name="value">Value to add</param>
        /// <param name="index">Index of the cell to update</param>
        public void Add(T value, int index)
        {
            if (index < 0 || index >= _capacity)
            {
                throw new ArgumentOutOfRangeException();
            }

            _values[index] = value;
        }

        /// <summary>
        /// Reset all values of the array
        /// </summary>
        public void Clear()
        {
            _values = new T[_capacity];
        }

        /// <summary>
        /// Get an element at a specific index
        /// </summary>
        /// <param name="index">Index of the cell we are looking for</param>
        /// <returns>The element in the designated cell</returns>
        public T Get(int index)
        {
            if (index < 0 || index >= _capacity)
            {
                throw new ArgumentOutOfRangeException();
            }

            return _values[index];
        }
    }
}
