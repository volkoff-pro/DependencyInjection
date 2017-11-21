using System;
using NUnit.Framework;
using NSubstitute;
using Ch1;

namespace Ch1.Tests
{
    [TestFixture]
    public class SalutationTests
    {
        [Test]
        public void ExclaimWillWriteCorrectMessageToMessageWriter()
        {
            var writeMock = Substitute.For<IMessageWriter>();
            var sut = new Salutation(writeMock);
            sut.Exclaim();
            writeMock.Received().Write(Arg.Is<string>(x => x == "Hello DI!"));
        }
    }
}