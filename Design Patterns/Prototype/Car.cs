namespace Prototype;

public class Car : ICar, ICloneableCar
{
    private CarType Type { get; }
    private string Color { get; set; }
    private string Number { get; set; }
    
    public Car(CarType type, string color, string number)
    {
        Type = type;
        Color = color;
        Number = number;
    }

    public Car Clone()
    {
        return new Car(Type, Color, Number);
    }

    public void SetColor(string newColor)
    {
        Color = newColor;
    }

    public void SetNumber(string newNumber)
    {
        Number = newNumber;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"This car is {Color} {Type}, with number: {Number}");
    }
}