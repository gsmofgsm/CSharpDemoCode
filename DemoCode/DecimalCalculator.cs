using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class DecimalCalculator
    {
        public decimal Value { get; private set; }

        public void Subtract(decimal number)
        {
            Value -= number;
        }

        public void Add(decimal number)
        {
            Value += number;
        }
    }
}
