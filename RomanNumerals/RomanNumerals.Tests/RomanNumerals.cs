namespace RomanNumerals.Tests;

public class RomanNumerals
{
    private static Dictionary<int, string> _romanSymbols = new()
    {
        { 1, "I" },
        { 2, "II" },
        { 3, "III" },
    };

    public static string Convert(int amount)
    {
        if (_romanSymbols.ContainsKey(amount))
        {
            return _romanSymbols[amount];
        }

        return string.Empty;
    }
}