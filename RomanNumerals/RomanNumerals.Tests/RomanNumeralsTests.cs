namespace RomanNumerals.Tests
{
    /// <summary>
    /// Roman numerals tests
    /// </summary>
    /// <remarks>dotnet watch test --project .\RomanNumerals.Tests\RomanNumerals.Tests.csproj</remarks>
    public class RomanNumeralsTests
    {
        [Fact]
        public void Convert_ShouldReturnEmpty_When0()
        {
            // Act
            string result = RomanNumerals.Convert(0);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(5, "V")]
        public void Convert_ShouldReturnRomanNumeralRepresentation_WhenDirectConversion(int arabicNumber, string romanNumeral)
        {
            string result = RomanNumerals.Convert(arabicNumber);

            Assert.Equal(romanNumeral, result);
        }
    }
}