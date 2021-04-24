using Xunit;
using AutoFixture;
using AutoFixture.Xunit2;

namespace DemoCode.Tests
{
    public class CalculatorShould
    {
        [Theory]
        [InlineAutoData] // AddTwoPositiveNumbers
        [InlineAutoData(0)] // AddZeroAndPositiveNumbers
        [InlineAutoData(-5)] // AddNegativeAndPositiveNumbers
        public void AddNumbers(int a, int b, Calculator sut)
        {
            sut.Add(a);
            sut.Add(b);

            Assert.Equal(a + b, sut.Value);
        }

        [Theory]
        [AutoData]
        public void AddTwoPositiveNumbers(int a, int b, Calculator sut)
        {
            sut.Add(a);
            sut.Add(b);

            Assert.Equal(a + b, sut.Value);
        }
    }
}
