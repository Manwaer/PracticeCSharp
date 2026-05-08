using System;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class ChatService
    {
        public event Action<string> OnMessageReceived;

        public async void StartListening()
        {
            while (true)
            {
                using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("ShopChat", PipeDirection.In))
                {
                    await pipeServer.WaitForConnectionAsync();
                    using (StreamReader reader = new StreamReader(pipeServer))
                    {
                        string message = await reader.ReadLineAsync();
                        if (!string.IsNullOrEmpty(message))
                        {
                            OnMessageReceived?.Invoke(message);
                        }
                    }
                }
            }
        }
    }
}
