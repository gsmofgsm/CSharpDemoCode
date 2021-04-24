using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class EmailMessageBuffer
    {
        public List<EmailMessage> Emails { get; private set; } = new List<EmailMessage>();

        public void SendAll()
        {
            foreach (var email in Emails)
            {
                // Send email
            }
        }

        public void Add(EmailMessage message)
        {
            Emails.Add(message);
        }
    }
}
