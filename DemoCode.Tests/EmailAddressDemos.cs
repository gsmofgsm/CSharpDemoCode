using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutoFixture;
using System.Net.Mail;

namespace DemoCode.Tests
{
    public class EmailAddressDemos
    {
        [Fact]
        public void Email()
        {
            // arrange
            var fixture = new Fixture();

            //string localPart = fixture.Create<EmailAddressLocalPart>().LocalPart;
            //string domain = fixture.Create<DomainName>().Domain;

            //string fullAddress = $"{localPart}@{domain}";

            MailAddress email = fixture.Create<MailAddress>();

            var sut = new EmailMessage(email.Address,
                                        fixture.Create<string>(),
                                        fixture.Create<bool>());

            // etc.
        }
    }
}
