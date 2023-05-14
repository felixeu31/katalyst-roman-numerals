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

        var romanOrder1Value = 1;
        var romanOrder2Value = 5;
        var romanOrder3Value = 5;
        
        if(amount == (romanOrder2Value + romanOrder1Value * 3))
        {
            return $"{RomanSymbols[romanOrder2Value]}{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder1Value]}";
        }

        if(amount == (romanOrder2Value + romanOrder1Value * 2))
        {
            return $"{RomanSymbols[romanOrder2Value]}{RomanSymbols[romanOrder1Value]}{RomanSymbols[romanOrder1Value]}";
        }
        
        if(amount == (romanOrder2Value + romanOrder1Value))
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