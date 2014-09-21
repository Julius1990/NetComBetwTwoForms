using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComunicationBetweenTwo
{
    class _Client
    {
        ClientForm parent;
        NetworkStream netStream;
        StreamReader streamReader;
        StreamWriter streamWriter;

        public _Client(ClientForm parent_in)
        {
            parent = parent_in;
        }
        public void start()
        {
            TcpClient socketForServer = new TcpClient();
            parent.textBoxClientLog.AppendText("Connecting....."+Environment.NewLine);

            socketForServer.Connect("192.168.178.39", 8001);
            // use the ipaddress as in the server program

            parent.textBoxClientLog.AppendText("Connected"+Environment.NewLine);

            netStream = socketForServer.GetStream();
            streamReader = new System.IO.StreamReader(netStream);
            streamWriter = new StreamWriter(netStream);
        }

        public void senden()
        {
            string gelesen = streamReader.ReadLine();
            parent.textBoxEmpfangen.AppendText(gelesen);

            string senden = parent.textBoxSenden.Text;
            streamWriter.WriteLine(senden);
            streamWriter.Flush();

            parent.textBoxSenden.Text = "";

            netStream.Close();
        }
    }
}
