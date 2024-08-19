namespace console_app.src.conditions;

internal class Condition
{
    int? number = 1;

    void IFandElse()
    {
        if (number is int && number is not null) { }
        else if (number <= 1) { }
        else { }
    }

    void Ternary()
    {
        bool True = true;

        string status = True ? "true" : "false";
    }

    void Switch()
    {
        string color = "white";
        int number = 5;

        string result = number switch
        {
            < 0 => "Won",
            > 0 => "lost",
            _ => "default" // "_" for default
        };

        switch (color)
        {
            case "white": { }
                break;
            case "black": { }
                break;
            default: { }
                break;
        }
    }
}
