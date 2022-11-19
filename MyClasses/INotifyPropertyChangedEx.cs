namespace MyClasses;

public class PropertyChangedExEventArgs : EventArgs
{
    public PropertyChangedExEventArgs(string? propertyName, object? value)
    {
        PropertyName = propertyName;
        Value = value;
    }
    
    public string? PropertyName { get; init; }
    public object? Value { get; init; }
}

public interface INotifyPropertyChangedEx
{
    public event EventHandler<PropertyChangedExEventArgs>? PropertyChangedEx;
}