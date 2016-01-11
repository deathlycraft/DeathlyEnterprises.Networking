using System;
using DeathlyEnterprises.Core.DependencyInjection;

namespace DeathlyEnterprises.Networking
{
    [Injectable(InjectableLifestyle.Singleton)]
    public interface IMessageFactory
    {
        IMessage CreateMessage<TMessage>(TMessage message);
    }

    public class DefaultMessageFactory : IMessageFactory
    {
        public IMessage CreateMessage<TMessage>(TMessage message)
        {
            throw new NotImplementedException();
        }
    }
}