class MyQueue : CollectionBase
{
    public MyQueue(int capacity = 4) : base(capacity) { }

    public void Enqueue(object value)
    {
        if (_count == _items.Length)
            IncreaseCapacity();

        _items[_count] = value;
        _count++;
    }

    public object? Dequeue()
    {
        EnsureNotEmpty("Queue");

        object? firstElement = _items[0];

        for (int i = 1; i < _count; i++)
        {
            _items[i - 1] = _items[i];
        }

        _count--;
        _items[_count] = null;
        return firstElement;
    }

    public object? Peek()
    {
        EnsureNotEmpty("Queue");

        return _items[0];
    }
}