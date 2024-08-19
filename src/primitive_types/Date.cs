using System.Globalization;

namespace console_app.src.primitive_types;

public class Date()
{
    public void Day()
    {
        DateOnly day = new DateOnly(2023, 12, 1);

        Console.WriteLine(day.ToString("y", new CultureInfo("en-us")));
    }

    public void Now()
    {
        DateTime now = DateTime.Now;

        DateTime UtcNow = DateTime.UtcNow;
        DateTime BasilianTimeZone = UtcNow.AddHours(-3);

        Console.WriteLine(now);
    }
}
