using System.Xml;

namespace PM3Project1;

public static class TryTemplates
{
    public static void FirstTry()
    {
        List<string> names = new List<string>();
        names.Add("Дарья");
        names.AddRange(new string[] {"Алан", "Анастасия"});

        string name = names[0];

        List<int> numbers = new();
        numbers.Add(12);
        numbers.Add(15);
        numbers.Remove(15);

        List<Human> humans = new();
        humans.Add(new Student());
        humans.Add(new Teacher());

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Dictionary<int, string> dict = new();
        dict.Add(1, "Дарья");
        dict.Add(2, "Анастасия");
        foreach (var key in dict.Keys)
        {
            var value = dict[key];
            Console.WriteLine(value);
        }

        MyList<int> ints = new MyList<int>(10);
        ints.Add(10);

        MyList<string> strings = new MyList<string>(10);
        strings.Add("Анастасия");
    }
}