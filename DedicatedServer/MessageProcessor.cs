using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedicatedServer
{
    class MessageProcessor
    {
        public static byte[] EncodeMessage(string message)
        {
            byte[] encodedMessage = null;
            encodedMessage = Encoding.Unicode.GetBytes(message);
            return encodedMessage;
        }

        public static string DecodeMessage(byte[] encodedMessage)
        {
            string message = string.Empty;
            message = Encoding.Unicode.GetString(encodedMessage);
            return message;
        }
    }
}
