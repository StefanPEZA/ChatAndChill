using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Net;
using System.Collections.Generic;
using System.IO;

namespace DedicatedServer
{
    class Program
    {
        public static Hashtable clientsList = new Hashtable();
        public static string clientNames = string.Empty;
        private readonly static string path = "TextCache.txt";

        static void Main(string[] args)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (FileStream fs = File.Create(path))
                {
                    // Add some text to file    
                    Byte[] title = Encoding.Unicode.GetBytes("\u241E");
                    fs.Write(title, 0, title.Length);
                }

                IPAddress ip = null;
                string publicIp = "none";
                string port = "8888";

                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var _ip in host.AddressList)
                {
                    if (_ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ip = _ip.MapToIPv4();
                    }
                }

                Console.Write(">>What port do you want to use?: ");
                port = Console.ReadLine();

                TcpListener serverSocket = new TcpListener(IPAddress.Any, Convert.ToInt32(port));
                TcpClient clientSocket = default(TcpClient);
                int counter = 0;

                Console.WriteLine(">>Chat Server Started ....");

                serverSocket.Start();
                try
                {
                    publicIp = new WebClient().DownloadString("https://ipv4.icanhazip.com/").TrimEnd();
                }
                catch
                {
                    Console.WriteLine(">>Not connected to internet...");
                }
                
                counter = 0;
                Console.WriteLine(">>I am listening for connections on " +
                                             IPAddress.Parse(((IPEndPoint)serverSocket.LocalEndpoint).Address.ToString()) + "(local adress: " + ip.ToString() +
                                              ")/(public adress: " + publicIp + ").\n>>On port number " + ((IPEndPoint)serverSocket.LocalEndpoint).Port.ToString());
                while ((true))
                {
                    counter += 1;
                    clientSocket = serverSocket.AcceptTcpClient();

                    byte[] bytesFrom = new byte[10025];
                    string dataFromClient = null;

                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    dataFromClient = MessageProcessor.DecodeMessage(bytesFrom);

                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("¶"));
                    try
                    {
                        if (!clientsList.ContainsKey(dataFromClient))
                        {
                            clientsList.Add(dataFromClient, clientSocket);
                            broadcast(dataFromClient + " Joined ", dataFromClient, false);

                            File.AppendAllText(path, dataFromClient + " Joined" + Environment.NewLine, Encoding.Unicode);

                            Console.WriteLine(">>" + dataFromClient + " Joined chat room ");
                            handleClinet client = new handleClinet();
                            client.startClient(clientSocket, dataFromClient, clientsList);
                        }
                        else
                        {
                            Console.WriteLine(">> Failed attempt to connect with same name: " + dataFromClient);
                            byte[] broadcastBytes = MessageProcessor.EncodeMessage("There is someone with the same name connected! Try another name!«»");
                            networkStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                            networkStream.Flush();
                            networkStream = null;
                            clientSocket.GetStream().Close();
                            clientSocket.Close();
                            clientSocket = null;
                            counter -= 1;
                        }
                    }
                    catch
                    {
                        
                    }

                }

                clientSocket.Close();
                serverSocket.Stop();
                Console.WriteLine("exit");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }

        public static void UpdateClientsNames()
        {
            //« »
            clientNames = "" + "«";
            foreach (DictionaryEntry Item in clientsList)
            {
                clientNames += (string)Item.Key + "_";
            }
            char[] temp = clientNames.ToCharArray();
            temp[clientNames.Length - 1] = '»';
            clientNames = new String(temp);
        }
        
        public static List<DictionaryEntry> disconnectedEntry = new List<DictionaryEntry>();
        public static void broadcast(string msg, string uName, bool flag)
        {
            if (flag == true)
            {
                    File.AppendAllText(path ,uName + " : " + msg + Environment.NewLine, Encoding.Unicode);
            }
            else
            {
                    File.AppendAllText(path, msg + Environment.NewLine, Encoding.Unicode);
            }
            UpdateClientsNames();
            foreach (DictionaryEntry Item in clientsList)
            {
                try
                {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                        
                    NetworkStream broadcastStream = broadcastSocket.GetStream();
                    byte[] broadcastBytes = null;

                    string message = "";
                    if (flag == true)
                    {
                        if (uName != (string)Item.Key)
                            message = uName + " : " + msg;
                        else
                            message = "ME" + " : " + msg;
                    }
                    else
                    {
                        if (uName == (string)Item.Key)
                            message = "Welcome " + uName + "!";
                        else
                            message = msg;
                    }
                    message += clientNames;

                    broadcastBytes = MessageProcessor.EncodeMessage(message);
                    broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                    broadcastStream.Flush();
                }
                catch
                {
                    disconnectedEntry.Add(Item);
                }
            }

            foreach(DictionaryEntry item in disconnectedEntry)
            {
                if (clientsList.ContainsKey(item.Key))
                    clientsList.Remove((string)item.Key);
                broadcast((string)item.Key + " left the chat!", (string)item.Key, false);
                Console.WriteLine(">>" + (string)item.Key + " Disconnected from the server!" + Environment.NewLine);
            }
            disconnectedEntry.Clear();
            UpdateClientsNames();
        }  //end broadcast function

    }//end Main class


    public class handleClinet
    {
        TcpClient clientSocket;
        string clNo;
        Hashtable clientsList;

        public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cList)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            this.clientsList = cList;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }

        private void doChat()
        {
            int requestCount = 0;
            byte[] bytesFrom = new byte[10025];
            string dataFromClient = null;
            Byte[] sendBytes = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;

            try
            {
                while ((true))
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    dataFromClient = MessageProcessor.DecodeMessage(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("¶"));
                    rCount = Convert.ToString(requestCount);
                    Program.broadcast(dataFromClient, clNo, true);
                    Console.WriteLine(">>From client - " + clNo + " : " + dataFromClient);
                }//end while
            }
            catch
            {
                if (Program.clientsList.ContainsKey(clNo))
                {
                     Program.clientsList.Remove(clNo);
                     clientsList.Remove(clNo);
                }
                Program.broadcast(clNo + " left the chat!", clNo, false);
                Console.WriteLine(">>" + clNo + " Disconnected from the server!" + Environment.NewLine);
            }
            return;
        }//end doChat
    } //end class handleClinet
}//end namespace