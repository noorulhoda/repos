using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Client
    {

        public string name;
        TcpClient _tcpClient;
        public TcpClient tcpClient { get { return _tcpClient; } }
        StreamWriter _streamWriter;
        StreamReader _streamReader;
        public  event Action<string> newClientEvt;

        public Client(TcpClient tcC)
        {    
            _tcpClient = tcC;
            NetworkStream networkStream = tcpClient.GetStream();
            _streamWriter = new StreamWriter(networkStream);
            _streamWriter.AutoFlush = true;
            _streamReader = new StreamReader(networkStream);
        }

    
        public async void ReadMsgs()
        {
            newClientEvt(await _streamReader.ReadLineAsync());
            while (true)
            {
                string msg = await _streamReader.ReadLineAsync();
            }
        }
        public async void SendMsg(string s)
        {
            _streamWriter.WriteLine(s);
        }
    }
}
