using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Client1
{
    public partial class Form1 : Form
    {
        private HubConnection connection;
        private IHubProxy chatProxy;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new HubConnection("http://localhost:9999/");
            chatProxy = connection.CreateHubProxy("ChatHub");
            connection.Start().Wait();
            label1.Text = "Connected Success";
            chatProxy.On<string, string>("WriteMessage", newMessage);
        }

        private void newMessage(string name, string message)
        {
            string msg = name + ":" + message;
            listBox1.Items.Add(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text += "clicked";
            chatProxy.Invoke("Message", "WinApp", textBox1.Text);
        }
    }
}
