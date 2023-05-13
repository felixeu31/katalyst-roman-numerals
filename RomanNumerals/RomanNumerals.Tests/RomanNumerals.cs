namespace RomanNumerals.Tests;

public class RomanNumerals
{
    public static string Convert(int amount)
    {
        if (amount.Equals(1))
        {
            return "I";
        }

        if (amount.Equals(2))
        {
            return "II";
        }

        if (amount.Equals(3))
        {
            return "III";
        }

        return string.Empty;
    }
}