using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class ObjectGraphDemos
    {
        [Fact]
        public void ManualCreation()
        {
            // quite large
        }

        [Fact]
        public void AutoCreation()
        {
            // arrange
            var fixture = new Fixture();

            Order order = fixture.Create<Order>();

            // act and assert phases...
        }
    }
}
