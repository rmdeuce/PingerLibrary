﻿using Pinganator.Service.Classes;
using System.Net;
using System.Text;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doPingWorker = new PingWorker();

                      var doDictonary = new Dictionary<int, IPAddress>()
            {
                {345, IPAddress.Parse("192.168.16.62")},
                {346, IPAddress.Parse("192.168.16.61")},
                {343, IPAddress.Parse("10.0.6.1")},
                {233, IPAddress.Parse("10.0.2.30")},
                {232, IPAddress.Parse("10.0.2.38")},
                {231, IPAddress.Parse("10.0.2.27")},
                {230, IPAddress.Parse("10.0.2.35")},
                {237, IPAddress.Parse("10.0.2.43")},
                {236, IPAddress.Parse("10.0.2.29")},
                {235, IPAddress.Parse("10.0.2.31")},
                {234, IPAddress.Parse("10.0.2.28")},
                {239, IPAddress.Parse("10.0.2.21")},
                {238, IPAddress.Parse("10.0.2.42")},
                {45, IPAddress.Parse("192.168.254.74")},
                {41, IPAddress.Parse("192.168.20.11")},
                {42, IPAddress.Parse("192.168.254.54")},
                {51, IPAddress.Parse("192.168.254.75")},
                {24, IPAddress.Parse("192.168.16.76")},
                {217, IPAddress.Parse("10.0.2.19")},
                {218, IPAddress.Parse("10.0.1.70")},
                {219, IPAddress.Parse("10.0.1.71")},
                {222, IPAddress.Parse("10.0.2.76")},
                {223, IPAddress.Parse("10.0.2.74")},
                {224, IPAddress.Parse("10.0.2.75")},
                {225, IPAddress.Parse("10.0.1.197")},
                {228, IPAddress.Parse("10.0.2.41")},
                {229, IPAddress.Parse("10.0.2.37")},
                {216, IPAddress.Parse("10.0.2.199")},
                {83, IPAddress.Parse("192.168.3.206")},
                {81, IPAddress.Parse("192.168.20.50")},
                {75, IPAddress.Parse("192.168.254.76")},
                {74, IPAddress.Parse("192.168.3.205")},
                {77, IPAddress.Parse("192.168.16.63")},
                {296, IPAddress.Parse("10.0.3.151")},
                {209, IPAddress.Parse("192.168.16.178")},
                {110, IPAddress.Parse("192.168.21.33")},
                {114, IPAddress.Parse("192.168.16.77")},
                {111, IPAddress.Parse("192.168.16.54")},
                {112, IPAddress.Parse("192.168.16.55")},
                {78, IPAddress.Parse("192.168.254.55")},
                {108, IPAddress.Parse("192.168.254.67")},
                {82, IPAddress.Parse("192.168.21.152")},
                {79, IPAddress.Parse("192.168.21.71")},
                {211, IPAddress.Parse("192.168.21.199")},
                {116, IPAddress.Parse("192.168.1.1")},
                {43, IPAddress.Parse("192.168.21.150")},
                {213, IPAddress.Parse("192.168.21.82")},
                {115, IPAddress.Parse("192.168.16.151")},
                {331, IPAddress.Parse("10.0.2.4")},
                {339, IPAddress.Parse("10.0.3.171")},
                {359, IPAddress.Parse("10.0.6.27")},
                {358, IPAddress.Parse("10.0.6.26")},
                {135, IPAddress.Parse("192.168.16.51")},
                {129, IPAddress.Parse("192.168.254.51")},
                {128, IPAddress.Parse("10.0.1.101")},
                {134, IPAddress.Parse("192.168.16.52")},
                {131, IPAddress.Parse("192.168.21.35")},
                {132, IPAddress.Parse("192.168.254.73")},
                {62, IPAddress.Parse("192.168.21.12")},
                {60, IPAddress.Parse("192.168.16.71")},
                {57, IPAddress.Parse("192.168.254.53")},
                {56, IPAddress.Parse("192.168.21.21")},
                {356, IPAddress.Parse("10.0.6.24")},
                {84, IPAddress.Parse("192.168.254.77")},
                {87, IPAddress.Parse("192.168.254.52")},
                {89, IPAddress.Parse("192.168.21.11")},
                {90, IPAddress.Parse("192.168.20.70")},
                {93, IPAddress.Parse("192.168.16.80")},
                {95, IPAddress.Parse("194.58.118.145")},
                {96, IPAddress.Parse("192.168.16.66")},
                {336, IPAddress.Parse("10.0.2.8")},
                {355, IPAddress.Parse("10.0.6.23")},
                {3, IPAddress.Parse("192.168.16.64")},
                {291, IPAddress.Parse("10.0.2.17")},
                {27, IPAddress.Parse("192.168.20.60")},
                {353, IPAddress.Parse("10.0.6.21")},
                {290, IPAddress.Parse("10.0.1.254")},
                {292, IPAddress.Parse("10.0.2.18")},
                {293, IPAddress.Parse("10.0.2.16")},
                {335, IPAddress.Parse("10.0.2.1")},
                {329, IPAddress.Parse("10.0.2.81")},
                {354, IPAddress.Parse("10.0.6.22")},
                {126, IPAddress.Parse("192.168.16.82")},
                {390, IPAddress.Parse("10.0.6.29")},
                {117, IPAddress.Parse("192.168.16.79")},
                {119, IPAddress.Parse("192.168.3.202")},
                {55, IPAddress.Parse("109.126.15.98")},
                {54, IPAddress.Parse("192.168.254.64")},
                {120, IPAddress.Parse("192.168.254.61")},
                {127, IPAddress.Parse("192.168.21.241")},
                {136, IPAddress.Parse("192.168.21.55")},
                {133, IPAddress.Parse("192.168.21.151")},
                {130, IPAddress.Parse("192.168.21.70")},
                {85, IPAddress.Parse("192.168.21.202")},
                {58, IPAddress.Parse("192.168.21.77")},
                {52, IPAddress.Parse("192.168.21.240")},
                {28, IPAddress.Parse("192.168.4.200")},
                {122, IPAddress.Parse("192.168.4.56")},
                {88, IPAddress.Parse("192.168.254.253")},
                {32, IPAddress.Parse("192.168.20.12")},
                {33, IPAddress.Parse("192.168.16.78")},
                {39, IPAddress.Parse("192.168.16.84")},
                {215, IPAddress.Parse("10.0.1.10")},
                {337, IPAddress.Parse("192.168.20.30")},
                {357, IPAddress.Parse("10.0.6.25")},
                {389, IPAddress.Parse("10.0.6.28")},
                {340, IPAddress.Parse("10.0.3.172")},
                {392, IPAddress.Parse("10.0.6.211")},
                {393, IPAddress.Parse("10.0.6.212")},
                {72, IPAddress.Parse("192.168.254.70")},
                {69, IPAddress.Parse("192.168.16.70")},
                {65, IPAddress.Parse("192.168.254.40")},
                {66, IPAddress.Parse("192.168.16.81")},
                {63, IPAddress.Parse("192.168.16.83")},
                {30, IPAddress.Parse("192.168.254.72")},
                {247, IPAddress.Parse("10.0.2.20")},
                {244, IPAddress.Parse("10.0.2.32")},
                {245, IPAddress.Parse("10.0.2.24")},
                {242, IPAddress.Parse("10.0.2.40")},
                {243, IPAddress.Parse("10.0.2.26")},
                {241, IPAddress.Parse("10.0.2.23")},
                {342, IPAddress.Parse("10.0.3.174")},
                {341, IPAddress.Parse("10.0.3.173")},
                {102, IPAddress.Parse("192.168.16.56")},
                {98, IPAddress.Parse("192.168.16.65")},
                {48, IPAddress.Parse("192.168.16.69")},
                {240, IPAddress.Parse("10.0.2.45")},
                {46, IPAddress.Parse("192.168.21.63")},
                {70, IPAddress.Parse("192.168.21.203")},
                {395, IPAddress.Parse("10.0.2.41")},
                {123, IPAddress.Parse("192.168.254.66")},
                {36, IPAddress.Parse("192.168.254.65")},
                {99, IPAddress.Parse("192.168.254.63")},
                {246, IPAddress.Parse("10.0.2.48")},
                {103, IPAddress.Parse("192.168.21.84")},
                {64, IPAddress.Parse("192.168.21.85")},
                {67, IPAddress.Parse("89.108.72.227")},
                {31, IPAddress.Parse("192.168.16.40")},
                {106, IPAddress.Parse("192.168.16.221")},
                {49, IPAddress.Parse("192.168.16.53")},
                {25, IPAddress.Parse("192.168.16.86")},
                {37, IPAddress.Parse("192.168.16.87")},
                {121, IPAddress.Parse("192.168.254.252")},
                {34, IPAddress.Parse("192.168.254.254")},
                {248, IPAddress.Parse("192.168.21.83")},
                {50, IPAddress.Parse("192.168.3.201")},
                {1, IPAddress.Parse("192.168.16.68")},
                {104, IPAddress.Parse("192.168.21.31")},
                {101, IPAddress.Parse("192.168.21.31")},
                {349, IPAddress.Parse("10.0.6.42")},
                {350, IPAddress.Parse("10.0.6.43")},
                {348, IPAddress.Parse("10.0.6.41")},
                {351, IPAddress.Parse("10.0.6.44")},
                {352, IPAddress.Parse("10.0.6.2")},
                {334, IPAddress.Parse("10.0.2.6")},
                {332, IPAddress.Parse("10.0.2.3")},
                {333, IPAddress.Parse("10.0.2.2")},
                {299, IPAddress.Parse("10.0.3.154")},
                {298, IPAddress.Parse("10.0.3.153")},
                {295, IPAddress.Parse("10.0.3.155")},
                {294, IPAddress.Parse("10.0.2.10")},
                {297, IPAddress.Parse("10.0.3.152")},
                {347, IPAddress.Parse("10.0.6.4")},
                {23, IPAddress.Parse("10.0.3.188")},
                {514, IPAddress.Parse("192.168.21.148")},
                {19, IPAddress.Parse("10.0.3.182")},
                {20, IPAddress.Parse("10.0.3.183")},
                {21, IPAddress.Parse("10.0.3.184")},
                {22, IPAddress.Parse("10.0.3.186")},
                {26, IPAddress.Parse("10.0.3.189")},
                {522, IPAddress.Parse("10.0.2.16")},
                {510, IPAddress.Parse("10.0.1.226")},
                {508, IPAddress.Parse("192.168.254.62")},
                {524, IPAddress.Parse("172.31.10.249")},
                {512, IPAddress.Parse("10.0.2.102")},
                {513, IPAddress.Parse("10.0.2.15")},
                {227, IPAddress.Parse("10.0.2.36")},
                {530, IPAddress.Parse("192.168.37.239")},
                {511, IPAddress.Parse("10.0.2.101")},
                {517, IPAddress.Parse("192.168.21.22")},
                {519, IPAddress.Parse("192.168.254.56")},
                {520, IPAddress.Parse("192.168.254.57")},
                {521, IPAddress.Parse("10.0.1.254")},
                {525, IPAddress.Parse("172.31.10.250")},
                {118, IPAddress.Parse("192.168.21.86")},
                {515, IPAddress.Parse("85.95.143.191")},
                {509, IPAddress.Parse("85.95.143.200")},
                {518, IPAddress.Parse("192.168.21.90")},
                {76, IPAddress.Parse("192.168.20.20")},
                {18, IPAddress.Parse("192.168.21.149")},
                {523, IPAddress.Parse("192.168.3.56")},
                {533, IPAddress.Parse("192.168.21.88")}
            }; 

        //    doPingWorker.Servers = doDictonary;

            var result = doPingWorker.Polling(doDictonary);

            foreach (var pair in result)
            {
                Console.WriteLine($"Сервер {pair.Key} имеет статус {pair.Value.Status} и время ответа {pair.Value.RoundtripTime} мс" ); 
            }
        }
    }
}