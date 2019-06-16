# Data structure: Stack

A stack is a **LIFO** data structure.  

LIFO stands for _Last In, First Out_ which means that the last element to be
added in the stack will be the first to be returned on query.

A stack usually implements two core functions:

- `push` to add an element to the stack
- `pop` to remove and get the last element added in the stack

Another convenient method commonly added is `peek`, which allow the user to
check the last added value (as with `pop`) but without removing it from the
stack.

```text
Schematic representation:

    pop <─────┐     ┌───── push
              |     V
            |   ...   |
            +---------+
            |   ...   |
            +---------+
            |   ...   |
            +---------+
```

## Complexity

| Operation | Complexity |
|:---------:|:----------:|
|  Pushing  |    O(1)    |
|  Popping  |    O(1)    |
|  Peeking  |    O(1)    |
| Searching |    O(n)    |
|   Size    |    O(1)    |
