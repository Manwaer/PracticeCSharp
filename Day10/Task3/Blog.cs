namespace Task3
{
    public class Blog
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Publish(string title)
        {
            Console.WriteLine($"Блог: Опубликована новая статья \"{title}\"");
            NotifySubscribers(title);
        }

        private void NotifySubscribers(string title)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(title);
            }
        }
    }
}