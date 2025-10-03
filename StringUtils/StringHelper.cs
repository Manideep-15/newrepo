namespace StringUtils;

public static class StringHelper
{
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;
        var normalized = input.ToLower().Replace(" ", "");
        var reversed = new string(normalized.Reverse().ToArray());
        return normalized == reversed;
    }

    public static string Reverse(string input)
    {
        if (input == null) return null;
        return new string(input.Reverse().ToArray());
    }

    public static int WordCount(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return 0;
        return input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
