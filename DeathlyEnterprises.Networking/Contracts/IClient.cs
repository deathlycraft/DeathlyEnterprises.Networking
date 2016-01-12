namespace DeathlyEnterprises.Networking
{
    public interface IClient
    {
        void Connect(string ipAddress, int port);
    }
}