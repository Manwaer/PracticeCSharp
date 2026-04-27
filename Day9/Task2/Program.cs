using Task2;

class Program
{
    static void Main()
    {
        ClientFileWriter writer = new ClientFileWriter();

        List<Client> initialClients = new List<Client>
        {
            new Client("Иван Иванов", 1500.50m),
            new Client("Петр Петров", 2300.00m)
        };

        writer.OverwriteClients(initialClients);

        List<Client> newClients = new List<Client>
        {
            new Client("Анна Сидорова", 5000.75m)
        };

        writer.OverwriteClients(newClients);

        List<Client> loadedClients = writer.ReadClients();
        foreach (var client in loadedClients)
        {
            Console.WriteLine($"Имя: {client.Name}, Баланс: {client.Balance}");
        }
    }
}