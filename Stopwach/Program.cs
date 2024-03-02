using System.Security.Cryptography.X509Certificates;

namespace Stopwach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Start(int time)
        {
           
            int currentTime = 0;

            while (currentTime <= time)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime++;
                Thread.Sleep(1000);
            }

            Console.WriteLine("Finished Stopwatch!");
            Thread.Sleep(2500);
            Menu();
        }

        public static void Menu()
        {
            Console.Clear ();   
            Console.WriteLine("---------STOPWARTCH--------");
            Console.WriteLine("S for seconds - 10s = 10 seconds\n" +
                              "M for minutes - 10m = 10 minutes\n");
            Console.WriteLine("0 for exit\n");  
            Console.WriteLine("\nHow long do you want to count?");

            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1));

            int time = int.Parse(data.Substring(0 , data.Length -1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            time = time * multiplier;

            PreStart(time);    
        }
        public static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep (1000);    
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(1000);

            Start(time);
        }
    }
}