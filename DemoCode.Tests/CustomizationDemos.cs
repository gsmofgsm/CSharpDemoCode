using Xunit;
using AutoFixture;
using System;

namespace DemoCode.Tests
{
    public class CustomizationDemos
    {
        [Fact]
        public void DateTimeCustomization()
        {
            // arrange
            var fixture = new Fixture();

            //fixture.Customize(new CurrentDateTimeCustomization()); // prebuild Customization
            fixture.Customizations.Add(new CurrentDateTimeGenerator());

            var date1 = fixture.Create<DateTime>();
            var date2 = fixture.Create<DateTime>();

            // etc.
        }

        [Fact]
        public void CustomizedPipeline()
        {
            // arrange
            var fixture = new Fixture();
            fixture.Customizations.Add(new AirportCodesStringPropertyGenerator());

            var flight = fixture.Create<FlightDetails>();
            var airport = fixture.Create<Airport>();

            // etc.
        }
    }
}
