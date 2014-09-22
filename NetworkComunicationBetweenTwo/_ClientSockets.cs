using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComunicationBetweenTwo
{
    class _ClientSockets
    {
        Socket socket;
        ClientForm parent;
        public _ClientSockets(ClientForm parent_in)
        {
            parent = parent_in;
        }
        public void start()
        {
            parent.textBoxClientLog.AppendText("Connecting..." + Environment.NewLine);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEndPoint = new IPEndPoint(Dns.Resolve("192.168.178.39").AddressList[0], 6666);
            socket.Connect(serverEndPoint);
            parent.textBoxClientLog.AppendText("Socket connected to "+ socket.RemoteEndPoint.ToString()+Environment.NewLine);

            // Encode the data string into a byte array.
            byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

            // Send the data through the socket.
            int bytesSent = socket.Send(msg);

            byte[] bytes = new byte[1024];

            // Receive the response from the remote device.
            int bytesRec = socket.Receive(bytes);
            Console.WriteLine("Echoed test = {0}",
                Encoding.ASCII.GetString(bytes, 0, bytesRec));

            // Release the socket.
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();

            /*byte[] byteGelesen = new byte[1024];
            int i = socket.Receive(byteGelesen);
            char[] einzeln = new char[i];
            System.Text.Decoder deco = System.Text.Encoding.UTF8.GetDecoder();
            int charlen = deco.GetChars(byteGelesen, 0, i,einzeln, 0);
            System.String received = new string(einzeln);

            parent.textBoxEmpfangen.AppendText(received + Environment.NewLine);*/
        }
    }
}
