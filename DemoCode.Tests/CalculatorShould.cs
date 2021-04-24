using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class CalculatorShould
    {
        [Theory]
        [InlineData(1, 2)] // AddTwoPositiveNumbers
        [InlineData(0, 2)] // AddZeroAndPositiveNumbers
        [InlineData(-5, 1)] // AddNegativeAndPositiveNumbers
        public void AddNumbers(int a, int b)
        {
            var sut = new Calculator();

            sut.Add(a);
            sut.Add(b);

            Assert.Equal(a + b, sut.Value);
        }
    }
}
