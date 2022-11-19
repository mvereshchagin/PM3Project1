namespace WorkWithDelegates;

public class Broadcaster4
{
    private const int interval = 3;
    
    public class SendMessageEventArgs : EventArgs
    {
        public string Message { get; init; }

        public SendMessageEventArgs(string message)
        {
            Message = message;
        }
    }

    public delegate void SendMessageEventHandler(object sender, SendMessageEventArgs args);

    public event SendMessageEventHandler? OnSendMessage;

    public void Run()
    {
        int counter = 0;
        while (true)
        {
            OnSendMessage?.Invoke( this, args: new SendMessageEventArgs($"New message {counter}"));
            counter++;
            Thread.Sleep(interval * 1000);
        }
    }
}