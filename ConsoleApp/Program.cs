using Pinganator.Service.Classes;
using System.Net;
using System.Text;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new PingWorker();
  
            var bDictonary = new Dictionary<int, IPAddress>()
            {
                {533,  IPAddress.Parse("192.168.21.88")},
                {523,  IPAddress.Parse("192.168.3.56")},
                {18,   IPAddress.Parse("192.168.21.149")},
                {22,   IPAddress.Parse("92.223.6.14")},
                {23,   IPAddress.Parse("92.223.6.14")},
                {24,   IPAddress.Parse("92.223.6.14")},
                {25,   IPAddress.Parse("92.223.6.14")},
                {26,   IPAddress.Parse("92.223.6.14")},
                {27,   IPAddress.Parse("92.223.6.14")},
                {28,   IPAddress.Parse("92.223.6.14")},
                {29,   IPAddress.Parse("92.223.6.14")},
                {30,   IPAddress.Parse("92.223.6.14")},
                {31,   IPAddress.Parse("92.223.6.14")},
                {32,   IPAddress.Parse("92.223.6.14")},
                {33,   IPAddress.Parse("92.223.6.14")},
                {34,   IPAddress.Parse("92.223.6.14")},
                {35,   IPAddress.Parse("92.223.6.14")},
                {36,   IPAddress.Parse("92.223.6.14")},
                {37,   IPAddress.Parse("92.223.6.14")},
                {38,   IPAddress.Parse("92.223.6.14")},
                {39,   IPAddress.Parse("92.223.6.14")},
                {40,   IPAddress.Parse("92.223.6.14")},
                {41,   IPAddress.Parse("92.223.6.14")},
                {42,   IPAddress.Parse("92.223.6.14")},
                {43,   IPAddress.Parse("92.223.6.14")},
                {44,   IPAddress.Parse("92.223.6.14")},
                {45,   IPAddress.Parse("92.223.6.14")},
                {46,   IPAddress.Parse("92.223.6.14")},
                {47,   IPAddress.Parse("92.223.6.14")},
                {48,   IPAddress.Parse("92.223.6.14")},
                {49,   IPAddress.Parse("92.223.6.14")},
                {50,   IPAddress.Parse("92.223.6.14")},
                {51,   IPAddress.Parse("92.223.6.14")},
                {52,   IPAddress.Parse("92.223.6.14")},
                {53,   IPAddress.Parse("92.223.6.14")},
                {54,   IPAddress.Parse("92.223.6.14")},
                {55,   IPAddress.Parse("92.223.6.14")},
                {56,   IPAddress.Parse("92.223.6.14")},
                {57,   IPAddress.Parse("92.223.6.14")},
                {58,   IPAddress.Parse("92.223.6.14")},
                {59,   IPAddress.Parse("92.223.6.14")},
                {60,   IPAddress.Parse("92.223.6.14")},
                
            }; 

            a.Servers = bDictonary;

            a.Polling();

            foreach (var pair in a.Result)
            {
                Console.WriteLine($"Сервер {pair.Key} имеет статус {pair.Value.Status} и время ответа {pair.Value.RoundtripTime} мс" ); ;
            }
        }
    }
}