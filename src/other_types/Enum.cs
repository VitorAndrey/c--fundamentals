namespace console_app.src.other_types;

public class Enum()
{
    enum Options
    {
        Yes,
        No,
        Number = -1
    }

    void Answer()
    {
        Options answer = Options.Yes;

        int number = (int)Options.Number; // type casting

        Console.WriteLine(answer + number);
    }
}
