namespace Task3
{
    public class EmailSubscriber : ISubscriber
    {
        private string _email;

        public EmailSubscriber(string email)
        {
            _email = email;
        }

        public void Update(string articleTitle)
        {
            Console.WriteLine($"[Email на {_email}]: Новая статья в блоге — {articleTitle}");
        }
    }
}