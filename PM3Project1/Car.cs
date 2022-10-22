namespace PM3Project1;

// Создан класс с конструктором, где все свойства readonly
public record Car(string Producer, string Model, int Year, string Color, int Price);

public class CarAnalog
{
    public CarAnalog(string producer, string model, int year, string color, int price)
    {
        Producer = producer;
        Model = model;
        Year = year;
        Color = color;
        Price = price;
    }
    
    public string Producer { get; init; }
    
    public string Model { get; init; }
    
    public int Year { get; init; }
    
    public string Color { get; init; }
    
    public int Price { get; init; }

    public override string ToString()
    {
        return $"Car {{ Producer = {Producer}, Model = {Model}, Year = {Year}, Color = {Color}, Price = {Price}}}";
    }

    public void Deconstruct(out string producer, out string model, out int year, out string color, out int price)
    {
        producer = Producer;
        model = Model;
        year = Year;
        color = Color;
        price = Price;
    }

    public override bool Equals(object? obj)
    {
        if (obj is CarAnalog other)
            return (Producer == other.Producer && Model == other.Model && Year == other.Year
                    && Color == other.Color && Price == other.Price);

        return false;
    }
}



public record Car2(string Producer, string Model, int Year, string Color, int Price)
{
    public int Price { get; set; }
}

public class Car2Analog
{
    public Car2Analog(string producer, string model, int year, string color, int price)
    {
        Producer = producer;
        Model = model;
        Year = year;
        Color = color;
        Price = price;
    }
    
    public string Producer { get; init; }
    
    public string Model { get; init; }
    
    public int Year { get; init; }
    
    public string Color { get; init; }
    
    public int Price { get; set; }
}

public record struct MyRGBA(int Red, int Green, int Blue, float Alpha);

public readonly record struct Point(int X, int Y);