using System;
using System.Text;
using EasyTcp3.Actions;
using EasyTcp3.Actions.ActionUtils;
using EasyTcp3;
using EasyTcp3.ClientUtils;

namespace ChatAndChill_2._0._0
{
    public class Client
    {
        public static Main mainApp = null;
        public static EasyTcpActionClient tcpClient;
        private static string[] clientsList;

        public void initializeClient()
        {
            tcpClient = new EasyTcpActionClient();
            tcpClient.OnError += TcpClient_OnError;
            tcpClient.OnDisconnect += TcpClient_OnDisconnect;
        }

        private void TcpClient_OnDisconnect(object sender, EasyTcpClient e)
        {
            tcpClient = null;
        }

        public void SendMessage(string message)
        {
            if (tcpClient != null)
            {
                if (tcpClient.IsConnected())
                {
                    tcpClient.SendAction("SEND_BROADCAST", message, Encoding.Unicode);
                    return;
                }
            }
            mainApp.WriteMessage("Not connected to any server!");
        }

        public void Disconnect(string name)
        {
            if (tcpClient != null)
            {
                if (tcpClient.IsConnected())
                {
                    tcpClient.SendAction("DISCONNECT", name, Encoding.Unicode);
                    tcpClient = null;
                }
            }
        }
        public bool Connect(string ip, ushort port, string name)
        {
            if (tcpClient == null)
            {
                initializeClient();
            }
            else
            {
                if (tcpClient.IsConnected())
                    throw new Exception("You are allready connected to a server, try to disconnect first!");
            }

            if (ip == "localhost")
            {
                ip = "127.0.0.1";
            }

            if (!tcpClient.Connect(ip, port))
            {
                tcpClient.Dispose();
                tcpClient = null;
                return false;
            }

            tcpClient.SendAction("CONNECT", name, Encoding.Unicode);
            return true;
        }

        public void TcpClient_OnError(object sender, Exception e)
        {
            mainApp.WriteMessage(e.Message);
        }


        [EasyTcpAction("SAME_NAME")]
        public void SameNameError(Message message)
        {
            tcpClient = null;
            if (mainApp.InvokeRequired)
            {
                mainApp.Invoke((Action<string>)mainApp.WriteMessage, new object[] { message.ToString(Encoding.Unicode) });
            }
            else
            {
                mainApp.WriteMessage(message.ToString(Encoding.Unicode));
            }
        }

        [EasyTcpAction("GET_MESSAGE")]
        public void GetMessage(Message message)
        {
            if (mainApp.InvokeRequired)
            {
                mainApp.Invoke((Action<string>)mainApp.WriteMessage, new object[] { message.ToString(Encoding.Unicode) });
            }
            else
            {
                mainApp.WriteMessage(message.ToString(Encoding.Unicode));
            }
        }

        [EasyTcpAction("GET_USERS_LIST")]
        public void GetUsersList(Message message)
        {
            clientsList = message.ToString(Encoding.Unicode).Split('\u241E', StringSplitOptions.RemoveEmptyEntries);
            Main.clientsList.Clear();
            Main.clientsList.AddRange(clientsList);
            if (mainApp.InvokeRequired)
            {
                mainApp.Invoke((Action)mainApp.UpdateConnectedUsersList, new object[] {});
            }
            else
            {
                mainApp.UpdateConnectedUsersList();
            }
        }
    }
}
