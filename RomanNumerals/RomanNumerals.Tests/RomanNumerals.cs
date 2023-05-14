namespace RomanNumerals.Tests;

public class RomanNumerals
{
    public static readonly DigitConverter UnitsConverter = new(1);
    public static readonly DigitConverter TensConverter = new(10);
    public static readonly DigitConverter HundredsConverter = new(100);
    public static readonly DigitConverter MillsConverter = new(1000);

    public static string Convert(int amount)
    {
        var digits = amount.ToString("D4").Select(x => (int)char.GetNumericValue(x)).ToList();

        return $"{MillsConverter.Convert(digits[0])}{HundredsConverter.Convert(digits[1])}{TensConverter.Convert(digits[2])}{UnitsConverter.Convert(digits[3])}";
    }
}