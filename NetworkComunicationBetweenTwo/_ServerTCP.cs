using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComunicationBetweenTwo
{
    class _ServerTCP
    {
        public void start()
        {
            TcpListener meinServer = null;

            int port = 9999;
            IPAddress myAdd = IPAddress.Parse("192.168.178.39");

            meinServer = new TcpListener(myAdd, port);
            meinServer.Start();

            Byte[] bytes = new Byte[277577];

            TcpClient client = meinServer.AcceptTcpClient();

            NetworkStream netStream = client.GetStream();

            int i = netStream.Read(bytes, 0, 277577);

            BinaryWriter writer = new BinaryWriter(File.Open("goFuck.jpg", FileMode.Create));
            writer.Write(bytes);
            writer.Close();

            client.Close();
        }
    }
}
