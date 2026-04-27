using Task3;

class Program
{
    static void Main()
    {
        ClientFileReader reader = new ClientFileReader();
        ClientProcessor processor = new ClientProcessor();

        List<Client> allClients = reader.ReadClients();
        List<Client> debtors = processor.FindDebtors(allClients);

        Console.WriteLine("Список должников:");
        if (debtors.Count == 0)
        {
            Console.WriteLine("Должников не найдено.");
        }
        else
        {
            foreach (var client in debtors)
            {
                Console.WriteLine($"Имя: {client.Name}, Баланс: {client.Balance}");
            }
        }
    }
}