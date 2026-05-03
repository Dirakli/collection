using System.Collections;
using System.Collections.Generic;
class MyStack<T> : CollectionBase<T>
{
    public MyStack(int capacity = 4) : base(capacity) { }
    public void Push(T value)
    {
        if (_count == _items.Length)
            IncreaseCapacity();

        _items[_count++] = value;
    }
    public T? Pop()
    {
        EnsureNotEmpty("Stack");

        _count--;
        T? item = _items[_count];
        _items[_count] = default(T);
        return item;
    }

    public object? Peek()
    {
        EnsureNotEmpty("Stack");

        return _items[_count - 1];
    }

    public new IEnumerator GetEnumerator()
    {
        return new ArrayEnumerator<T>(_items, _count);
    }
}