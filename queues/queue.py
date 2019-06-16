"""
Basic implementation of a queue in Python

:author: Pierre Bouillon [https://pbouillon.github.io/]
:licence: MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
"""

class Queue:
    """Implements a basic queue

                     ┬─────┬─────┬─────┬
        dequeue <───   ... | ... | ...  <─── enqueue
                     ┴─────┴─────┴─────┴
    """

    def __init__(self, max_size: int, values: list = None) -> None:
        """Default constructor for a queue
        
        :param max_size: maximum reachable 
        :param values: optional - list of values to initialize the queue
        """
        self._max_size = max_size
        self._values = []

        if not values:
            return

        for value in values:
            self.enqueue(value)

    def dequeue(self) -> object:
        """Dequeue an element from the queue

        :raise: an IndexError if there is an attempt to dequeue an empty queue

        :return: the dequeued element
        """
        if self.is_empty:
            raise IndexError('Unable perform dequeue() on an empty queue')

        dequeued = self._values[0]
        self._values = self._values[1:]

        return dequeued
        
    def enqueue(self, value: object) -> None:
        """Enqueue an element in the queue

        :raise: an IndexError if the maximum size is reached

        :param value: value to enqueue in the queue
        """
        if self.size + 1 == self._max_size:
            raise IndexError('Max queue size reached')
    
        self._values.append(value)

    def peak(self) -> object:
        """Peak at the next element to be dequeued

        :return: None if the queue is empty, the next element otherwise
        """
        return None if self.is_empty else self._values[0]

    @property
    def is_empty(self):
        """Check whether the queue is empty or not

        :return: True if the queue is empty; False otherwise
        """
        return not self._values

    @property
    def size(self) -> int:
        """Get the size of the queue

        :return: the number of elements in the queue
        """
        return len(self._values)
