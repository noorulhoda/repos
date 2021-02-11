using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class frmServer : Form
    {
        StreamWriter streamWriter;
        StreamReader streamReader;
        public frmServer()
        {
            InitializeComponent();
        }
        private async void start()
        {
            IPAddress ip =IPAddress.Parse("127.0.0.1");
            TcpListener l = new TcpListener(ip, 5500);
            l.Start();
            MessageBox.Show("started");

           TcpClient tcpClient = await l.AcceptTcpClientAsync();
            NetworkStream networkStream = tcpClient.GetStream();
            streamWriter = new StreamWriter(networkStream);
            streamReader = new StreamReader(networkStream);
            Receive();

        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            start();
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
                txtReceivedMessages.Text += "\n myfriend :"+msg;
            }
        }
        private void frmServer_Load(object sender, EventArgs e)
        {

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            send();
        }

        private void FrmServer_Load_1(object sender, EventArgs e)
        {

        }
    }
}
