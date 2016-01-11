namespace DeathlyEnterprises.Networking
{
    public interface IMessage
    {
        string MessageType { get; }
        string MessageContents { get; }
        int MessageContentSize { get; }
    }
}