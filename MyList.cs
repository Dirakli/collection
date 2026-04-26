using System.Collections;
class MyList : CollectionBase, IList
{
    public MyList() : base(4) { }

    public object? GetElementAt(int index)
    {
        ValidateIndex(index);

        return _items[index];
    }

    public int Add(object? value)
    {
        if (_count == _items.Length)
        {
            IncreaseCapacity();
        }

        _items[_count] = value;
        return _count++;
    }

    public void Insert(int index, object? value)
    {
        ValidateInsertIndex(index);

        if (_count == _items.Length)
        {
            IncreaseCapacity();
        }

        for (int i = _count; i > index; i--)
        {
            _items[i] = _items[i - 1];
        }

        _items[index] = value;
        _count++;
    }

    public void Remove(object? value)
    {
        int index = IndexOf(value);
        if (index != -1) RemoveAt(index);
    }

    public void RemoveAt(int index)
    {
        ValidateIndex(index);

        for (int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _items[_count - 1] = null;
        _count--;
    }

    public void Clear()
    {
        for (int i = 0; i < _count; i++)
        {
            _items[i] = null;
        }

        _count = 0;
    }

    public bool Contains(object? value)
    {
        return IndexOf(value) != -1;
    }

    public int IndexOf(object? value)
    {
        return IndexOf(value, 0);
    }

    public int IndexOf(object? value, int startIndex)
    {
        ValidateInsertIndex(startIndex);

        for (int i = startIndex; i < _count; i++)
        {
            if (value == _items[i])
                return i;
        }

        return -1;
    }

    public void CopyTo(Array array, int index)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));

        if (index < 0)
            throw new ArgumentOutOfRangeException(nameof(index));

        for (int i = 0; i < _count; i++)
        {
            array.SetValue(_items[i], index + i);
        }
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public bool IsSynchronized => false;
    public object SyncRoot => this;
    public bool IsFixedSize => false;
    public bool IsReadOnly => false;

    public object? this[int index]
    {
        get
        {
            ValidateIndex(index);

            return _items[index];
        }
        set
        {
            ValidateIndex(index);

            _items[index] = value;
        }
    }
}