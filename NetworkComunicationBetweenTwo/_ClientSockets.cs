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

            /*Neuen Socket anlegen über den die Kommunikation laufen soll.
             Der Endpoint wird mit der IP des Zielcomputers initialisiert.
             Der Socket wird gestartet.*/
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEndPoint = new IPEndPoint(Dns.Resolve("192.168.178.39").AddressList[0], 6666);
            socket.Connect(serverEndPoint);
            parent.textBoxClientLog.AppendText("Socket connected to "+ socket.RemoteEndPoint.ToString()+Environment.NewLine);

            /*Nachricht verfassen und als Byte codieren.
             Anschließend wird die Nachricht gesendet*/
            byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");
            int bytesSent = socket.Send(msg);

            /*In bytes wird die empfangene Nachricht gespeichert
             bytesRec nimmt die Anzahl der empfangenen Bytes auf*/
            byte[] bytes = new byte[1024];
            int bytesRec = socket.Receive(bytes);
            parent.textBoxEmpfangen.AppendText("Echoed test: "+ Encoding.ASCII.GetString(bytes, 0, bytesRec)+Environment.NewLine);

            ///*Socket schließen und Kommunikation beenden*/
            //socket.Shutdown(SocketShutdown.Both);
            //socket.Close();
        }
        public void send(string message_in)
        {
            byte[] messageByte = Encoding.ASCII.GetBytes(message_in);
            int bytesSend = socket.Send(messageByte);

            byte[] empfangenByte = new byte[1024];
            int byteEmpfCount = socket.Receive(empfangenByte);
            parent.textBoxEmpfangen.AppendText(Encoding.ASCII.GetString(empfangenByte, 0, byteEmpfCount) + Environment.NewLine);
        }
    }
}
