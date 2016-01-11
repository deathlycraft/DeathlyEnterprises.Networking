using DeathlyEnterprises.Core.DependencyInjection;

namespace DeathlyEnterprises.Networking
{
    [Injectable(InjectableLifestyle.Singleton)]
    public interface IMessageFactory
    {
        IMessage CreateMessage<TMessage>(TMessage message);
    }
}