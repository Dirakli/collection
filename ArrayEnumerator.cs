using System.Collections;

class ArrayEnumerator : IEnumerator
{
    private object?[] _items;
    private int _count;
    private int _index = -1;

    public ArrayEnumerator(object?[] items, int count)
    {
        _items = items;
        _count = count;
    }

    public object Current => _items[_index];

    public bool MoveNext()
    {
        if (_index < _items.Length - 1)
        {
            _index++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _index = -1;
    }
}