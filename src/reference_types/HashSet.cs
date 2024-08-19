namespace console_app.src.reference_types;

internal class HashSet // Like a list but with unique values
{
    void method()
    {
        HashSet<int> set = new HashSet<int>();

        set.Add(1);
        // set.Add(1); // cannot add repeated values
    }
}
