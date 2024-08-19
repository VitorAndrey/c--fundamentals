namespace console_app.src.method;

internal class Method
{
    //
    int sum(int i, int j) => i + j; // arrow syntax for 1 line return

    //   👇          👇
    (int age, string name) person() => (22, "Jhon"); // double return

    // optinal params must be the last ones
    string optional(string name = "Jhon") => name; // optinal name with "Jhon" as default

    void main()
    {
        Method methods = new Method();

        // named params
        methods.sum(i: 1, j: 2);

        // optinal params
        methods.optional();
        methods.optional(name: "Jane");

        Console.WriteLine(methods.person().age + methods.person().name); // acess by key
        // or
        (int resAge, string resName) = methods.person(); // tuple deconstruction *js destructuring*
        Console.WriteLine(resAge + resName);
    }
}
