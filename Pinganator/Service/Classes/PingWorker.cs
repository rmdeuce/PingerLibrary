using Pinganator.Service.Interfaces;
using System.Collections.Concurrent;
using System.Net;
using System.Net.NetworkInformation;


namespace Pinganator.Service.Classes
{
    public class PingWorker : IPingWorker
    {
        public Dictionary<int, IPAddress> Servers { get; set; }
            = new Dictionary<int, IPAddress>();

        public ConcurrentDictionary<int, PingReply> Result { get; }
            = new ConcurrentDictionary<int, PingReply>();

        public int ThreadCount { get; set; } = 4;

        public int ServerTimeout { get; set; } = 150;

        public ConcurrentDictionary<int, PingReply> Polling()
        {
            if (Servers.Count == 0)
                throw new Exception("Ваш список серверов пуст");   
            
            var blockSize = (int)Math.Round((decimal)Servers.Count / ThreadCount);

            var serversList = new List<Dictionary<int, IPAddress>>(ThreadCount)
            {
                new Dictionary<int, IPAddress>(blockSize)
            };

            var current = serversList[0];

            for (int i = 0; i < Servers.Count; i++)
            {
                if (i % blockSize == 0)
                {
                    var currentDictionairy = new Dictionary<int, IPAddress>(blockSize);

                    serversList.Add(currentDictionairy);

                    current = currentDictionairy;
                }
                
                current.Add(Servers.ElementAt(i).Key, Servers.ElementAt(i).Value);
            }

            var tasks = new List<Task>();

            foreach (var dictionary in serversList)
            {
                var task = Task.Run(() => SendPings(dictionary));
                tasks.Add(task);
            }       

            Task.WaitAll(tasks.ToArray());

            return Result;
        }

        private void SendPings(Dictionary<int, IPAddress> inputDictionary)
        {
            var pinger = new Ping();
            
            foreach (var server in inputDictionary)
            {
                Result[server.Key] = pinger.Send(server.Value, ServerTimeout);
            }
        }
    }
}
