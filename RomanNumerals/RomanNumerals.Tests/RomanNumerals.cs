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
        return ConvertToRomanNumeral(amount, 10, 1, 5);
    }

    private static string ConvertToRomanNumeral(int amount, int romanOrder3Value, int romanOrder1Value,
        int romanOrder2Value)
    {

        if (RomanSymbols.ContainsKey(amount))
        {
            return RomanSymbols[amount];
        } 

        if (amount == (romanOrder3Value - romanOrder1Value))
        {
            return $"{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder3Value]}";
        }

        if (amount == (romanOrder2Value + romanOrder1Value * 3))
        {
            return
                $"{RomanSymbols[romanOrder2Value]}{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder1Value]}";
        }

        if (amount == (romanOrder2Value + romanOrder1Value * 2))
        {
            return $"{RomanSymbols[romanOrder2Value]}{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder1Value]}";
        }

        if (amount == (romanOrder2Value + romanOrder1Value))
        {
            return $"{RomanSymbols[romanOrder2Value]}{RomanSymbols[romanOrder1Value]}";
        }

        if (amount == (romanOrder2Value - romanOrder1Value))
        {
            return $"{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder2Value]}";
        }

        if (amount == (romanOrder1Value * 3))
        {
            return $"{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder1Value]}";
        }

        if (amount == (romanOrder1Value * 2))
        {
            return $"{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder1Value]}";
        }

        return string.Empty;
    }
}