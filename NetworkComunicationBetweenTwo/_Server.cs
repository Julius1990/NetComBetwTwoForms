using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net;
using System.Threading;

namespace NetworkComunicationBetweenTwo
{
    class _Server
    {
        ServerForm parent;
        public _Server(ServerForm parent_in)
        {
            parent = parent_in;
        }
        public void start()
        {
            IPAddress myAddress = IPAddress.Parse("192.168.178.39");

            parent.textBoxServerLog.AppendText("Connecting..." + Environment.NewLine);

            TcpListener tcpList = new TcpListener(myAddress, 8001);
            tcpList.Start();

            Socket socketForClient = tcpList.AcceptSocket();

            if (socketForClient.Connected)
            {
                parent.textBoxServerLog.AppendText("connected" + Environment.NewLine);

                NetworkStream netStream = new NetworkStream(socketForClient);

                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(netStream);

                System.IO.StreamReader streamReader = new System.IO.StreamReader(netStream);

                string zuSenden = "sendign";

                streamWriter.WriteLine(zuSenden);
                streamWriter.Flush();

                string gelesen = streamReader.ReadLine();
                parent.textBoxServerLog.AppendText("gelesen: " + gelesen + Environment.NewLine);

                streamReader.Close();
                netStream.Close();
                streamWriter.Close();
            }

            socketForClient.Close();
            parent.textBoxServerLog.AppendText("Exiting" + Environment.NewLine);
        }
    }
}
