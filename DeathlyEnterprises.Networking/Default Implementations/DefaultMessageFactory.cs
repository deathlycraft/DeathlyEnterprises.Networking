using System;
using DeathlyEnterprises.Core.Serialization;

namespace DeathlyEnterprises.Networking
{
    public class DefaultMessageFactory : IMessageFactory
    {
        private readonly ISerializer<byte[]> _serializer;

        public DefaultMessageFactory(ISerializer<byte[]> serializer)
        {
            _serializer = serializer;
        }

        public IMessage CreateMessage<TMessage>(TMessage message)
        {
            throw new NotImplementedException();
        }
    }
}