namespace Task4
{
    public class DesktopNotification
    {
        public void ShowPopup(object sender, MessageEventArgs e)
        {
            Console.WriteLine($"[Уведомление]: {e.Sender} пишет: \"{e.Text}\"");
        }
    }
}   