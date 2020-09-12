using System;
using System.Text;
using EasyTcp3;
using EasyTcp3.Server;
using EasyTcp3.Server.ServerUtils;
using EasyTcp3.Actions;
using EasyTcp3.Actions.ActionUtils;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace DedicatedServer
{
    class Program
    {
        public static string LocalIP { get; set; }
        public static string PublicIP { get; set; }
        public static ushort Port { get; set; }
        private static EasyTcpServer server = null;

        public static Hashtable clientsList { get; set; }

        static void Main(string[] args)
        {
            InitializeServer();
            StartServer(Port);
        }

        private static void InitializeServer()
        {
            clientsList = new Hashtable();

            Port = 0;

            PublicIP = "none";
            
            LocalIP = "127.0.0.1";
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress addr in localIPs)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    LocalIP = addr.ToString();
                }
            }

            Console.Write(">> What port should the server listen to: ");
            string port = Console.ReadLine();
            Port = Convert.ToUInt16(port);

            try
            {
                PublicIP = new WebClient().DownloadString("https://ipinfo.io/ip/").Trim();
            }
            catch
            {
                Console.WriteLine(">> You're not connected to internet. Localhost only!");
            }

        }

        private static void StartServer(int port)
        {
            try
            {
                server = new EasyTcpActionServer();
                server.Start(Port);

                bool exit = false;

                Console.WriteLine($">> Server started on ip: {LocalIP} (public ip adress: {PublicIP})!");
                Console.WriteLine($">> Server started listening to port {port}!");
                Console.WriteLine(">> Press escape to close the server ...");
                while (!exit)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape)
                    {
                        exit = true;
                    }
                }

                server.Dispose();

                Console.WriteLine(Environment.NewLine + ">> Server closed! Press any key to close the window ...");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        [EasyTcpAction("CONNECT")]
        public void OnClientConnect(Message message)
        {
            string clientName = message.ToString(Encoding.Unicode);
            if (!clientsList.ContainsKey(clientName))
            {
                clientsList.Add(clientName, message.Client);
                Console.WriteLine($">> {clientName} connected to the server!");
                foreach(DictionaryEntry item in clientsList)
                {
                    if ((string)item.Key == clientName)
                    {
                        ((EasyTcpClient)item.Value).SendAction("GET_MESSAGE", "You are connected to a chat server!", Encoding.Unicode);
                        ((EasyTcpClient)item.Value).SendAction("GET_MESSAGE", $"Welcome {clientName}!", Encoding.Unicode);
                    }
                    else
                    {
                        ((EasyTcpClient)item.Value).SendAction("GET_MESSAGE", $"{clientName} joined chat!", Encoding.Unicode);
                    }
                }
                SendUsersList();
            }
            else
            {
                message.Client.SendAction("SAME_NAME", $"There is already a client connected with the name: {clientName}", Encoding.Unicode);
                message.Client.Dispose();
            }
        }

        [EasyTcpAction("DISCONNECT")]
        public void OnClientDisconnect(Message message)
        {
            string clientName = message.ToString(Encoding.Unicode);
            message.Client.Dispose();
            Console.WriteLine($">> {clientName} disconnected from the server!");
            clientsList.Remove(clientName);
            foreach (DictionaryEntry item in clientsList)
            {
                ((EasyTcpClient)item.Value).SendAction("GET_MESSAGE", clientName + " left the chat!", Encoding.Unicode);
            }
            SendUsersList();
        }

        [EasyTcpAction("SEND_BROADCAST")]
        public void SendBroadcast(Message message)
        {
            string sendedMsg = "";
            string clientName = message.ToString(Encoding.Unicode);
            sendedMsg = clientName.Split('\u241E')[1];
            clientName = clientName.Split('\u241E')[0];
            Console.WriteLine($">> From client - {clientName}: {sendedMsg}");
            foreach (DictionaryEntry item in clientsList)
            {
                string messageToSend = "";
                if ((string)item.Key == clientName)
                {
                    messageToSend = $"[ {clientName}(ME) ]: {sendedMsg}";
                }
                else
                {
                    messageToSend = $"[ {clientName} ]: {sendedMsg}";
                }
                ((EasyTcpClient)item.Value).SendAction("GET_MESSAGE", messageToSend , Encoding.Unicode);
            }
        }

        public void SendUsersList()
        {
            string msg = GetUsersList(clientsList);
            foreach (DictionaryEntry item in clientsList)
            {
                ((EasyTcpClient)item.Value).SendAction("GET_USERS_LIST", msg, Encoding.Unicode);
            }
        }

        public string GetUsersList(Hashtable clients)
        {
            string usersList = "";
            foreach(DictionaryEntry item in clients)
            {
                usersList += (string)item.Key + "\u241E";
            }

            if (usersList == "")
            {
                usersList = "\u241E";
            }
            return usersList;
        }
         
    }
}
