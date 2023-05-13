namespace RomanNumerals.Tests;

public class RomanNumerals
{
    public static string Convert(int amount)
    {
        if (amount.Equals(1))
        {
            return "I";
        }

        return string.Empty;
    }
}