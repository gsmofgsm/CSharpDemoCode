using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class StringDemos
    {
        [Fact]
        public void BasicStrings()
        {
            // arrange
            var fixture = new Fixture();
            var sut = new NameJoiner();

            //var firstName = fixture.Create<string>();
            //var lastName = fixture.Create<string>();
            var firstName = fixture.Create<string>("First_");
            var lastName = fixture.Create<string>("Last_");

            // act
            var result = sut.Join(firstName, lastName);

            // assert
            Assert.Equal(firstName + ' ' + lastName, result);
        }

        [Fact]
        public void Chars()
        {
            // arrange
            var fixture = new Fixture();

            var anonChar = fixture.Create<char>();

            // etc.
        }
    }
}
