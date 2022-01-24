namespace ActionFilter.Extensions;

public static class StringExtension
{
    public static string ReverseIt(this string value)
    {
        var chars = value.ToCharArray();
        Array.Reverse(chars);

        return new string(chars);
    }
}