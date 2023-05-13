namespace RomanNumerals.Tests;

public class RomanNumerals
{
    private static Dictionary<int, string> _romanSymbols = new()
    {
        { 1, "I" },
        { 5, "V" },
        { 10, "X" },
        { 50, "L" },
        { 100, "C" },
        { 500, "D" },
        { 1000, "M" },
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