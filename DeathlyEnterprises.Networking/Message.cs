using DeathlyEnterprises.Core.DependencyInjection;

namespace DeathlyEnterprises.Networking
{
    [Injectable(InjectableLifestyle.Transient)]
    public interface IMessage
    {
    }

    public class Message : IMessage
    {
    }
}