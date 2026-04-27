namespace Task2
{
    public class ClientFileWriter
    {
        private string _path = "/home/admin/Документы/GitHub/PracticeCSharp/Day9/Task2/file.data";

        public void OverwriteClients(List<Client> clients)
        {
            using (StreamWriter sw = new StreamWriter(_path, false))
            {
                foreach (var client in clients)
                {
                    sw.WriteLine(client.ToString());
                }
            }
        }

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
                    clients.Add(new Client(parts[0], decimal.Parse(parts[1])));
                }
            }
            return clients;
        }
    }
}