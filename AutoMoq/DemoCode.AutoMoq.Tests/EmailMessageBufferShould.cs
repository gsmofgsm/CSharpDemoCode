using Xunit;
using AutoFixture;
using Moq;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace DemoCode.AutoMoq.Tests
{
    public class EmailMessageBufferShould
    {
        [Fact]
        public void SendEMailToGateway_Manual_Moq()
        {
            // arrange
            var fixture = new Fixture();

            var mockGateway = new Mock<IEmailGateway>();

            var sut = new EmailMessageBuffer(mockGateway.Object);

            sut.Add(fixture.Create<EmailMessage>());

            // act
            sut.SendAll();

            // assert
            mockGateway.Verify(x => x.Send(It.IsAny<EmailMessage>()), Times.Once());
        }

        [Fact]
        public void SendEmailToGateway_AutoMoq()
        {
            // arrange
            var fixture = new Fixture();
            fixture.Customize(new AutoMoqCustomization());
            var mockGateway = fixture.Freeze<Mock<IEmailGateway>>();

            var sut = fixture.Create<EmailMessageBuffer>();

            sut.Add(fixture.Create<EmailMessage>());

            // act
            sut.SendAll();

            // assert
            mockGateway.Verify(x => x.Send(It.IsAny<EmailMessage>()), Times.Once());
        }

        [Theory]
        [AutoMoqData]
        public void SendEmailToGateway_AutoMoq_DataDriven(EmailMessage message,
                                                          [Frozen] Mock<IEmailGateway> mockGateway,
                                                          EmailMessageBuffer sut)
        {
            // arrange
            sut.Add(message);

            // act
            sut.SendAll();

            // assert
            mockGateway.Verify(x => x.Send(It.IsAny<EmailMessage>()), Times.Once());
        }
    }
}
