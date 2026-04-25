namespace Task4
{
    public class MessageEventArgs : EventArgs
    {
        public string Sender { get; }
        public string Text { get; }

        public MessageEventArgs(string sender, string text)
        {
            Sender = sender;
            Text = text;
        }
    }
}