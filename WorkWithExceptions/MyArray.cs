namespace WorkWithExceptions;

public class MyArray
{
    private int[] _array = new int[100];
    private const int _maxIndex = 10;
    
    public int this[int index]
    {
        get
        {
            if (index >= _maxIndex)
                throw new IndexOutOfRangeException();

            return _array[index];
        }
    }
}