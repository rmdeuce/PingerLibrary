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

            Task[] arrayTasks = new Task[countServers];
            //Таймер
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //
            if (countServers == 0)
                return;
            // Создание разбиения коллекции серверов с размером части 10
            var partitioner = Partitioner.Create(0, countServers, 10);
            
            Parallel.ForEach(partitioner, (part) =>
            {
                //Получение индекса начала и конца части
                int start = part.Item1;
                int end = part.Item2;
                Ping pinger = new Ping();
                //Выполнение Task в части
                for (int i = start; i < end; i++)
                {                     
                    try
                    {
                        var server = Servers.ElementAt(i);
                        Result[server.Key] = pinger.Send(server.Value);
                        //Console.WriteLine(Result[server.Key].Address);
                    }
                    catch (Exception ex)
                    { }
                }
            });

            //Остановка таймера
            stopwatch.Stop(); 
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime); 
        }

        private void ParallelPing(Dictionary<int, IPAddress> Servers, ConcurrentDictionary<int, PingReply> Result)
        {
            int countServers = Servers.Count;
            if (countServers == 0)
                return;

            Parallel.ForEach(Servers, (server) =>
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
