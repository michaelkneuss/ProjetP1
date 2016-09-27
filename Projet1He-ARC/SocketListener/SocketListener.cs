using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace SocketListener
{
    class SocketListener
    {
        static public long ip2long(string ip)
        {
            return IPAddress.Parse(ip).Address;
        }
        static void Main(string[] args)
        {
            long adress = ip2long("192.168.0.11");
            System.Net.IPEndPoint ip = new System.Net.IPEndPoint(adress, 443);
            TcpListener tcpServ = new TcpListener(ip);
            tcpServ.Start();
            tcpServ.AcceptSocket();
        }
    }
}
