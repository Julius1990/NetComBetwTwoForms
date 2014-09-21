using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComunicationBetweenTwo
{
    class _Client
    {
        ClientForm parent;
        System.Net.Sockets.TcpClient clientSocket;
        public _Client(ClientForm parent_in)
        {
            parent = parent_in;
        }
        public void start()
        {
            System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

            clientSocket.Connect("127.0.0.1", 8888);
            parent.textBoxClientLog.AppendText("Client Socket Program - Server Connected ...");
        }

        public void senden()
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(parent.textBoxSenden.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[10025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            parent.textBoxEmpfangen.AppendText(returndata);
            parent.textBoxSenden.Text = "";
            parent.textBoxSenden.Focus();
        }
    }
}
