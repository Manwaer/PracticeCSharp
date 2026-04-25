namespace Task4
{
    public class ChatApplication
    {
        public event EventHandler<MessageEventArgs> MessageReceived;

        public void ReceiveMessage(string user, string message)
        {
            Console.WriteLine($"[Система]: Новое сообщение от {user}");
            OnMessageReceived(new MessageEventArgs(user, message));
        }

        protected virtual void OnMessageReceived(MessageEventArgs e)
        {
            MessageReceived?.Invoke(this, e);
        }
    }
}