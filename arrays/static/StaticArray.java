/**
* Basic implementation of a static array in Java
* 
* :author: Pierre Bouillon [https://pbouillon.github.io/]
* :licence: MIT [https://github.com/pBouillon/data_structures/blob/master/LICENSE]
*/

public class StaticArray<T> {

    /**
     * 
     */
    private int _nbElements;
    
    /**
     * 
     */
    private int _size;
    
    /**
     * 
     */
    private T[] _values;

    /**
     * 
     * @param capacity
     */
    public StaticArray (int capacity) {
        if (capacity < 0) {
            throw new IllegalArgumentException("Array size must be a positive number");
        }

        _nbElements = 0;
        _size = capacity;
        _values = (T[]) new Object[_size];
    } /* */

    /**
     * 
     */
    public void clear () {
        _nbElements = 0;
        for (int i = 0; i < _size; ++i) {
            _values[i] = null;
        }
    } /* */

    /**
     * 
     * @param value
     * @return
     */
    public boolean contains (T value) {
        for (int i = 0; i < _size; ++i) {
            if (_values[i] == value) {
                return true;
            }
        }
        return false ;
    } /* */

    /**
     * 
     * @param index
     * @return
     */
    public T get (int index) {
        if (index < 0 || index > _size - 1) {
            throw new IllegalArgumentException("Index out of range");
        }

        return _values[index];
    } /* */

    /**
     * 
     * @param value
     */
    public void initialize (T value) {
        _nbElements = _size;

        for (int i = 0; i < _size; ++i) {
            _values[i] = value;
        }
    } /* */

    /**
     * 
     * @return
     */
    public boolean isEmpty () {
        return _nbElements == 0;
    } /* */

    /**
     * 
     * @return
     */
    public int size() {
        return _size;
    } /* */

    /**
     * 
     * @param index
     * @param value
     */
    public void set (int index, T value) {
        if (index < 0 || index > _size - 1) {
            throw new IllegalArgumentException("Index out of range");
        }

        if (value != null) {
            ++_nbElements;
        }
        else if (value == null && _values[index] != null) {
            --_nbElements;
        }

        _values[index] = value;
    } /* */
}