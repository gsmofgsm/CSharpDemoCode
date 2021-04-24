using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class FlightDetails
    {
        private string _departureAirportCode;
        private string _arraivalAirportCode;

        public string DepartureAirportCode
        {
            get => _departureAirportCode;
            set
            {
                EnsureValidAirportCode(value);
                _departureAirportCode = value;
            }
        }

        public string ArrivalAirportCode
        {
            get => _arraivalAirportCode;
            set
            {
                EnsureValidAirportCode(value);
                _arraivalAirportCode = value;
            }
        }

        public TimeSpan FlightDuration { get; set; }
        public string AirlineName { get; set; }
        public List<string> MealOptions { get; set; } = new List<string>();

        private void EnsureValidAirportCode(string airportCode)
        {
            var isWrongLength = airportCode.Length != 3;

            var isWrongCase = airportCode != airportCode.ToUpperInvariant();

            if (isWrongLength || isWrongCase)
            {
                throw new Exception(airportCode + " is an invalid airport");
            }
        }
    }
}
