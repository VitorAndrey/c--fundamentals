namespace console_app.src.loopings;

internal class Looping
{
    List<char> list = new List<char> { 'a', 'b', 'c' };

    void For()
    {
        int lengh = list.Count;

        for (int i = 0; i < lengh; i++)
            Console.WriteLine(list[i]);
    }

    void ForEach()
    {
        var dictionary = new Dictionary<string, string> { { "name", "willian" }, { "age", "12" } };

        foreach (char letter in list)
            Console.WriteLine(letter);

        foreach (var item in dictionary)
            Console.WriteLine(item.Value);
    }

    void WHILEandDOWHILE()
    {
        bool condition = false;

        while (condition)
            Console.WriteLine("Ops");

        do Console.WriteLine("Yes");
        while (condition);
    }
}
