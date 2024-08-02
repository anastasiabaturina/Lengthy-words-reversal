namespace LengthyWordsReversal;

public class Program
{
    public static void Main()
    {
        var result = LongWordConverter.ConvertWords("This is the test with ascii words");

        Console.WriteLine(result);
    }
}