namespace Task3
{
    public class ClientProcessor
    {
        public List<Client> FindDebtors(List<Client> clients)
        {
            return clients.Where(c => c.Balance < 0).ToList();
        }

        public List<Client> SortByBalance(List<Client> clients)
        {
            return clients.OrderBy(c => c.Balance).ToList();
        }
    }
}