namespace console_app.src.other_types;

internal class Var()
{
    void method()
    {
        var nome = "Wellison";
        var number = 2;
        // error: var uninitialized; // must be initialized

        Console.WriteLine(nome + number);
    }
}
