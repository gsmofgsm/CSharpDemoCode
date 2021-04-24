﻿using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoCode.Tests
{
    public class CustomTypeDemos
    {
        [Fact]
        public void ManualCreation()
        {
            // arrange
            var sut = new EmailMessageBuffer();

            EmailMessage message = new EmailMessage("sarah@dontcodetired.com",
                                                    "Hello, hope you are well, Jason",
                                                    false);

            message.Subject = "Hi";

            // act
            sut.Add(message);

            // assert
            Assert.Single(sut.Emails);
        }

        [Fact]
        public void AutoCreation()
        {
            // arrange
            var fixture = new Fixture();
            var sut = new EmailMessageBuffer();

            EmailMessage message = fixture.Create<EmailMessage>();

            // act
            sut.Add(message);

            // assert
            Assert.Single(sut.Emails);
        }
    }
}
