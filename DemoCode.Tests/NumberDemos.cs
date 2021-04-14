using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoCode.Tests
{
    public class NumberDemos
    {
        [Fact]
        public void Ints()
        {
            // arrange
            var sut = new IntCalculator();

            // act
            sut.Subtract(1);

            // assert
            Assert.True(sut.Value < 0);
        }
    }
}
