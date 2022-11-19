namespace WorkWithDelegates;

public class Broadcaster3
{
    public delegate void SendMessageHandler(string message);

    private int _sendMessageSubscribersCount = 0;
    private int _maxSubsrcibersCount = 3;

    private SendMessageHandler? _onSendMessage;

    public event SendMessageHandler? OnSendMessage
    {
        add // вызывается при += к событию
        {
            if (_sendMessageSubscribersCount >= _maxSubsrcibersCount)
                return;

            _onSendMessage += value;
            
            _sendMessageSubscribersCount++;
        }

        remove // вызывается при -= к событию
        {
            if (_onSendMessage is null) return;
            
            _onSendMessage -= value;
            _sendMessageSubscribersCount--;
        }
    }


    private const int interval = 3;
    
    public void Run()
    {
        int counter = 0;
        while (true)
        {
            _onSendMessage?.Invoke($"New message {counter}");
            counter++;
            Thread.Sleep(interval * 1000);
        }
    }
}