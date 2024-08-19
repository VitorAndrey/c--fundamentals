using console_app.src.enums;

namespace console_app.src.classes;

public class Car
{
    public required string Model { get; set; } // auto implemented properties "get" and "set"
    public string Brand { get; set; }

    public DateOnly Year { get; set; }
    public Colors Color { get; set; }

    public Car(string brand)
    {
        Brand = brand;
    } // constructor method uses the classes name

    public void ModelName() => Console.WriteLine(Brand + " " + Model);
}
