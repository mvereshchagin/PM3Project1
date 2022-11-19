namespace WorkWithDelegates;

public class Broadcaster2
{
    private Action<string>? _listeners;
    private const int interval = 3;
    private bool _isStopped = false;
    

    public void Subscribe(Action<string> listener)
    {
        _listeners += listener;
    }

    public void Unsubscribe(Action<string> listener)
    {
        if(_listeners is not null)
            _listeners -= listener;
    }

    public void Run()
    {
        _isStopped = false;
        int counter = 0;
        while (true)
        {
            _listeners?.Invoke($"New message {counter}");
            counter++;
            if (_isStopped)
                break;
            Thread.Sleep(interval * 1000);
        }
        
        Console.WriteLine("Run has been finished");
    }

    public void Stop()
    {
        _isStopped = true;
    }
}