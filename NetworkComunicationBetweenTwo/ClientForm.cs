using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkComunicationBetweenTwo
{
    public partial class ClientForm : Form
    {
        _Client meinClient;
        _ClientSockets socketClient;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socketClient.send();
        }

        private void buttonClientStarten_Click(object sender, EventArgs e)
        {
            meinClient = new _Client(this);
            meinClient.start();
        }

        private void buttonSimpelClientStart_Click(object sender, EventArgs e)
        {
            _ClientTCP meinSimple = new _ClientTCP(this);
            meinSimple.send();
        }

        private void buttonSocketStart_Click(object sender, EventArgs e)
        {
            socketClient = new _ClientSockets(this);
            socketClient.verbindung("Test");
        }
    }
}
