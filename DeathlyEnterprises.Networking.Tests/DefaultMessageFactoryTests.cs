using DeathlyEnterprises.Core.Serialization;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;

namespace DeathlyEnterprises.Networking.Tests
{
    [TestFixture]
    public class DefaultMessageFactoryTests
    {
        [Test]
        public void TestCreateMessage()
        {
            //Given the following implementation of a message to be serialized and added to a DefaultMessage implementation
            const string originalMessage = "I am a message to be transfered";
            var originalMessageBytes = new byte[10];

            var serializerMock = Substitute.For<ISerializer<byte[]>>();
            serializerMock.Serialize(Arg.Any<string>()).Returns(originalMessageBytes);

            var messageFactory = new DefaultMessageFactory(serializerMock);

            //When we call the CreateMessage method and get the returned DefaultMessage
            var message = messageFactory.CreateMessage(originalMessage);

            //Then the results should be the same as what we expect it to be.
            message.MessageType.Should().Be("String");
            message.MessageContents.Should().BeSameAs(originalMessageBytes);
            message.MessageContentSize.Should().Be(originalMessageBytes.Length);
        }
    }
}