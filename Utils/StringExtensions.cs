namespace Utils;

public static class StringExtensions
{
    public static string? FirstLetterToUpper(this string? str)
    {
        if (String.IsNullOrEmpty(str)) return str;

        return str.Substring(0, 1).ToUpper() + str.Substring(1);
    }
}