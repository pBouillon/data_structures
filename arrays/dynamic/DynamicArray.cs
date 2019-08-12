/**
 * Basic implementation of a static array in C#
 * 
 * @author: Pierre Bouillon [https://pbouillon.github.io/]
 * @license: MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
 */

using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    /// <summary>
    /// Implements a static array
    /// </summary>
    /// <typeparam name="T">Desired type of the static array</typeparam>
    public class DynamicArray<T> : IEnumerable<T>
    {
        /// <summary>
        /// Factor used for the array size expansion
        /// </summary>
        private const int GrowingFactor = 2;

        /// <summary>
        /// Tracker for the values contained in the array
        /// </summary>
        private int _contained;

        /// <summary>
        /// Actual array
        /// </summary>
        private T[] _values;

        /// <summary>
        /// Array accessor
        /// </summary>
        /// <param name="i">The index to access</param>
        /// <returns>The requested element at the specified index</returns>
        public T this[int i]
        {
            get => _values[i];
            set => _values[i] = value;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DynamicArray()
        {
            _contained = 0;
            _values = new T[1];
        }

        /// <summary>
        /// Constructor with specified array size
        /// </summary>
        /// <param name="size">The desired initial size</param>
        public DynamicArray(int size)
        {
            _contained = 0;
            _values = new T[size];
        }

        /// <summary>
        /// Add a new value add the end of the array
        /// </summary>
        /// <param name="value">Value to add</param>
        public void Add(T value)
        {
            // If we are out of bounds, expanding the array
            if (_contained + 1 == _values.Length)
            {
                ExpandArray();
            }

            _values[++_contained] = value;
        }

        /// <summary>
        /// Clear all contained elements
        /// </summary>
        public void Clear()
        {
            for (var i = 0; i < _values.Length; ++i)
            {
                _values[i] = default;
            }
        }

        /// <summary>
        /// Expand the array by the GrowingFactor
        /// </summary>
        private void ExpandArray()
        {
            var expandedSize = _values.Length * GrowingFactor;
            var expandedArray = new T[expandedSize];

            for (var i = 0; i < _values.Length; ++i)
            {
                expandedArray[i] = _values[i];
            }

            _values = expandedArray;
        }

        /// <summary>
        /// Clear the element at the given index
        /// </summary>
        /// <param name="index">Index of the element to clear</param>
        public void Remove(int index)
        {
            _values[index] = default;
        }

        /// <summary>
        /// Override IEnumerable method
        /// </summary>
        /// <returns>Object's enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>) _values.GetEnumerator();
        }

        /// <summary>
        /// Override IEnumarble method
        /// </summary>
        /// <returns>Object's enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _values.GetEnumerator();
        }
    }
}
