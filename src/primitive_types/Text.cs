using System.Text;

namespace console_app.src.primitive_types;

internal class Text()
{
    char Char = 'a';
    string String = "string"; // STRING ARE ACTUALY REFERENCE TYPES *IMUTABLES*

    string Path = @"C:\teste\vitor"; // verbatim string literal *ignore scaped*
    string path = "C:\\teste\\vitor"; // scaped chars *\t*

    private void PrintParagraph()
    {
        string paragraph = $"text {String} interpolation";
    } // string interpolation

    private void BuildString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append("Hello");
        Console.WriteLine(stringBuilder.ToString());
    } // for robust solutions

    private void FormatString()
    {
        Console.WriteLine(string.Format("Seu nome é {0}", "Vitor"));
    } // insert params
}
