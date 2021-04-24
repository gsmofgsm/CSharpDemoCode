using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class DebugMessageBuffer
    {
        public List<string> Messages { get; set; } = new List<string>();

        public int MessagesWritten { get; private set; }

        public void WriteMessages()
        {
            foreach (var messages in Messages)
            {
                // Do something with message...
                MessagesWritten++;
            }
        }
    }
}
