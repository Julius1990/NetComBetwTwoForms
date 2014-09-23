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
        public void verbindung(String botschaft_in)
        {
            parent.textBoxClientLog.AppendText("Connecting..." + Environment.NewLine);

            /*Neuen Socket anlegen über den die Kommunikation laufen soll.
             Der Endpoint wird mit der IP des Zielcomputers initialisiert.
             Der Socket wird gestartet.*/
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEndPoint = new IPEndPoint(Dns.Resolve("192.168.178.39").AddressList[0], 6666);
            socket.Connect(serverEndPoint);
            parent.textBoxClientLog.AppendText("Socket connected to " + socket.RemoteEndPoint.ToString() + Environment.NewLine);

            /*Nachricht verfassen und als Byte codieren.
             Anschließend wird die Nachricht gesendet*/
            string gelesen = botschaft_in+"<EOF>";
            byte[] msg = Encoding.ASCII.GetBytes(gelesen);
            int bytesSent = socket.Send(msg);

            /*In bytes wird die empfangene Nachricht gespeichert
             bytesRec nimmt die Anzahl der empfangenen Bytes auf*/
            string data = null;
            while (true)
            {
                byte[] bytes = new byte[1024];
                int bytesRec = socket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.IndexOf("<EOF>") > -1)
                {
                    break;
                }
            }

            ///*Socket schließen und Kommunikation beenden*/
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            parent.textBoxClientLog.AppendText("Connection closed" + Environment.NewLine);
        }
        public void send()
        {
        }
    }
}
