namespace Task3
{
    public class RSSSubscriber : ISubscriber
    {
        public void Update(string articleTitle)
        {
            Console.WriteLine($"[RSS-лента]: Добавлена новая запись: {articleTitle}");
        }
    }
}