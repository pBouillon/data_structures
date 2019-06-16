# Data structure: Array (static)

A static array is a data structure used as a **container**, containing `n`
elements where each element is **indexable** from `0` to `n - 1`.

```text
Schematic representation:

           get <─────┐  ┌───── set
                     |  V
        ┌─────┬─────┬─────┬─────┬─────┐
        | ... | ... | ... | ... | ... |
        └─────┴─────┴─────┴─────┴─────┘
        <----------------------------->
                    size
```

## Complexity

| Operation | Complexity |
|:---------:|:----------:|
|   Access  |    O(1)    |
|   Search  |    O(n)    |
| Insertion |    N/A     |
| Appending |    N/A     |
| Deletion  |    N/A     |
