namespace console_app.src.other_types;

internal class Object()
{
    void method()
    {
        object Object; // can be declared without initialization
        object user = new User();

        // user.???? // does not infer types, no intelicense

        Object = "hi";

        Console.WriteLine(Object.ToString() + user);
    }
}
