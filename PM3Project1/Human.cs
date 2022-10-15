namespace PM3Project1;

public abstract class Human : object
{
    public Human(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
    
    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public Gender Gender { get; set; } 

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Comment { get; set; }

    public override string ToString()
    {
        return $"{Surname} {Name}";
    }

    protected string PropertyToString(object? prop, bool end = false)
    {
        if (prop is not null)
        {
            return prop.ToString() + (end ? "" : ", ");
        }

        return String.Empty;
    }

    // virtual значит, что может быть переопределен (override)
    // в классах потомках
    public virtual string SayHello() => $"Привет, {this}"; 
    
    public abstract int? Payment { get; } // все потоки обязаны реализовать данное свойство

    public abstract bool IsGood();

    public bool IsActive()
    {
        return false;
    }
}