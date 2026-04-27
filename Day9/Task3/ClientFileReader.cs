namespace Task3
{
    public class ClientFileReader
    {
        private string _path = "/home/admin/Документы/GitHub/PracticeCSharp/Day9/Task3/file.data";

        public List<Client> ReadClients()
        {
            List<Client> clients = new List<Client>();
            if (!File.Exists(_path)) return clients;

            string[] lines = File.ReadAllLines(_path);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    if (decimal.TryParse(parts[1], out decimal balance))
                    {
                        clients.Add(new Client(parts[0], balance));
                    }
                }
            }
            return clients;
        }
    }
}