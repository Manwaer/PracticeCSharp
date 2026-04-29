using Task3;

class Program
{
    static void Main()
    {
        Blog myBlog = new Blog();

        EmailSubscriber user1 = new EmailSubscriber("delegat@gmail.com");
        RSSSubscriber rss = new RSSSubscriber();

        myBlog.Subscribe(user1);
        myBlog.Subscribe(rss);

        myBlog.Publish("Паттерн Наблюдатель на C#");

        myBlog.Unsubscribe(rss);

        myBlog.Publish("Обзор новых функций .NET");
    }
}