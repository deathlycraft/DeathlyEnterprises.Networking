namespace DeathlyEnterprises.Networking
{
    public interface IMessage
    {
        string MessageType { get; }
        string MessageContents { get; }
        int MessageContentSize { get; }
    }

    public class Message : IMessage
    {
        public Message(string messageType, string messageContents, int messageContentSize)
        {
            MessageType = messageType;
            MessageContents = messageContents;
            MessageContentSize = messageContentSize;
        }

        public string MessageType { get; }
        public string MessageContents { get; }

        public int MessageContentSize { get; }
    }
}