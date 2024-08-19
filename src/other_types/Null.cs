namespace console_app.src.other_types;

internal class Null()
{
    void method()
    {
        int? idade = null; // "?" for nullable

        if (!idade.HasValue)
            return;

        Console.WriteLine(idade);
    }
}
