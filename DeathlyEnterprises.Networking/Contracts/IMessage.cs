namespace DeathlyEnterprises.Networking
{
    public interface IMessage
    {
        string MessageType { get; }
        byte[] MessageContents { get; }
        int MessageContentSize { get; }
    }
}