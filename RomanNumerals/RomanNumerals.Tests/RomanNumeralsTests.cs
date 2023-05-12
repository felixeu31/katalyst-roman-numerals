namespace RomanNumerals.Tests
{
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
    }

    public class RomanNumerals
    {
        public static string Convert(int amount)
        {
            throw new NotImplementedException();
        }
    }
}