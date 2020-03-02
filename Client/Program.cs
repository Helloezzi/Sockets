using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClient client = new MyClient();

            client.Connect("127.0.0.1", 5000);

            bool isDisconnect = false;

            while(!isDisconnect)
            {
                string msg = Console.ReadLine();
                client.SendMessage(msg);

                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Escape)
                {
                    isDisconnect = false;
                } 
            }
            client.Disconnect();
        }
    }
}
