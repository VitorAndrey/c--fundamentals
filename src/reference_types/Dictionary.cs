namespace console_app.src.reference_types;

internal class Dictionary
{
    Dictionary<string, string> user = new Dictionary<string, string>();

    void method()
    {
        user.Add("name", "Jhon Doe");
        user.Add("age", "12");

        string value = user["name"]; // acess by value, not by index
    }
}
