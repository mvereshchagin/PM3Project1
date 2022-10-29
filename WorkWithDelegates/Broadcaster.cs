namespace WorkWithDelegates;

public class Broadcaster
{
    public delegate void SendMessage(string message);

    private List<SendMessage> _listeners = new();
    private const int _interval = 3;
    private bool _isStopped = false;
    

    public void Subscribe(SendMessage listener)
    {
        _listeners.Add(listener);
    }

    public void Unsubscribe(SendMessage listener)
    {
        _listeners.Remove(listener);
    }

    public void Run()
    {
        _isStopped = false;
        int counter = 0;
        while (true)
        {
            foreach (var listener in _listeners)
                listener?.Invoke(message: $"New message {counter}");
            counter++;
            if (_isStopped)
                break;
            Thread.Sleep(_interval * 1000);
        }
        
        Console.WriteLine("Run has been finished");
    }

    public void Stop()
    {
        _isStopped = true;
    }
}