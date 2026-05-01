using System.Collections;
abstract class CollectionBase : IEnumerable
{
    protected object?[] _items;
    protected int _count;

    public int Count => _count;

    public IEnumerator GetEnumerator()
    {
        return new ArrayEnumerator(_items, _count);
    }

    protected CollectionBase(int capacity = 4)
    {
        _items = new object[capacity];
        _count = 0;
    }

    protected void IncreaseCapacity()
    {
        object?[] newItems = new object?[_items.Length * 2];

        for (int i = 0; i < _count; i++)
        {
            newItems[i] = _items[i];
        }

        _items = newItems;
    }

    protected void Clear()
    {
        for (int i = 0; i < _count; i++)
        {
            _items[i] = null;
        }

        _count = 0;
    }

    protected void EnsureNotEmpty(string name)
    {
        if (_count == 0)
            throw new InvalidOperationException($"{name} is empty");
    }

    protected void ValidateIndex(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    protected void ValidateInsertIndex(int index)
    {
        if (index < 0 || index > _count)
            throw new ArgumentOutOfRangeException(nameof(index));
    }
}