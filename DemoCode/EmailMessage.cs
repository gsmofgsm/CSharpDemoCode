using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class EmailMessage
    {
        private string _somePrivateField;
        public string SomePublicField;

        public EmailMessage(string toAddress, string messageBody, bool isImportant)
        {
            ToAddress = toAddress;
            MessageBody = messageBody;
            IsImportant = isImportant;
        }

        public Guid Id { get; set; }

        public string ToAddress { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public bool IsImportant { get; set; }

        public EmailMessageType MessageType { get; set; }
        private string SomePrivateProperty { get; set; }
    }
}
