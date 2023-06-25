using System.Data;
using System.Threading;
using System;

namespace Stopwatch
{
    class Stop
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("------------");
            Console.WriteLine("Quanto tempo deseja contar ?");
            try
            {
                string data = Console.ReadLine().ToLower();
                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));
                int sendTime = type == 'm' ? time * 60 : time;
                PreStart(sendTime);
            }
            catch (System.Exception)
            {
                Menu();
            }
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparing everything...");
            Thread.Sleep(1000);
            Console.WriteLine("Ready!");
            Thread.Sleep(200);
            Start(time);
        }

        static void Start(int seconds)
        {
            int time = seconds;
            int currentTime = 0;

            while (currentTime <= time)
            {
                Console.Clear();
                Console.WriteLine($"{ShowTime()}: {currentTime} / {time}");
                currentTime++;
                Thread.Sleep(1000);
            }
        }

        static string ShowTime()
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;
            int minute = currentTime.Minute;
            int second = currentTime.Second;
            string answer = $"{hour}:{minute}:{second}";
            return answer;
        }
    }
}