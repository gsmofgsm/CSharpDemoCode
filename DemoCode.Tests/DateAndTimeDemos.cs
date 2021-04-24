using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class DateAndTimeDemos
    {
        [Fact]
        public void DateTimes()
        {
            // arrange
            var fixture = new Fixture();
            //DateTime logTime = new DateTime(2020, 1, 21);
            DateTime logTime = fixture.Create<DateTime>();

            // act
            LogMessage result = LogMessageCreator.Create(fixture.Create<string>(), logTime);

            // assert
            Assert.Equal(logTime.Year, result.Year);
        }

        [Fact]
        public void TimeSpans()
        {
            // arrange
            var fixture = new Fixture();

            TimeSpan logTime = fixture.Create<TimeSpan>();

            // etc
        }
    }
}
