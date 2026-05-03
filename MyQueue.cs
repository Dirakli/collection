using System.Collections;

class MyQueue<T> : CollectionBase<T>, IEnumerable
{
    public MyQueue(int capacity = 4) : base(capacity) { }

    public void Enqueue(T value)
    {
        if (_count == _items.Length)
            IncreaseCapacity();

        _items[_count] = value;
        _count++;
    }

    public T? Dequeue()
    {
        EnsureNotEmpty("Queue");

        T? firstElement = _items[0];

        for (int i = 1; i < _count; i++)
        {
            _items[i - 1] = _items[i];
        }

        _count--;
        _items[_count] = default(T);
        return firstElement;
    }

    public object? Peek()
    {
        EnsureNotEmpty("Queue");

        return _items[0];
    }

    public new IEnumerator GetEnumerator()
    {
        return new ArrayEnumerator<T>(_items, _count);
    }
}