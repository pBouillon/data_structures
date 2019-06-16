"""
Basic implementation of a stack in Python

:author: Pierre Bouillon [https://pbouillon.github.io/]
:licence: MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
"""


class Stack:
    """Implements a basic stack
    """

    def __init__(self, values: list = None) -> None:
        """Default constructor for a stack
        
        :param values: optional - list of values to initialize the stack
        """
        self._values = []


        if not values:
            return
            
        for value in values:
            self.push(value)

    def peak(self) -> object:
        """Peak at the next element to be popped

        :return: None if the stack is empty, the next element otherwise
        """
        return None if self.is_empty else self._values[0]

    def pop(self) -> object:
        """Pop the last pushed element

        :raise: an IndexError if there is an attempt to pop on an empty array

        :return: the last element pushed
        """
        if self.is_empty:
            raise IndexError('Unable perform pop() on an empty stack')

        popped = self._values[-1]
        del self._values[-1]

        return popped

    def push(self, value: object) -> None:
        """Push a new element in the stack

        :param value: element to push
        """
        self._values.append(value)
    
    @property
    def is_empty(self) -> bool:
        """Check whether the stack is empty or not

        :return: True if the stack is empty; False otherwise
        """
        return not self._values

    @property
    def size(self) -> int:
        """Get the size of the stack

        :return: the number of elements in the stack
        """
        return len(self._values)
