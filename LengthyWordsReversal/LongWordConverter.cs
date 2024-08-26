namespace LengthyWordsReversal;

public class LongWordConverter
{
    public static string ConvertWords(string str)
    {
        var words = str.Split(' ');
        var resultStr = new List<string>();

        foreach (var word in words)
        {
            if (word.Length >= 5)
            {
                var charArray = word.ToCharArray();
                Array.Reverse(charArray);
                var newWord = new string(charArray);
                resultStr.Add(newWord);
            }
            else
            {
                resultStr.Add(word);
            }
        }

        return string.Join(" ", resultStr);
    }
}