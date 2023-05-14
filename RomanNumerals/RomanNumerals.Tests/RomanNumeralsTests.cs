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

        [Fact]
        public void Convert_ShouldReturnII_When2(){

            string result = RomanNumerals.Convert(2);

            Assert.Equal("II", result);
        }

        [Fact]
        public void Convert_ShouldReturnIII_When3()
        {

            string result = RomanNumerals.Convert(3);

            Assert.Equal("III", result);
        }

        [Fact]
        public void Convert_ShouldReturnIV_When4()
        {

            string result = RomanNumerals.Convert(4);

            Assert.Equal("IV", result);
        }
    }
}