"""
Basic implementation of a static array in Python

:author: Pierre Bouillon [https://pbouillon.github.io/]
:licence: MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
"""


class Array:
    """Implements a basic static array
    """

    def __init__(self, size: int) -> None:
        """Default array constructor

        :param size: final size of the array
        """
        if size < 0:
            raise ValueError('Array size must be a positive number')

        self._nb_elements = 0
        self._size = size
        self._values = [None for _ in range(size)]

    def clear(self) -> None:
        """Clear all cells of the array

        Set all values to `None`
        """
        self._nb_elements = 0
        self._values = [None for _ in range(self._size)]
    

    def get(self, index: int) -> object:
        """Get the value at a specific index

        :param index: index of the value to fetch

        :return: the value at the given index
        """
        if not 0 <= index < self._size:
            raise ValueError('Index out of bounds')

        return self._values[index]
        
    def initialize(self, value: object) -> None:
        """Initialize all cells to the given value

        :param value: value to set in each cell
        """
        self._nb_elements = self._size
        self._values = [value for _ in range(self._size)]

    def is_empty(self) -> bool:
        """Check if the array is empty

        :return: True if no values are contained
        """
        return not self._nb_elements
        
    def set(self, index: int, value: object) -> None:
        """Set a value at a specific index

        :param index: index in which put the value
        :param value: value to set at the index
        """
        # check that the index is in bound
        if not 0 <= index < self._size:
            raise ValueError('Index out of bounds')

        # If the value is not set and we put a 'real' value in it
        # increment the number of elements contained
        if self._values[index] == None \
                and value != None:
            self._nb_elements += 1

        # If the user clear the value
        # decrement the number of elements contained
        if self._values[index] != None \
                and value == None:
            self._nb_elements -= 1

        self._values[index] = value

    @property
    def length(self) -> int:
        """Get the length of the array

        :return: the array's size
        """
        return self._size
