namespace Task4
{
    public class MessageNotifier
    {
        private readonly DesktopNotification _desktop;
        private readonly SoundAlert _sound;

        public MessageNotifier(DesktopNotification desktop, SoundAlert sound)
        {
            _desktop = desktop;
            _sound = sound;
        }

        public void Subscribe(ChatApplication chat)
        {
            chat.MessageReceived += _desktop.ShowPopup;
            chat.MessageReceived += _sound.PlaySound;
        }

        public void Unsubscribe(ChatApplication chat)
        {
            chat.MessageReceived -= _desktop.ShowPopup;
            chat.MessageReceived -= _sound.PlaySound;
        }
    }
}