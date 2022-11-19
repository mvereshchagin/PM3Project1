namespace Utils;

public static class ArrayExtensions
{
    public static T[] Filter<T>(this T[] array, Predicate<T> condition)
    {
        List<T> lst = new List<T>();
        foreach (var item in array)
        {
            if(condition(item))
                lst.Add(item);
        }

        return lst.ToArray();
    }

    public static void Print<T>(this T[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }
}