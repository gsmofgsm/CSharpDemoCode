using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class NameJoiner
    {
        public int MyProperty { get; set; }

        public string Join(string firstName, string lastName)
        {
            return firstName + ' ' + lastName;
        }
    }
}
