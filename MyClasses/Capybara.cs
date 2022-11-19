using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MyClasses;

public class Capybara : INotifyPropertyChanged, INotifyPropertyChanging, INotifyPropertyChangedEx
{
    private const int _starveInterval = 1;
    private string _name;
    private int _cuteness;
    private int _weight;

    public int Cuteness
    {
        get => _cuteness;
        set => SetField(ref _cuteness, value);
        // set
        // {
        //     _cuteness = value;
        //     // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cuteness"));
        //     // OnPropertyChanged("Cuteness");
        //     OnPropertyChanged();
        // }
    }

    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
        // set
        // {
        //     _name = value;
        //     //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
        //     // OnPropertyChanged("Name");
        //     OnPropertyChanged();
        // }
    }

    public int Weight
    {
        get => _weight;
        set => SetField(ref _weight, value);
    }

    private int _hungLevel;
    private INotifyPropertyChanging _notifyPropertyChangingImplementation;

    public void Feed(int feedCount)
    {
        _hungLevel += feedCount;
    }

    public Capybara(string name)
    {
        Name = name;

        var timer = new System.Timers.Timer(_starveInterval * 1000);
        timer.Elapsed += (sender, args) => _hungLevel = (_hungLevel > 0 ? _hungLevel - 1 : 0);
        timer.Start();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        OnPropertyChanging(propertyName);
        field = value;
        OnPropertyChanged(propertyName);
        OnPropertyChangedEx(propertyName, value);
        return true;
    }

    public event PropertyChangingEventHandler? PropertyChanging;
    
    protected virtual void OnPropertyChanging([CallerMemberName] string? propertyName = null)
    {
        PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
    }

    public event EventHandler<PropertyChangedExEventArgs>? PropertyChangedEx;
    
    protected virtual void OnPropertyChangedEx(string? propertyName, object? value)
    {
        PropertyChangedEx?.Invoke(this, new PropertyChangedExEventArgs(propertyName, value));
    }
}