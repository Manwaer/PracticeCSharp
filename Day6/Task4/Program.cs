using Task4;
class Program
{
    static void Main()
    {
        ChatApplication chat = new ChatApplication();
            
        DesktopNotification desktop = new DesktopNotification();
        SoundAlert sound = new SoundAlert();

        MessageNotifier notifier = new MessageNotifier(desktop, sound);
        notifier.Subscribe(chat);

        chat.ReceiveMessage("Сигма", "Добро пожаловать в чат!");
    }
}