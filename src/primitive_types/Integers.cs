namespace console_app.src.primitive_types;

internal class Integers()
{
    byte Byte = 8;
    sbyte S_Byte = -8;

    short Short = -16;
    ushort U_Short = 16;

    int Int = -32;
    uint U_Int = 32;

    long Long = -64L; // uses "L"
    ulong U_Long = 64L; // uses "L"

    // Computado em runtime
    nint N_Int = -32;
    nuint N_U_Int = 32;
}
