using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
 
    public partial class frmClient : Form
    {
        StreamWriter streamWriter;
        StreamReader streamReader;

        public frmClient()
        {
            InitializeComponent();
        }
       
        private void connect()
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect("127.0.0.1", 5500);
            MessageBox.Show("connected");
            NetworkStream networkStream = tcpClient.GetStream();
            streamWriter = new StreamWriter(networkStream);
            streamReader = new StreamReader(networkStream);
            Receive();
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {

        }
        private async void send()
        {
            streamWriter.WriteLineAsync(txtMsg.Text);
            streamWriter.Flush();
            txtReceivedMessages.Text += "\n from me :" + txtMsg.Text;
            txtMsg.Text = "";

        }
        private async void Receive()
        {
            while (true)
            {
                string msg = await streamReader.ReadLineAsync();
                txtReceivedMessages.Text += "\n myfriend :" + msg;
            }
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            send();
        }
    }
}
