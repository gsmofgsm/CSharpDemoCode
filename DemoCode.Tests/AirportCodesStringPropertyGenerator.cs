using AutoFixture.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode.Tests
{
    public class AirportCodesStringPropertyGenerator : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            // See if we are trying to create a value for a property
            var propertyInfo = request as PropertyInfo;

            if (propertyInfo is null)
            {
                // this specimen builder does not apply to current request
                return new NoSpecimen(); // Null is not a valid specimen so return NoSpecimen
            }

            // Now we know we're dealing with a property, are we creating
            // a value for an aireport code?
            var isAirportCodeProperty = propertyInfo.Name.Contains("AirportCode");
            var isStringProperty = propertyInfo.PropertyType == typeof(string);

            if (isAirportCodeProperty && isStringProperty)
            {
                return RandomAirportCode();
            }

            return new NoSpecimen();
        }

        private string RandomAirportCode()
        {
            if (DateTime.Now.Ticks % 2 == 0)
            {
                return "LHR";
            }

            return "PER";
        }
    }
}
