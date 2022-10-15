namespace PM3Project1;

public class MyList<T>
{
    private readonly T[] _array;
    private int _length = 0;

    public MyList(int capacity)
    {
        _array = new T[capacity];
    }

    public void Add(T item)
    {
        _array[_length] = item;
        _length++;
    }
}