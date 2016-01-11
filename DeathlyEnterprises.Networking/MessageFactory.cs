using DeathlyEnterprises.Core.Attributes;

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