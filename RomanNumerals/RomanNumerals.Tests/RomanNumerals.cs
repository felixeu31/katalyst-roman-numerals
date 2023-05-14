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
        int hundredsDigit = 0;
        int tensDigit = 0;
        int unitsDigit = 0;

        var digits = amount.ToString().Select(x => (int)char.GetNumericValue(x)).ToList();

        if (amount is >= 100)
        {
            hundredsDigit = digits[0];
            tensDigit = digits[1];
            unitsDigit = digits[2];
        }
        else if (amount is >= 10 and < 100)
        {
            tensDigit = digits[0];
            unitsDigit = digits[1];
        }
        else
        {
            unitsDigit = digits[0];
        }

        string centsRomanNumeral = ConvertToRomanNumeral(hundredsDigit * 100, 100, 500, 1000);

        string tensRomanNumeral = ConvertToRomanNumeral(tensDigit * 10, 10, 50, 100);

        string unitsRomanNumeral = ConvertToRomanNumeral(unitsDigit, 1, 5, 10);

        return $"{centsRomanNumeral}{tensRomanNumeral}{unitsRomanNumeral}";

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