using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class Calculator
    {
        public int Value { get; private set; }

        public void Add(int number)
        {
            Value += number;
        }
    }
}
