namespace DeathlyEnterprises.Networking
{
    public class DefaultMessage : IMessage
    {
        public DefaultMessage(string messageType, string messageContents, int messageContentSize)
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