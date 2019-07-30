/**
 * Basic implementation of a linked list node in C#
 * 
 * @author: Pierre Bouillon [https://pbouillon.github.io/]
 * @license: MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
 */

namespace DataStructures
{
    /// <summary>
    /// Implements a linked list node
    /// </summary>
    /// <typeparam name="T">Desired type of the node</typeparam>
    public class LinkedListNode<T>
    {
        /// <summary>
        /// Node following the current one
        /// </summary>
        public LinkedListNode<T> Next { get; set; }

        /// <summary>
        /// Node's value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// True if this node as no following node
        /// </summary>
        public bool IsTail
            => Next == null;

        /// <summary>
        /// Initialize the current node
        /// </summary>
        /// <param name="value">Node's value</param>
        /// <param name="next">Node's following node; null if not specified</param>
        public LinkedListNode(T value, LinkedListNode<T> next = null)
        {
            Next = next;
            Value = value;
        }
    }
}
