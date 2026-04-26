class MyStack : CollectionBase
{
    public MyStack(int capacity = 4) : base(capacity) { }
    public void Push(object value)
    {
        if (_count == _items.Length)
            IncreaseCapacity();

        _items[_count++] = value;
    }

    public object? Pop()
    {
        EnsureNotEmpty("Stack");

        _count--;
        object? item = _items[_count];
        _items[_count] = null;
        return item;
    }

    public object? Peek()
    {
        EnsureNotEmpty("Stack");

        return _items[_count - 1];
    }
}