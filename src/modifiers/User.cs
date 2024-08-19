namespace console_app.src.modifiers;

// internal is the default for classes
// You can use static in classes for preventing from creating instances
public class User
{
    // STATIC props
    static int age { get; set; } // shared among all instances of the class *as well as methods*

    // PRIVATE is the default for methods and properties
    private void Private() { } // accessible only inside the class

    // PUBLIC
    public void Public() { } // allows access from anywhere

    // INTERNAL
    internal void Internal() { } // allows access only within the same project/assembly

    // PROTECTED
    protected void Protected() { } // allows access within the class and by derived classes

    // STATIC
    //belongs to the class itself, not to instances, so no need for instantiation
    public static void Say(string text) => Console.WriteLine(text);
}
