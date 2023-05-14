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
        string centsRomanNumeral = string.Empty;
        string tensRomanNumeral = string.Empty;
        string unitsRomanNumeral = string.Empty;
        if (amount is >= 100 and < 1000)
        {
            var digits = amount.ToString().Select(x => (int)char.GetNumericValue(x)).ToList();

            centsRomanNumeral = ConvertToRomanNumeral(digits[0] * 100, 100, 500, 1000);

            tensRomanNumeral = ConvertToRomanNumeral(digits[1] * 10, 10, 50, 100);

            unitsRomanNumeral = ConvertToRomanNumeral(digits[2], 1, 5, 10);
        }
        else if (amount is >= 10 and < 100)
        {
            var digits = amount.ToString().Select(x => (int)char.GetNumericValue(x)).ToList();

            tensRomanNumeral = ConvertToRomanNumeral(digits[0] * 10, 10, 50, 100);

            unitsRomanNumeral = ConvertToRomanNumeral(digits[1], 1, 5, 10);

        }
        else
        {
            unitsRomanNumeral = ConvertToRomanNumeral(amount, 1, 5, 10);
        }


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