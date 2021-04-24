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

        [Fact]
        public void OmitSettingSpecificProperties()
        {
            // arrange
            var fixture = new Fixture();

            var flight = fixture.Build<FlightDetails>()
                                .Without(x => x.ArrivalAirportCode)
                                .Without(x => x.DepartureAirportCode)
                                .Create();

            // etc.
        }

        [Fact]
        public void OmitSettingAllProperties()
        {
            // arrange
            var fixture = new Fixture();

            var flight = fixture.Build<FlightDetails>()
                                .OmitAutoProperties()
                                .Create();

            // etc.
        }

        [Fact]
        public void CustomizedBuilding()
        {
            // arrange
            var fixture = new Fixture();

            var flight = fixture.Build<FlightDetails>()
                                .With(x => x.ArrivalAirportCode, "LAX")
                                .With(x => x.DepartureAirportCode, "LHR")
                                .Create();

            // etc.
        }

        [Fact]
        public void CustomizedBuildingWithActions()
        {
            // arrange
            var fixture = new Fixture();

            var flight = fixture.Build<FlightDetails>()
                                .With(x => x.ArrivalAirportCode, "LAX")
                                .With(x => x.DepartureAirportCode, "LHR")
                                .Without(x => x.MealOptions)
                                .Do(x => x.MealOptions.Add("Chicken"))
                                .Do(x => x.MealOptions.Add("Fish"))
                                .Create();

            // etc.
        }

        [Fact]
        public void CustomizedBuildingForAllTypesInFixture()
        {
            // arrange
            var fixture = new Fixture();

            fixture.Customize<FlightDetails>(fd =>
                fd.With(x => x.ArrivalAirportCode, "LAX")
                  .With(x => x.DepartureAirportCode, "LHR")
                  .With(x => x.AirlineName, "Fly Fly Premium Air")
                  .Without(x => x.MealOptions)
                  .Do(x => x.MealOptions.Add("Chicken"))
                  .Do(x => x.MealOptions.Add("Fish"))); // notice no Create() is required
            // this is only HOW to create in the future

            var flight1 = fixture.Create<FlightDetails>();
            var flight2 = fixture.Create<FlightDetails>();

            // etc.
        }
    }
}
