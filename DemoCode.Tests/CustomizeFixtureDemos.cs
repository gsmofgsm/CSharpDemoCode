using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class CustomizeFixtureDemos
    {
        [Fact]
        public void SettingValue()
        {
            // arrange
            var fixture = new Fixture();

            fixture.Inject<string>("LHR");

            var flight = fixture.Create<FlightDetails>();

            // etc.
        }

        [Fact]
        public void SettingValueForCustomType()
        {
            // arrange
            var fixture = new Fixture();

            fixture.Inject(new FlightDetails
            {
                DepartureAirportCode = "PER",
                ArrivalAirportCode = "LHR",
                FlightDuration = TimeSpan.FromHours(10),
                AirlineName = "Awesome Aero"
            });

            var flight1 = fixture.Create<FlightDetails>();
            var flight2 = fixture.Create<FlightDetails>();

            // etc
        }

        [Fact]
        public void CustomCreationFunction()
        {
            // arrange
            var fixture = new Fixture();

            fixture.Register<string>(() => DateTime.Now.Ticks.ToString()); 

            var string1 = fixture.Create<string>();
            var string2 = fixture.Create<string>();

            // etc.
        }

        [Fact]
        public void FreezingValues()
        {
            var fixture = new Fixture();

            //var id = fixture.Create<int>();
            //fixture.Inject(id);
            var id = fixture.Freeze<int>();

            //var customerName = fixture.Create<string>();
            //fixture.Inject(customerName);
            var customerName = fixture.Freeze<string>();

            var sut = fixture.Create<Order>();

            Assert.Equal(id + "-" + customerName, sut.ToString());
        }
    }
}
