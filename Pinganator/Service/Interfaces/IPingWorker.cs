using System.Collections.Concurrent;
using System.Net;
using System.Net.NetworkInformation;

namespace Pinganator.Service.Interfaces
{
    public interface IPingWorker
    {
        /// <summary>
        /// Список серверов для проверки пинга
        /// key - ID сервера
        /// </summary>
        public Dictionary<int, IPAddress> Servers { get; set; }

        /// <summary>
        /// Результат проверки пинга
        /// key - ID сервера
        /// </summary>
        public ConcurrentDictionary<int, PingReply> Result { get; }

        /// <summary>
        /// Количество потоков, задействованное для опроса серверов
        /// </summary>
        public int ThreadCount { get; set; }

        /// <summary>
        /// Время ожидания ответа сервера при пинговании (мс.)
        /// </summary>
        public int ServerTimeout { get; set; }

        /// <summary>
        /// Опрос серверов
        /// Возвращает Result
        /// </summary>
        public ConcurrentDictionary<int, PingReply> Polling();    
    }
}
