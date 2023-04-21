using Pinganator.Service.Interfaces;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;


namespace Pinganator.Service.Classes
{
    public class PingWorker : IPingWorker
    {
        public Dictionary<int, IPAddress> Servers { get; set; }
            = new Dictionary<int, IPAddress>();

        public ConcurrentDictionary<int, PingReply> Result { get; set; }

        public void Polling()
        {
            int countServers = Servers.Count;

            Result = new ConcurrentDictionary<int, PingReply>();

            //Task[] arrayTasks = new Task[countServers];

            Stopwatch stopwatch = new Stopwatch(); //Таймер
            stopwatch.Start();

            if (countServers == 0)
                return;
            
            int blockSize = Servers.Count / 10;

            var arr = new List<Dictionary<int, IPAddress>>();

            arr.Add(new Dictionary<int, IPAddress>(blockSize));

            var current = arr[0];

            for (int i = 0; i < Servers.Count; i++)
            {

                if (i != 0 && i % blockSize == 0)
                {
                    var curDic = new Dictionary<int, IPAddress>(blockSize);

                    arr.Add(curDic);

                    current = curDic;

                    current.Add(Servers.ElementAt(i).Key, Servers.ElementAt(i).Value);
                }
                else
                {
                    current.Add(Servers.ElementAt(i).Key, Servers.ElementAt(i).Value);
                }

            }

            stopwatch.Stop(); //Остановка таймера
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime); 
        }

        private void ParallelPing(Dictionary<int, IPAddress> inputDict, ConcurrentDictionary<int, PingReply> outputDict)
        {
            int countServers = inputDict.Count;
            if (countServers == 0)
                return;

            Parallel.ForEach(inputDict, (server) =>
            {
                Ping pinger = new Ping();

                try
                {
                    
                    Result[server.Key] = pinger.Send(server.Value);
                }
                catch (Exception ex)
                {
                   
                }
            });
        }

    }
}
