using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace NetworkComunicationBetweenTwo
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void buttonServerStarten_Click(object sender, EventArgs e)
        {
            _Server meinServer = new _Server(this);
            meinServer.start();
        }

        private void buttonServerSimpleStart_Click(object sender, EventArgs e)
        {
            _ServerTCP simple = new _ServerTCP();
            simple.start();
        }

        private void buttonSocketStart_Click(object sender, EventArgs e)
        {
            _ServerSockets socketServer = new _ServerSockets(this);
            socketServer.start();
        }
    }
}
