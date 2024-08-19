using console_app.src.classes;
using console_app.src.enums;
using console_app.src.modifiers;
using console_app.src.primitive_types;

namespace console_app;

public class Server
{
    static void Main(string[] args)
    {
        Server server = new Server();

        server.Car();
    }

    void Date()
    {
        var date = new Date();
        date.Now();
    }

    void Shout()
    {
        User.Say("Hello!");
    }

    void Car()
    {
        Car car = new Car(brand: "BMW")
        {
            Model = "320i",
            Color = Colors.White,
            Year = new DateOnly(2022, 01, 01),
        };

        car.ModelName();
    }
}
