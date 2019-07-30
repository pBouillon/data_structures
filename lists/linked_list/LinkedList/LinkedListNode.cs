namespace DataStructures
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { get; set; }

        public T Value { get; set; }

        public bool IsTail
            => Next == null;

        public LinkedListNode(T value, LinkedListNode<T> next = null)
        {
            Next = next;
            Value = value;
        }
    }
}
