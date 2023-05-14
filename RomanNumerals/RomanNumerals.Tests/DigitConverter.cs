namespace RomanNumerals.Tests;

public class DigitConverter
{
    private readonly int _magnitude;
    private readonly int _inferiorOrderRomanValue;
    private readonly int _middleOrderRomanValue;
    private readonly int _superiorOrderRomanValue;

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

    public DigitConverter(int magnitude)
    {
        _magnitude = magnitude;
        _inferiorOrderRomanValue = 1 * magnitude;
        _middleOrderRomanValue = 5 * magnitude;
        _superiorOrderRomanValue = 10 * magnitude;
    }

    public string Convert(int digit)
    {
        var amount = digit * _magnitude;

        if (RomanSymbols.ContainsKey(amount))
        {
            return RomanSymbols[amount];
        }

        if (amount == (_superiorOrderRomanValue - _inferiorOrderRomanValue))
        {
            return $"{RomanSymbols[_inferiorOrderRomanValue]}{RomanSymbols[_superiorOrderRomanValue]}";
        }

        if (amount == (_middleOrderRomanValue + _inferiorOrderRomanValue * 3))
        {
            return
                $"{RomanSymbols[_middleOrderRomanValue]}{RomanSymbols[_inferiorOrderRomanValue]}{RomanSymbols[_inferiorOrderRomanValue]}{RomanSymbols[_inferiorOrderRomanValue]}";
        }

        if (amount == (_middleOrderRomanValue + _inferiorOrderRomanValue * 2))
        {
            return $"{RomanSymbols[_middleOrderRomanValue]}{RomanSymbols[_inferiorOrderRomanValue]}{RomanSymbols[_inferiorOrderRomanValue]}";
        }

        if (amount == (_middleOrderRomanValue + _inferiorOrderRomanValue))
        {
            return $"{RomanSymbols[_middleOrderRomanValue]}{RomanSymbols[_inferiorOrderRomanValue]}";
        }

        if (amount == (_middleOrderRomanValue - _inferiorOrderRomanValue))
        {
            return $"{RomanSymbols[_inferiorOrderRomanValue]}{RomanSymbols[_middleOrderRomanValue]}";
        }

        if (amount == (_inferiorOrderRomanValue * 3))
        {
            return $"{RomanSymbols[_inferiorOrderRomanValue]}{RomanSymbols[_inferiorOrderRomanValue]}{RomanSymbols[_inferiorOrderRomanValue]}";
        }

        if (amount == (_inferiorOrderRomanValue * 2))
        {
            return $"{RomanSymbols[_inferiorOrderRomanValue]}{RomanSymbols[_inferiorOrderRomanValue]}";
        }

        return string.Empty;
    }
}