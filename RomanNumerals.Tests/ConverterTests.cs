using NUnit.Framework;

namespace RomanNumerals.Tests
{
    public class ConverterTests
    {
        [TestCase("XXVI", 26)]
        [TestCase("MM", 2000)]
        public void Converter_Convert_WithSimpleNumerals_ReturnsCorrectValue(string input, int expected)
        {
            // Assemble
            var sut = new Converter();

            // Act
            var actual = sut.Convert(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}