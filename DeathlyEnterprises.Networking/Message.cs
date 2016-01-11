using DeathlyEnterprises.Core.Attributes;

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