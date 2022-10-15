namespace PM3Project1;

public class Teacher : Human
{
    public Teacher(string name, string surname) : base(name, surname) // вызов конструктора базового класса
    {}

    public Teacher() : this("Not", "Sure") // вызов конструктора того же класса, но с другой сигнатурой
    { }
    
    public string Occupation { get; set; } = null!;

    public string? Degree { get; set; }

    public string? Title { get; set; }

    public override string ToString()
    {
        string strHuman = base.ToString();
        return $"{Occupation}, {Title}, {PropertyToString(Degree)}{strHuman}";
    }

    public override string SayHello() => $"Здравствуйте, {this}";

    public override int? Payment
    {
        get
        {
            if (Degree is not null)
                return 1000000;
            return 500000;
        }
    }

    public override bool IsGood()
    {
        return true;
    }
}