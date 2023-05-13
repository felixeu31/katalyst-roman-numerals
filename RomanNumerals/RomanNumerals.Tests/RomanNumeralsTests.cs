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

        [Fact]
        public void Convert_ShouldReturnI_When1()
        {
            string result = RomanNumerals.Convert(1);

            Assert.Equal("I", result);
        }

        [Fact]
        public void Convert_ShouldReturnII_When2()
        {
            string result = RomanNumerals.Convert(2);

            Assert.Equal("II", result);
        }
        [Fact]
        public void Convert_ShouldReturnIII_When3()
        {
            string result = RomanNumerals.Convert(3);

            Assert.Equal("III", result);
        }
    }
}