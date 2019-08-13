# Data structure: Array (dynamic)

A dynamic array is a **random access** and **variable size** data structure.
The program allocate a specified size for the array, and allow the user to
keep on adding elements. If an element would outbound the array's size, the
structure expand itself by a **growth factor**.

```text
Schematic representation:

           get <─────┐  ┌───── set
                     |  V
        ┌─────┬─────┬─────┬─────┬─────┬....┬....┐
        | ... | ... | ... | ... | ... |    |    |
        └─────┴─────┴─────┴─────┴─────┴....┴....┘
        <----------------------------->
                    capacity
        <-------------------------------------->
                    actual size
```

## Complexity

| Operation | Complexity |
|:---------:|:----------:|
|   Access  |    O(1)    |
|   Search  |    O(n)    |
| Insertion |    search time + O(1)    |
| Appending |    O(1) is the last element is known; O(n) otherwise |
| Deletion  |    search time + O(1)     |
