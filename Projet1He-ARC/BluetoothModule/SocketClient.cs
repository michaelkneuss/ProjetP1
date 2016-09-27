using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace Global.SocketClient
{
    class SocketClient
    {
        static public long ip2long(string ip)
        {
            return IPAddress.Parse(ip).Address;
        }
        static void Main(string[] args)
        {
            long adress = ip2long("192.168.0.11");
            System.Net.IPEndPoint ip = new System.Net.IPEndPoint(adress, 443);
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect("192.168.0.11", 443);
            // Uses the GetStream public method to return the NetworkStream.
            NetworkStream netStream = tcpClient.GetStream();
            if (tcpClient.Connected)
                Console.WriteLine("You are Connected");
            else
                Console.WriteLine("You are not connected");
            if (netStream.CanWrite)
            {
                Byte[] sendBytes = Encoding.UTF8.GetBytes("Is anybody there?");
                netStream.Write(sendBytes, 0, sendBytes.Length);
            }
            else
            {
                Console.WriteLine("You cannot write data to this stream.");
                tcpClient.Close();

                // Closing the tcpClient instance does not close the network stream.
                netStream.Close();
                return;
            }

            if (netStream.CanRead)
            {
                // Reads NetworkStream into a byte buffer.
                byte[] bytes = new byte[tcpClient.ReceiveBufferSize];

                // Read can return anything from 0 to numBytesToRead. 
                // This method blocks until at least one byte is read.
                netStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);

                // Returns the data received from the host to the console.
                string returndata = Encoding.UTF8.GetString(bytes);

                Console.WriteLine("This is what the host returned to you: " + returndata);

            }
            else
            {
                Console.WriteLine("You cannot read data from this stream.");
                tcpClient.Close();

                // Closing the tcpClient instance does not close the network stream.
                netStream.Close();
                return;
            }

            netStream.Close();
        }
    }
}
