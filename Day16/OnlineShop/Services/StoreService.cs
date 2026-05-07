using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.IO.Pipes;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public static class StoreService
    {
        private const string FilePath = "store.json";
        public static void Save(IEnumerable<Order> orders)
        {
            string json = JsonSerializer.Serialize(orders);
            File.WriteAllText(FilePath, json);
        }
        public static List<Order> Load()
        {
            if (!File.Exists(FilePath)) return new List<Order>();
            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Order>>(json) ?? new List<Order>();
        }

        public static void SendMmfNotify(string message)
        {
            using (MemoryMappedFile mmf = MemoryMappedFile.CreateOrOpen("OrderNotify", 1024))
            {
                using (MemoryMappedViewStream stream = mmf.CreateViewStream())
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        public static async Task SendChatMessage(string message)
        {
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "ShopChat", PipeDirection.Out))
            {
                try
                {
                    await pipeClient.ConnectAsync(500);
                    using (StreamWriter writer = new StreamWriter(pipeClient))
                    {
                        writer.AutoFlush = true;
                        await writer.WriteLineAsync(message);
                    }
                }
                catch
                {
                }
            }
        }
    }
}
