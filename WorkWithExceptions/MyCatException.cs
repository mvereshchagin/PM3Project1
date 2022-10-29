namespace WorkWithExceptions;

public class MyCatException : Exception
{
    public Cat Cat { get; }
    
    public MyCatException(string message, Cat cat) : base(message: message)
    {
        Cat = cat;
    }
}