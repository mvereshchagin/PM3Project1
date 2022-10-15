using System.Security;
using System.Text;

namespace PM3Project1;

public class Student : Human // наследование от класса Human
{
    public Student(string name, string surname) : base(name, surname)
    {}

    public Student() : this("Not", "Sure")
    { }

    public string Program { get; set; } = null!;
    public string? Direction { get; set; }
    
    public bool IsPassedExams { get; set; }
    
    public int Course { get; set; }

    public override string ToString()
    {
        var strHuman = base.ToString();
        string prefix = (Gender == Gender.Male ? "студент" : "студентка");
        
        return $"{prefix} {Program}, {PropertyToString(Direction)}курс {Course} {strHuman}";
    }

    // перопрделение метода
    public override int? Payment
    {
        get
        {
            if (IsPassedExams)
                return 2300;
            return null;
        }
    }

    public override bool IsGood()
    {
        return false;
    }

    // скртие метода. Используется очень редко
    public new bool IsActive()
    {
        return Payment is not null;
    }
}