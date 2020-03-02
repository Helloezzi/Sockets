using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyServer tcpServer = new MyServer(5000);
            tcpServer.ServerOpen();

            Console.ReadKey();
        }
    }
}
