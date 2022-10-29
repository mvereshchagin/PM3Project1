namespace WorkWithDelegates;

public static class ArrayUtills
{
    public static T[] Filter<T>(T[] array, Predicate<T> condition)
    {
        List<T> lst = new List<T>();
        foreach (var item in array)
        {
            if(condition(item))
                lst.Add(item);
        }

        return lst.ToArray();
    }
}