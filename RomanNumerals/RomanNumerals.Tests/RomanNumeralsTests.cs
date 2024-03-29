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
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        public void Convert_ShouldReturnRomanNumeralRepresentation_WhenDirectConversion(int arabicNumber, string romanNumeral)
        {
            string result = RomanNumerals.Convert(arabicNumber);

            Assert.Equal(romanNumeral, result);
        }

        [Theory]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(11, "XI")]
        [InlineData(16, "XVI")]
        [InlineData(66, "LXVI")]
        [InlineData(99, "XCIX")]
        [InlineData(294, "CCXCIV")]
        [InlineData(2019, "MMXIX")]
        public void Convert_ShouldReturnRomanNumeralRepresentation_WhenComposeConversion(int arabicNumber, string romanNumeral)
        {

            string result = RomanNumerals.Convert(arabicNumber);

            Assert.Equal(romanNumeral, result);
        }
    }
}