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
        var digits = amount.ToString("D4").Select(x => (int)char.GetNumericValue(x)).ToList();

        string millsRomanNumeral = ConvertToRomanNumeral(digits[0] * 1000, 1000, 5000, 10000);

        string hundredsRomanNumeral = ConvertToRomanNumeral(digits[1] * 100, 100, 500, 1000);

        string tensRomanNumeral = ConvertToRomanNumeral(digits[2] * 10, 10, 50, 100);

        string unitsRomanNumeral = ConvertToRomanNumeral(digits[3], 1, 5, 10);

        return $"{millsRomanNumeral}{hundredsRomanNumeral}{tensRomanNumeral}{unitsRomanNumeral}";

    }

    private static string ConvertToRomanNumeral(int amount, int inferiorOrderRomanValue,
        int middleOrderRomanValue, int superiorOrderRomanValue)
    {

        if (RomanSymbols.ContainsKey(amount))
        {
            return RomanSymbols[amount];
        } 

        if (amount == (superiorOrderRomanValue - inferiorOrderRomanValue))
        {
            return $"{RomanSymbols[inferiorOrderRomanValue]}{RomanSymbols[superiorOrderRomanValue]}";
        }

        if (amount == (middleOrderRomanValue + inferiorOrderRomanValue * 3))
        {
            return
                $"{RomanSymbols[middleOrderRomanValue]}{RomanSymbols[inferiorOrderRomanValue]}{RomanSymbols[inferiorOrderRomanValue]}{RomanSymbols[inferiorOrderRomanValue]}";
        }

        if (amount == (middleOrderRomanValue + inferiorOrderRomanValue * 2))
        {
            return $"{RomanSymbols[middleOrderRomanValue]}{RomanSymbols[inferiorOrderRomanValue]}{RomanSymbols[inferiorOrderRomanValue]}";
        }

        if (amount == (middleOrderRomanValue + inferiorOrderRomanValue))
        {
            return $"{RomanSymbols[middleOrderRomanValue]}{RomanSymbols[inferiorOrderRomanValue]}";
        }

        if (amount == (middleOrderRomanValue - inferiorOrderRomanValue))
        {
            return $"{RomanSymbols[inferiorOrderRomanValue]}{RomanSymbols[middleOrderRomanValue]}";
        }

        if (amount == (inferiorOrderRomanValue * 3))
        {
            return $"{RomanSymbols[inferiorOrderRomanValue]}{RomanSymbols[inferiorOrderRomanValue]}{RomanSymbols[inferiorOrderRomanValue]}";
        }

        if (amount == (inferiorOrderRomanValue * 2))
        {
            return $"{RomanSymbols[inferiorOrderRomanValue]}{RomanSymbols[inferiorOrderRomanValue]}";
        }

        return string.Empty;
    }
}