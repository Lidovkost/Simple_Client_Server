using System.Net.Sockets;
using System.Text;
namespace client
{
    class OurClient
    {
        TcpClient client;
        StreamWriter writer;
        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555);
            writer = new StreamWriter(client.GetStream(), Encoding.UTF8);
            HandleCommunication();
        }
    void HandleCommunication()
    {
        while(true)
        {
            Console.Write("> ");
            string? message = Console.ReadLine();
            writer.WriteLine(message);
            writer.Flush();
        }
    }
    }
}