using System;
using System.Net.Sockets;

public class MyClient
{
    TcpClient Client;

    //NetworkStream Stream;

    public void Connect(String server, Int32 port) 
    {
        try 
        {
            Client = new TcpClient(server, port);
            //Stream = Client.GetStream();
        } 
        catch (ArgumentNullException e) 
        {
            Console.WriteLine("ArgumentNullException: {0}", e);
        } 
        catch (SocketException e) 
        {
            Console.WriteLine("SocketException: {0}", e);
        }
    }

    public void SendMessage(string str)
    {
        Byte[] data = System.Text.Encoding.ASCII.GetBytes(str);
        using(NetworkStream stream = Client.GetStream())
        {
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Sent: {0}", str);      
        }
    }

    public void Disconnect()
    {
        Client.Close(); 
    }
}