namespace console_app.src.reference_types;

internal class List
{
    void method()
    {
        List<int> inteiros = new List<int>();

        inteiros.Add(1);
        inteiros.Remove(1); // Remove Element, not position

        Console.WriteLine(inteiros.Count + inteiros[0] + inteiros.First());
    }
}
