namespace WorkWithExceptions;

public class Cat
{
    #region private fields

    private string _name;

    public DateTime _lastFeedTime;
    public DateTime _lastScratchTime;

    public const int _feedPeriod = 10;
    public const int _scratchPeriod = 10;
    
    #endregion
    
    #region ctor

    public Cat(string name)
    {
        Name = name;
        _lastFeedTime = _lastScratchTime = DateTime.Now;
    }
    #endregion
    
    #region props

    public string Name
    {
        get => _name;
        set
        {
            // если имя пустое, то генерируем исключение
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Value can not be empty");

            _name = value;
        }
    }

    public string? Breed { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime DayOfBirth { get; set; }

    public int Age => DateTime.Now.Year - DayOfBirth.Year;
    
    public DateTime? DayOfVaccination { get; set; }
    
    public bool? PassportNumber { get; set; }
    #endregion
    
    #region Methods

    public void Feed()
    {
        _lastFeedTime = DateTime.Now;
        Console.WriteLine("Ням-ням");
    }

    /// <summary>
    /// Метод игнры с котом
    /// </summary>
    /// <exception cref="MyCatException">Генерируется, если кот голодный или мы его не почесали</exception>
    public void Play()
    {
        if (!IsHappy)
            throw new MyCatException(message: "А ты почесал и покормил меня прежде чем играть?", cat: this);
        
        Console.WriteLine("Вот и поиграли");
    }

    public void Scratch()
    {
        _lastScratchTime = DateTime.Now;
        Console.WriteLine("Муууууууууууууур");
    }

    public bool IsHappy
    {
        get
        {
            if (DateTime.Now.Second - _lastScratchTime.Second > _scratchPeriod)
                return false;
            if (DateTime.Now.Second - _lastFeedTime.Second > _feedPeriod)
                return false;

            return true;
        }
    }

    public void Bite()
    {
        throw new NotImplementedException();
    }

    public void Lick(string target)
    {
        if (String.IsNullOrEmpty(target))
            throw new ArgumentException("target должен быть указщан обязательно");
        
        
    }
    #endregion
    
    #region overriden

    public override string ToString() => Name;

    #endregion
}