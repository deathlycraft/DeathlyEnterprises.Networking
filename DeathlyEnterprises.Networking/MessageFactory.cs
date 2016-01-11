using DeathlyEnterprises.Core.DependencyInjection;

namespace DeathlyEnterprises.Networking
{
    [Injectable(InjectableLifestyle.Singleton)]
    public interface IMessageFactory
    {
    }

    public class MessageFactory : IMessageFactory
    {
    }
}