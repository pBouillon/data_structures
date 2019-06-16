# Data structure: Queue

A queue is a **FIFO** data structure.  

FIFO stands for _First In, First Out_ which means that the first element to be
added in the queue will be the first to be returned on query.

A queue usually implements two core functions:

- `enqueue` to add an element to the queue
- `dequeue` to remove and get the last element added in the queue

Another convenient method commonly added is `peek`, which allow the user to
check the last added value (as with `dequeue`) but without removing it from the
queue.

```text
Schematic representation:

                     ┬─────┬─────┬─────┬
        dequeue <───   ... | ... | ...   <─── enqueue
                     ┴─────┴─────┴─────┴
```

## Complexity

| Operation | Complexity |
|:---------:|:----------:|
|  Enqueue  |    O(1)    |
|  Dequeue  |    O(1)    |
|  Peeking  |    O(1)    |
|  Contains |    O(n)    |
|  Removal  |    O(n)    |
|  Is Empty |    O(1)    |
