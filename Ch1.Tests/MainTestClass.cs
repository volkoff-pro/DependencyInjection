using System;
using NUnit.Framework;
using Ch1;

namespace Ch1.Tests
{
    [TestFixture]
    public class MainTestClass
    {
        [Test]
        public void ConsoleMessageWriterTest_WhenCreated_ReturnsNotNull()
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            Assert.IsNotNull(writer);
        }
    }
}
