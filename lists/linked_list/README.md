# Data structure: Linked List

A linked list consists of a succession of no or several cells containing a value
and linked to another.  

The first node is called the _head_ while the last is called _tail_. Depending of
the implementations, the _tail_ can also design all the nodes following the
_head_.

```text
Schematic representation:

        ┬─────┬      ┬─────┬      ┬─────┬
        | ... | ───> | ... | ───> | ... | ───> (null)
        ┴─────┴      ┴─────┴      ┴─────┴
           ^                         ^
          head                      tail
```

## Complexity

| Operation                                     | Complexity               |
|:---------------------------------------------:|:------------------------:|
| Insert / Delete at the beginning              |           O(1)           |
| Insert / Delete at end (knowing the tail)     |           O(1)           |
| Insert / Delete at end (not knowing the tail) |           O(n)           |
| Insert / Delete in the linked list            |    search time + O(1)    |
| Search                                        |           O(n)           |
