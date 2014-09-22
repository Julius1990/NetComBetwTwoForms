using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkComunicationBetweenTwo
{
    class _ServerSockets
    {
        Socket server = null;
        ServerForm parent;
        public _ServerSockets(ServerForm parent_in)
        {
            parent = parent_in;
        }
        public void start()
        {
            parent.textBoxServerLog.AppendText("Connecting..." + Environment.NewLine);

            SocketPermission permission = new SocketPermission(NetworkAccess.Accept, TransportType.Tcp, "", SocketPermission.AllPorts);

            /*Stellt irgendwas mit der IP Adresse an. Diese muss vom Server Computer sein.
            Soweit ich das verstanden habe, gibt es bei Computern mit mehreren Netwerkgeräten mehrere mögliche
            Ip Adressen. Deswegen wird hier die erste ausgewählt.
            Jetzt wird ein neuer Endpoint angelegt an welchem die Verbindung stattfinden wird.*/
            IPHostEntry ipHost = Dns.GetHostEntry("192.168.178.39");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 6666);

            /*Ein neuer Socket wird angelegt (Server-Socket). Stream wegen Datenübertragung und TCP spezifiziert
            das zu verwendende Protokoll.
            Mit Bind wird der Socket an den festgelegten Endpoint gebunden.
            Listen spezifiziert eine maximale Anzahl an Clients. Versuchen mehr als hier angegeben sich zu verbinden,
            so bekommen sie einen "server is busy error".*/
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipEndPoint);
            server.Listen(10);

            /*Jetzt wird ein weiter Socket erstellt, dieser ist nötig um etwas senden bzw empfangen zu könnnen. */
            Socket handler = server.Accept();

            String data = null;

            /*So lange etwas ankommt, wird alles in den String gespeichert. Tritt das Ende der Nachricht ein,
             ("<EOF>"), so ist der Empfangsvorgang beendet.*/
            while (true)
            {
                byte[] bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.IndexOf("<EOF>") > -1)
                {
                    break;
                }
            }

            // Show the data on the console.
            parent.textBoxServerLog.AppendText("Text received : {0}"+ data+Environment.NewLine);

            // Echo the data back to the client.
            byte[] msg = Encoding.ASCII.GetBytes(data);

            handler.Send(msg);
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();

            /*
            while (SocketConnected(server))
            {
                Debug.WriteLine("While");
                Thread.Sleep(5000);
                parent.textBoxServerLog.AppendText("No Connection yet" + Environment.NewLine);
            }
            parent.textBoxServerLog.AppendText("Connection established" + Environment.NewLine);

            if (!SocketConnected(server))
            {
                try
                {
                    parent.textBoxServerLog.AppendText("Versuche zu senden");
                    string zuSenden = "Fick dich alter";
                    byte[] byteZuSenden = System.Text.Encoding.ASCII.GetBytes(zuSenden);
                    server.Send(byteZuSenden);
                    byte[] empfB = new byte[1024];
                    int erm = server.Receive(empfB);
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.ErrorCode.ToString());
                }
            }
            else
            {
                parent.textBoxServerLog.AppendText("Senden fehlgeschlagen, es besteht keine Verbindung");
            }*/
        }
        private bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }
    }
}
