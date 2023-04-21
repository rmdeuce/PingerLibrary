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
        public ConcurrentDictionary<int, PingReply> Result { get; set; }

        /// <summary>
        /// Опрос серверов
        /// Обновляет Result
        /// Принимает callback, который будет выполнен по окончании опроса
        /// callback не является обязательным
        /// </summary>
        public void Polling();    
    }
}
