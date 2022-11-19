namespace Utils;

public static class StringUtils
{
    public static string? FirstLetterToUpper(string? str)
    {
        if (String.IsNullOrEmpty(str)) return str;

        return str.Substring(0, 1).ToUpper() + str.Substring(1);
    }
}