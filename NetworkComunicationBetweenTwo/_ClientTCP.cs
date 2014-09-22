using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComunicationBetweenTwo
{
    class _ClientTCP
    {
        ClientForm parent;
        public _ClientTCP(ClientForm parent_in)
        {
            parent = parent_in;
        }
        byte[] photo;
        public byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            BinaryReader reader = new BinaryReader(stream);
            //BinaryWriter writer = new BinaryWriter(File.Open("GoodLuckToMe.jpg", FileMode.Create));

            photo = reader.ReadBytes((int)stream.Length);

            //writer.Write(photo);

            long ll = photo.Length;
            reader.Close();
            //writer.Close();
            stream.Close();

            return photo;
        }
        public void send()
        {
            Int32 port = 9999;
            TcpClient client = new TcpClient("192.168.178.39", port);

            parent.textBoxClientLog.AppendText("Connected" + Environment.NewLine);

            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = GetPhoto("hallo.jpg");

            parent.textBoxClientLog.AppendText("Message translated" + Environment.NewLine);

            NetworkStream stream = client.GetStream();

            // Send the message to the connected TcpServer.
            stream.Write(data, 0, data.Length);

            parent.textBoxClientLog.AppendText("Sendevorgang abgeschlossen" + Environment.NewLine);
        }
    }
}
