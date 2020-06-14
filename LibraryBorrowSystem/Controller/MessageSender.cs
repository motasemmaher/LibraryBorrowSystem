using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBorrowSystem.Controller
{
    public class MessageSender
    {

        private Socket sender;
        private IPHostEntry ipHost;
        private IPAddress ipAddr;
        private IPEndPoint localEndPoint;

        private bool connectToServer()
        {
            try
            {
                ipHost = Dns.GetHostEntry(Dns.GetHostName());
                ipAddr = ipHost.AddressList[0];
                localEndPoint = new IPEndPoint(ipAddr, 11111);

                sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public string SendEmail(string to, string subject, string body)
        {
            try
            {
                connectToServer();
                sender.Connect(localEndPoint);

                Console.WriteLine("Socket connected to -> {0} ",
                              sender.RemoteEndPoint.ToString());

                byte[] messageSent = Encoding.ASCII.GetBytes(string.Format("{0}\r\n{1}\r\n{2}\r\n<EOF>", to, subject, body));
                int byteSent = sender.Send(messageSent);

                byte[] messageReceived = new byte[1024];

                int byteRecv = sender.Receive(messageReceived);
                string servermsg = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
                Console.WriteLine("Message from Server -> {0}", servermsg);

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                return servermsg;
            }

            // Manage of Socket's Exceptions 
            catch (ArgumentNullException ane)
            {

                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                return ane.ToString();
            }

            catch (SocketException se)
            {

                Console.WriteLine("SocketException : {0}", se.ToString());
                return se.ToString();
            }

            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
                return e.ToString();
            }
        }
        
    }
}
