namespace RomanNumerals.Tests;

public class RomanNumerals
{
    private static readonly Dictionary<int, string> RomanSymbols = new()
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
        if (RomanSymbols.ContainsKey(amount))
        {
            return RomanSymbols[amount];
        }

        if (amount.Equals(2))
        {
            return $"{RomanSymbols[1]}{RomanSymbols[1]}"; 
        }
        if (amount.Equals(3))
        {
            return $"{RomanSymbols[1]}{RomanSymbols[1]}{RomanSymbols[1]}";
        }

        return string.Empty;
    }
}