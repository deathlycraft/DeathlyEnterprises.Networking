using System;

namespace DeathlyEnterprises.Networking
{
    public class DefaultMessageFactory : IMessageFactory
    {
        public IMessage CreateMessage<TMessage>(TMessage message)
        {
            throw new NotImplementedException();
        }
    }
}