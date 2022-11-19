namespace WorkWithDelegates;

public class Broadcaster5
{
    private const int INTERVAL = 3;
    
    public class SendMessageEventArgs : EventArgs
    {
        public string Message { get; init; }

        public SendMessageEventArgs(string message) => Message = message;
    }

    // EventHandler<T> = delegate void Название(object sender, T args)
    public event EventHandler<SendMessageEventArgs>? OnSendMessage; 

    public void Run()
    {
        int counter = 0;
        while (true)
        {
            SendMessage($"New message {counter}");
            counter++;
            Thread.Sleep(INTERVAL * 1000);
        }
    }

    private void SendMessage(string message) => 
        OnSendMessage?.Invoke(this, new SendMessageEventArgs(message));
}